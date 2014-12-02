Public Class TaskMan

    Private Sub Init() Handles MyBase.Load
        'This was meant to be placed in the designer but gets overwritten when editing :/
        lvwColumnSorter = New ListViewColumnSorter()
        taskList.ListViewItemSorter = lvwColumnSorter
        lvwColumnSorter.SortColumn = 0
        lvwColumnSorter.Order = SortOrder.Ascending
        taskList.Sort()



        refreshList()
    End Sub

    Private Sub KillTask() Handles KillButton.Click, MenuKill.Click, MenuKill.Click, DropdownKill.Click
        If taskList.FocusedItem.Selected Then
            Dim answer As MsgBoxResult = MsgBox("Are you sure you want to end the process?", MsgBoxStyle.YesNo, "")
            If answer = MsgBoxResult.Yes Then
                Dim taskId As Integer
                taskId = taskList.FocusedItem.SubItems(1).Text
                Try
                    Process.GetProcessById(taskId).Kill()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Threading.Thread.Sleep(200)
                refreshList()
            End If
        End If
    End Sub

    Private Sub RefreshList() Handles RefreshButton.Click
        taskList.Items.Clear() 'Clear list
        processLabel.Text = "Processes: " & Process.GetProcesses.Length 'Add number of current processes to label
        For Each proc In Process.GetProcesses()
            Dim lvi As ListViewItem
            lvi = taskList.Items.Add(proc.ProcessName)  'Add process name to list
            lvi.SubItems.Add(proc.Id) 'Add process ID to list
            'Add Memory usage to list
            lvi.SubItems.Add((proc.WorkingSet64 / 1024).ToString("0,000") & " K ")
            Try
                'Try to add Description to list
                lvi.SubItems.Add(proc.MainModule.FileVersionInfo.FileDescription)
            Catch ex As Exception
                'Else add Description Manually
                lvi.SubItems.Add(descswitch(proc.ProcessName))
            End Try
        Next
    End Sub

    Private Sub ColumnClicked(sender As Object, e As ColumnClickEventArgs) Handles taskList.ColumnClick
        ' Determine if the clicked column is already the column that is 
        ' being sorted.
        If e.Column = 0 Or 3 Then
            If (e.Column = lvwColumnSorter.SortColumn) Then
                ' Reverse the current sort direction for this column.
                If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                    lvwColumnSorter.Order = SortOrder.Descending
                Else
                    lvwColumnSorter.Order = SortOrder.Ascending
                End If
            Else
                ' Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column
                lvwColumnSorter.Order = SortOrder.Ascending
            End If

            ' Perform the sort with these new sort options.
            taskList.Sort()
        End If
    End Sub

    Private Sub OpenAbout() Handles MenuAbout.Click
        About.Show()
    End Sub

    Private Sub quitClick() Handles MenuQuit.Click
        End
    End Sub

    Private Sub ChangePriority(sender As Object, e As EventArgs) Handles Priority0.Click, Priority1.Click, Priority2.Click, Priority3.Click, Priority4.Click, Priority5.Click
        Dim taskId = Process.GetProcessById(taskList.FocusedItem.SubItems(1).Text)
        Select Case sender
            Case Priority0
                taskId.PriorityClass = ProcessPriorityClass.RealTime
                MsgBox(taskId.PriorityClass.ToString)
            Case Priority1
                taskId.PriorityClass = ProcessPriorityClass.High
                MsgBox(taskId.PriorityClass.ToString)
            Case Priority2
                taskId.PriorityClass = ProcessPriorityClass.AboveNormal
                MsgBox(taskId.PriorityClass.ToString)
            Case Priority3
                taskId.PriorityClass = ProcessPriorityClass.Normal
                MsgBox(taskId.PriorityClass.ToString)
            Case Priority4
                taskId.PriorityClass = ProcessPriorityClass.BelowNormal
                MsgBox(taskId.PriorityClass.ToString)
            Case Priority5
                taskId.PriorityClass = ProcessPriorityClass.Idle
                MsgBox(taskId.PriorityClass.ToString)
        End Select

    End Sub

    Private Sub FileProperties() Handles DropdownProperties.Click
        If Not taskList.FocusedItem.SubItems(1).Text = "0" Then
            Dim query = "SELECT ExecutablePath FROM Win32_Process WHERE ProcessId = " & taskList.FocusedItem.SubItems(1).Text
            Dim searcher = New Management.ManagementObjectSearcher(query).Get().Cast(Of Management.ManagementObject).FirstOrDefault()
            Dim location = searcher.Properties.Item("ExecutablePath").Value.ToString
            Dim objShell As Shell32.Shell
            objShell = New Shell32.Shell
            objShell.NameSpace(0).ParseName(location).InvokeVerb("Properties")
        End If
    End Sub
End Class
