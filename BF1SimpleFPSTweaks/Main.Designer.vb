﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AutoDetect = New System.Windows.Forms.Button()
        Me.curSavePath = New System.Windows.Forms.TextBox()
        Me.ManualLocate = New System.Windows.Forms.Button()
        Me.writeOut = New System.Windows.Forms.Button()
        Me.DetectionNotice = New System.Windows.Forms.Label()
        Me.checkFPS = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.preFrameDrop = New System.Windows.Forms.ComboBox()
        Me.frameRate = New System.Windows.Forms.TextBox()
        Me.checkPreFrame = New System.Windows.Forms.CheckBox()
        Me.checkFrame = New System.Windows.Forms.CheckBox()
        Me.removeCFG = New System.Windows.Forms.Button()
        Me.checkFPS.SuspendLayout()
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
        Me.curSavePath.Size = New System.Drawing.Size(512, 20)
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
        Me.writeOut.Location = New System.Drawing.Point(6, 91)
        Me.writeOut.Name = "writeOut"
        Me.writeOut.Size = New System.Drawing.Size(112, 23)
        Me.writeOut.TabIndex = 3
        Me.writeOut.Text = "Update CFG"
        Me.writeOut.UseVisualStyleBackColor = True
        '
        'DetectionNotice
        '
        Me.DetectionNotice.AutoSize = True
        Me.DetectionNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetectionNotice.Location = New System.Drawing.Point(130, 15)
        Me.DetectionNotice.Name = "DetectionNotice"
        Me.DetectionNotice.Size = New System.Drawing.Size(512, 20)
        Me.DetectionNotice.TabIndex = 4
        Me.DetectionNotice.Text = "First you must find or auto detect your battle feild 1 install path"
        '
        'checkFPS
        '
        Me.checkFPS.Controls.Add(Me.removeCFG)
        Me.checkFPS.Controls.Add(Me.CheckBox1)
        Me.checkFPS.Controls.Add(Me.preFrameDrop)
        Me.checkFPS.Controls.Add(Me.frameRate)
        Me.checkFPS.Controls.Add(Me.checkPreFrame)
        Me.checkFPS.Controls.Add(Me.checkFrame)
        Me.checkFPS.Controls.Add(Me.writeOut)
        Me.checkFPS.Location = New System.Drawing.Point(12, 70)
        Me.checkFPS.Name = "checkFPS"
        Me.checkFPS.Size = New System.Drawing.Size(299, 128)
        Me.checkFPS.TabIndex = 5
        Me.checkFPS.TabStop = False
        Me.checkFPS.Text = "user.CFG options"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(284, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Frame Counter (stops after respawn or map load)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'preFrameDrop
        '
        Me.preFrameDrop.FormattingEnabled = True
        Me.preFrameDrop.Location = New System.Drawing.Point(122, 66)
        Me.preFrameDrop.Name = "preFrameDrop"
        Me.preFrameDrop.Size = New System.Drawing.Size(41, 21)
        Me.preFrameDrop.TabIndex = 8
        '
        'frameRate
        '
        Me.frameRate.Location = New System.Drawing.Point(122, 44)
        Me.frameRate.Name = "frameRate"
        Me.frameRate.Size = New System.Drawing.Size(41, 20)
        Me.frameRate.TabIndex = 7
        '
        'checkPreFrame
        '
        Me.checkPreFrame.AutoSize = True
        Me.checkPreFrame.Location = New System.Drawing.Point(7, 68)
        Me.checkPreFrame.Name = "checkPreFrame"
        Me.checkPreFrame.Size = New System.Drawing.Size(113, 17)
        Me.checkPreFrame.TabIndex = 6
        Me.checkPreFrame.Text = "Set Frames Ahead"
        Me.checkPreFrame.UseVisualStyleBackColor = True
        '
        'checkFrame
        '
        Me.checkFrame.AutoSize = True
        Me.checkFrame.Location = New System.Drawing.Point(7, 44)
        Me.checkFrame.Name = "checkFrame"
        Me.checkFrame.Size = New System.Drawing.Size(105, 17)
        Me.checkFrame.TabIndex = 5
        Me.checkFrame.Text = "Limit Frame Rate"
        Me.checkFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkFrame.UseVisualStyleBackColor = True
        '
        'removeCFG
        '
        Me.removeCFG.Location = New System.Drawing.Point(180, 91)
        Me.removeCFG.Name = "removeCFG"
        Me.removeCFG.Size = New System.Drawing.Size(111, 23)
        Me.removeCFG.TabIndex = 11
        Me.removeCFG.Text = "Uninstall CFG"
        Me.removeCFG.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 211)
        Me.Controls.Add(Me.checkFPS)
        Me.Controls.Add(Me.DetectionNotice)
        Me.Controls.Add(Me.ManualLocate)
        Me.Controls.Add(Me.curSavePath)
        Me.Controls.Add(Me.AutoDetect)
        Me.Name = "Main"
        Me.Text = "BF1 FPS Tweaks Alpha"
        Me.checkFPS.ResumeLayout(False)
        Me.checkFPS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutoDetect As Button
    Friend WithEvents curSavePath As TextBox
    Friend WithEvents ManualLocate As Button
    Friend WithEvents writeOut As Button
    Friend WithEvents DetectionNotice As Label
    Friend WithEvents checkFPS As GroupBox
    Friend WithEvents preFrameDrop As ComboBox
    Friend WithEvents frameRate As TextBox
    Friend WithEvents checkPreFrame As CheckBox
    Friend WithEvents checkFrame As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents removeCFG As Button
End Class
