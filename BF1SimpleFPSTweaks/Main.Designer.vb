<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AutoDetect = New System.Windows.Forms.Button()
        Me.curSavePath = New System.Windows.Forms.TextBox()
        Me.ManualLocate = New System.Windows.Forms.Button()
        Me.writeOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AutoDetect
        '
        Me.AutoDetect.Location = New System.Drawing.Point(12, 12)
        Me.AutoDetect.Name = "AutoDetect"
        Me.AutoDetect.Size = New System.Drawing.Size(112, 23)
        Me.AutoDetect.TabIndex = 0
        Me.AutoDetect.Text = "Auto Detect Install"
        Me.AutoDetect.UseVisualStyleBackColor = True
        '
        'curSavePath
        '
        Me.curSavePath.Location = New System.Drawing.Point(130, 44)
        Me.curSavePath.Name = "curSavePath"
        Me.curSavePath.Size = New System.Drawing.Size(383, 20)
        Me.curSavePath.TabIndex = 1
        '
        'ManualLocate
        '
        Me.ManualLocate.Location = New System.Drawing.Point(12, 41)
        Me.ManualLocate.Name = "ManualLocate"
        Me.ManualLocate.Size = New System.Drawing.Size(112, 23)
        Me.ManualLocate.TabIndex = 2
        Me.ManualLocate.Text = "Manual Detect"
        Me.ManualLocate.UseVisualStyleBackColor = True
        '
        'writeOut
        '
        Me.writeOut.Location = New System.Drawing.Point(12, 84)
        Me.writeOut.Name = "writeOut"
        Me.writeOut.Size = New System.Drawing.Size(112, 23)
        Me.writeOut.TabIndex = 3
        Me.writeOut.Text = "Update CFG"
        Me.writeOut.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 157)
        Me.Controls.Add(Me.writeOut)
        Me.Controls.Add(Me.ManualLocate)
        Me.Controls.Add(Me.curSavePath)
        Me.Controls.Add(Me.AutoDetect)
        Me.Name = "Main"
        Me.Text = "BF1 FPS Tweaks Alpha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutoDetect As Button
    Friend WithEvents curSavePath As TextBox
    Friend WithEvents ManualLocate As Button
    Friend WithEvents writeOut As Button
End Class
