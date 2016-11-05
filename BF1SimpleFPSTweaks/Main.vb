Public Class Main
    Private currentPath As String              'Houses the main file path for BF1
    Private paths As Pathing = New Pathing()   'Instance of Pathing Control for finding things like the game folder and it's subs 
    Private Editor As Editor = New Editor()    'Instance of Editor Controll which makes the actual changes to user files 
    Public Shared primeWindow As Main

    Private Sub SetDefaults(send As Object, e As EventArgs) Handles MyBase.Load
        'Defaults
            currentPath = " "
        'Singleton stuff (makes it easier to get members from across the solution)
            primeWindow = Me
        'Defaults for user.CFG
            'Set the values for the combo box for pre rendered frames
                Dim i As Integer
                For i = 1 To 4
                    preFrameDrop.Items.Add(i)
                Next
            'And the default 
                preFrameDrop.SelectedIndex = 1
            'Reasonable Frame Rate Default
                frameRate.Text = "61"
            'Default Selected Values
                checkFrame.Checked = True
                checkPreFrame.Checked = True
    End Sub

    Private Sub Launch_Auto_Detect(sender As Object, e As EventArgs) Handles AutoDetect.Click
        currentPath = paths.AutoDetect()
        curSavePath.Text = currentPath
    End Sub

    Private Sub ManualPathing(sender As Object, e As EventArgs) Handles ManualLocate.Click
        currentPath = paths.ManualDetect()
        curSavePath.Text = currentPath
    End Sub

    Private Sub curSavePath_TextChanged(sender As Object, e As EventArgs) Handles curSavePath.TextChanged
        currentPath = curSavePath.Text
    End Sub

    Private Sub editCFG(sender As Object, e As EventArgs) Handles writeOut.Click
        If (currentPath.Length > 2) Then
            Editor.makeChanges(currentPath)
        End If
    End Sub

    Private Sub removeCFG_Click(sender As Object, e As EventArgs) Handles removeCFG.Click
        If (currentPath.Length > 2) Then
            Editor.removeCFG(currentPath)
        End If
    End Sub
End Class
