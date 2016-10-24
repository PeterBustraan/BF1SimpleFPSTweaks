Imports System.IO

Public Class Editor

    Dim lineList As  New List(Of String) ()

    Public Sub makeChanges(ByVal filePath As String)
        'get main window
            Dim prime As Main = Main.primeWindow
        'setup user install path
            Dim newCfg As String = filePath + "user.cfg"
        'Find previous config for preservation
            If (File.Exists(newCfg)) Then
                File.Copy(newCfg, newCfg + ".bak")
            'Re assure user they aren't loosing anything
                MsgBox("Backing up and Adding new user.cfg file")
            End If
        'Prepare to edit new config File
            Dim cfgFile As New System.IO.StreamWriter(newCfg, True)
        'Logic to determine lines to add
            If (prime.checkFPS.Checked) Then 'FPS Counter
                lineList.Add("perfoverlay.drawfps 1")
            End If
            If (prime.checkFPS.Checked) Then 'FPS Limit
                lineList.Add("gametime.maxvariablefps " + prime.frameRate.Text)
            End If
            If (prime.checkFPS.Checked) Then 'Frames Rendered In Advance
                lineList.Add("RenderDevice.RenderAheadLimit " + prime.preFrameDrop.SelectedItem.ToString)
            End If
        'Write new config lines to file
            For Each item As Integer In lineList
                cfgFile.WriteLine(item)
            Next
        'Release file writer and file
            cfgFile.Close()
        'Alert user so they won't wonder if something happened
            MsgBox("Updated")
    End Sub
End Class
