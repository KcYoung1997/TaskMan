Partial Class TaskMan

    'Many Processes do not have process descriptions so must have them provided manually
    'This list allows the program to do this - feel free to add any as you find them

    Private Function descswitch(i)
        Select Case i
            Case "explorer"
                Return "Windows Explorer"
            Case "svchost"
                Return ("Host Process for Windows")
            Case "csrss"
                Return ("Client Server Runtime Process")
            Case "conhost"
                Return ("Console Window Host")
            Case "dwm"
                Return ("Desktop Window Manager")
            Case "spoolsv"
                Return ("Spooler SubSystem App")
            Case "lsass"
                Return ("Local Security Authority Process")
            Case "taskmgr"
                Return ("Windows Taks Manager - Why are you using mine then?")
            Case "lsm"
                Return ("Local Session Manager Service")
            Case "services"
                Return ("Services and Controllers App")
            Case "smss"
                Return ("Windows Session Manager")
            Case "SearchIndexer"
                Return ("Windows Search Indexer")
            Case "SearchProtocolHost"
                Return ("Windows Search Protocol Host")
            Case "SearchFilterHost"
                Return ("Windows Search Filter Host")
            Case "WUDFHost"
                Return ("Windows User Driver Framework")
            Case "winlogon"
                Return ("Windows Logon Applicatoion")
            Case "taskhost"
                Return ("Host Process for Windows Tasks")
            Case "audiodg"
                Return ("Windows Audio Graph Device Isolation")
            Case "wininit"
                Return ("Windows Start-up Application")
            Case "system"
                Return ("NT Kernel & System")
            Case "Idle"
                Return ("SystemblahIdle Process")
            Case "wmpnetwk"
                Return ("Windows Media Player Sharing Service")
        End Select
        Return ""
    End Function
End Class

