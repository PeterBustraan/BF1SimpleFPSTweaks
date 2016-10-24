Public Class Pathing
    Public Function AutoDetect() As String
        Dim regPath As String = "Could Not Find"
        Dim rawPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\EA Games\Battlefield 1",
                                         "Install Dir", Nothing)
        If rawPath IsNot Nothing Then
            Return (rawPath)
        End If
        Return regPath
    End Function
    Public Function ManualDetect() As String
        Dim regPath As String = "Invalid Path"
        Dim foundPath As String
        Dim rawPath As New OpenFileDialog()

        rawPath.Filter = "All Files (*.*)|*.*" &
                         "|Game Executable (*.exe)|*.exe"
        rawPath.FilterIndex = 2
        If rawPath.ShowDialog() =
            DialogResult.OK Then
            If Dir(rawPath.FileName) <> "" Then
                foundPath = rawPath.FileName.Substring(0, rawPath.FileName.LastIndexOf("\") + 1)
                Return foundPath
            End If
        End If
        Return regPath
    End Function
End Class
