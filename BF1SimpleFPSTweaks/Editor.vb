Imports System.IO

Public Class Editor
    Public Sub makeChanges(ByVal filePath As String)
        Dim i As Integer
        Dim lines(2) As String
        Dim newCfg As String = filePath + "user.cfg"
        If (File.Exists(newCfg)) Then

        End If
        Dim cfgFile As New System.IO.StreamWriter(filePath + "user.cfg", True)
        lines(0) = "perfoverlay.drawfps 1"
        lines(1) = "gametime.maxvariablefps 61"
        lines(2) = "RenderDevice.RenderAheadLimit 2"

        For i = 0 To 2
            cfgFile.WriteLine(lines(i))
        Next
        cfgFile.Close()
        MsgBox("Updated")
    End Sub
End Class
