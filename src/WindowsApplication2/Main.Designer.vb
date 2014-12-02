<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskMan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private lvwColumnSorter As ListViewColumnSorter

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.taskList = New System.Windows.Forms.ListView()
        Me.TaskName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Memory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DropdownDirectory = New System.Windows.Forms.ToolStripMenuItem()
        Me.DropdownProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DropdownKill = New System.Windows.Forms.ToolStripMenuItem()
        Me.DropdownPriority = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Priority5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuKill = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.processLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ListMenu.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'taskList
        '
        Me.taskList.AllowColumnReorder = True
        Me.taskList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TaskName, Me.ID, Me.Memory, Me.Description})
        Me.taskList.ContextMenuStrip = Me.ListMenu
        Me.taskList.FullRowSelect = True
        Me.taskList.HideSelection = False
        Me.taskList.Location = New System.Drawing.Point(31, 25)
        Me.taskList.Name = "taskList"
        Me.taskList.Size = New System.Drawing.Size(537, 423)
        Me.taskList.TabIndex = 0
        Me.taskList.UseCompatibleStateImageBehavior = False
        Me.taskList.View = System.Windows.Forms.View.Details
        '
        'TaskName
        '
        Me.TaskName.Text = "Task Name"
        Me.TaskName.Width = 138
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Memory
        '
        Me.Memory.Text = "Memory"
        Me.Memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Memory.Width = 106
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 201
        '
        'ListMenu
        '
        Me.ListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DropdownDirectory, Me.DropdownProperties, Me.ToolStripSeparator1, Me.DropdownKill, Me.DropdownPriority})
        Me.ListMenu.Name = "ContextMenuStrip1"
        Me.ListMenu.Size = New System.Drawing.Size(176, 98)
        '
        'DropdownDirectory
        '
        Me.DropdownDirectory.Name = "DropdownDirectory"
        Me.DropdownDirectory.Size = New System.Drawing.Size(175, 22)
        Me.DropdownDirectory.Text = "&Open File Directory"
        '
        'DropdownProperties
        '
        Me.DropdownProperties.Name = "DropdownProperties"
        Me.DropdownProperties.Size = New System.Drawing.Size(175, 22)
        Me.DropdownProperties.Text = "&Properties"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'DropdownKill
        '
        Me.DropdownKill.Name = "DropdownKill"
        Me.DropdownKill.Size = New System.Drawing.Size(175, 22)
        Me.DropdownKill.Text = "&Kill Task"
        '
        'DropdownPriority
        '
        Me.DropdownPriority.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Priority0, Me.Priority1, Me.Priority2, Me.Priority3, Me.Priority4, Me.Priority5})
        Me.DropdownPriority.Name = "DropdownPriority"
        Me.DropdownPriority.Size = New System.Drawing.Size(175, 22)
        Me.DropdownPriority.Text = "&Task Priority"
        '
        'Priority0
        '
        Me.Priority0.Name = "Priority0"
        Me.Priority0.Size = New System.Drawing.Size(152, 22)
        Me.Priority0.Text = "Realtime"
        '
        'Priority1
        '
        Me.Priority1.Name = "Priority1"
        Me.Priority1.Size = New System.Drawing.Size(152, 22)
        Me.Priority1.Text = "High"
        '
        'Priority2
        '
        Me.Priority2.Name = "Priority2"
        Me.Priority2.Size = New System.Drawing.Size(152, 22)
        Me.Priority2.Text = "Above Normal"
        '
        'Priority3
        '
        Me.Priority3.Name = "Priority3"
        Me.Priority3.Size = New System.Drawing.Size(152, 22)
        Me.Priority3.Text = "Normal"
        '
        'Priority4
        '
        Me.Priority4.Name = "Priority4"
        Me.Priority4.Size = New System.Drawing.Size(152, 22)
        Me.Priority4.Text = "Below Normal"
        '
        'Priority5
        '
        Me.Priority5.Name = "Priority5"
        Me.Priority5.Size = New System.Drawing.Size(152, 22)
        Me.Priority5.Text = "Low (Idle)"
        '
        'KillButton
        '
        Me.KillButton.Location = New System.Drawing.Point(31, 454)
        Me.KillButton.Name = "KillButton"
        Me.KillButton.Size = New System.Drawing.Size(101, 37)
        Me.KillButton.TabIndex = 1
        Me.KillButton.Text = "Kill Task"
        Me.KillButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(467, 454)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(101, 37)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh List"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileBar, Me.HelpBar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(588, 24)
        Me.MenuBar.TabIndex = 3
        Me.MenuBar.Text = "MenuStrip1"
        '
        'FileBar
        '
        Me.FileBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuKill, Me.MenuQuit})
        Me.FileBar.Name = "FileBar"
        Me.FileBar.ShortcutKeyDisplayString = ""
        Me.FileBar.Size = New System.Drawing.Size(37, 20)
        Me.FileBar.Text = "&File"
        '
        'MenuKill
        '
        Me.MenuKill.Name = "MenuKill"
        Me.MenuKill.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.MenuKill.Size = New System.Drawing.Size(158, 22)
        Me.MenuKill.Text = "&Kill Task"
        Me.MenuKill.ToolTipText = "End Highlighted Task"
        '
        'MenuQuit
        '
        Me.MenuQuit.Name = "MenuQuit"
        Me.MenuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MenuQuit.Size = New System.Drawing.Size(158, 22)
        Me.MenuQuit.Text = "&Exit"
        Me.MenuQuit.ToolTipText = "Quit The Program"
        '
        'HelpBar
        '
        Me.HelpBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAbout})
        Me.HelpBar.Name = "HelpBar"
        Me.HelpBar.Size = New System.Drawing.Size(44, 20)
        Me.HelpBar.Text = "&Help"
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(107, 22)
        Me.MenuAbout.Text = "&About"
        Me.MenuAbout.ToolTipText = "Info About The Program"
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.processLabel})
        Me.StatusBar.Location = New System.Drawing.Point(0, 505)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(588, 22)
        Me.StatusBar.TabIndex = 4
        Me.StatusBar.Text = "StatusStrip1"
        '
        'processLabel
        '
        Me.processLabel.Name = "processLabel"
        Me.processLabel.Size = New System.Drawing.Size(88, 17)
        Me.processLabel.Text = "Processes: 1337"
        Me.processLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'TaskMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 527)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.KillButton)
        Me.Controls.Add(Me.taskList)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "TaskMan"
        Me.ShowIcon = False
        Me.Text = "Windows Task Manager"
        Me.ListMenu.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taskList As System.Windows.Forms.ListView
    Friend WithEvents TaskName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Memory As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents KillButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ListMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DropdownKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents processLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DropdownDirectory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DropdownProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropdownPriority As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Priority5 As System.Windows.Forms.ToolStripMenuItem

End Class
