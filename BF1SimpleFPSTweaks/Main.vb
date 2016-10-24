Public Class Main
    Private currentPath As String
    Private paths As Pathing = New Pathing()
    Private Editor As Editor = New Editor()
    Private Sub Launch_Auto_Detect(sender As Object, e As EventArgs) Handles AutoDetect.Click
        currentPath = paths.AutoDetect()
        curSavePath.Text = currentPath
    End Sub

    Private Sub ManualPathing(sender As Object, e As EventArgs) Handles ManualLocate.Click
        currentPath = paths.ManualDetect()
        curSavePath.Text = currentPath
    End Sub

    Private Sub editCFG(sender As Object, e As EventArgs) Handles writeOut.Click
        If (currentPath.Length > 2) Then
            Editor.makeChanges(currentPath)
        End If
    End Sub
End Class
