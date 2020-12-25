<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnFixedSingle = New System.Windows.Forms.Button()
        Me.btnFixed3D = New System.Windows.Forms.Button()
        Me.btnFixedDialog = New System.Windows.Forms.Button()
        Me.btnFixedToolWindow = New System.Windows.Forms.Button()
        Me.btnSizable = New System.Windows.Forms.Button()
        Me.btnSizableToolWindow = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "폼의 테두리 유형 설정"
        '
        'btnNone
        '
        Me.btnNone.Location = New System.Drawing.Point(12, 89)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(90, 31)
        Me.btnNone.TabIndex = 1
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnFixedSingle
        '
        Me.btnFixedSingle.Location = New System.Drawing.Point(118, 89)
        Me.btnFixedSingle.Name = "btnFixedSingle"
        Me.btnFixedSingle.Size = New System.Drawing.Size(114, 31)
        Me.btnFixedSingle.TabIndex = 1
        Me.btnFixedSingle.Text = "FixedSingle"
        Me.btnFixedSingle.UseVisualStyleBackColor = True
        '
        'btnFixed3D
        '
        Me.btnFixed3D.Location = New System.Drawing.Point(248, 89)
        Me.btnFixed3D.Name = "btnFixed3D"
        Me.btnFixed3D.Size = New System.Drawing.Size(90, 31)
        Me.btnFixed3D.TabIndex = 1
        Me.btnFixed3D.Text = "Fixed3D"
        Me.btnFixed3D.UseVisualStyleBackColor = True
        '
        'btnFixedDialog
        '
        Me.btnFixedDialog.Location = New System.Drawing.Point(355, 89)
        Me.btnFixedDialog.Name = "btnFixedDialog"
        Me.btnFixedDialog.Size = New System.Drawing.Size(90, 31)
        Me.btnFixedDialog.TabIndex = 1
        Me.btnFixedDialog.Text = "FixedDialog"
        Me.btnFixedDialog.UseVisualStyleBackColor = True
        '
        'btnFixedToolWindow
        '
        Me.btnFixedToolWindow.Location = New System.Drawing.Point(118, 144)
        Me.btnFixedToolWindow.Name = "btnFixedToolWindow"
        Me.btnFixedToolWindow.Size = New System.Drawing.Size(114, 31)
        Me.btnFixedToolWindow.TabIndex = 1
        Me.btnFixedToolWindow.Text = "FixedToolWindow"
        Me.btnFixedToolWindow.UseVisualStyleBackColor = True
        '
        'btnSizable
        '
        Me.btnSizable.Location = New System.Drawing.Point(12, 144)
        Me.btnSizable.Name = "btnSizable"
        Me.btnSizable.Size = New System.Drawing.Size(90, 31)
        Me.btnSizable.TabIndex = 1
        Me.btnSizable.Text = "Sizable"
        Me.btnSizable.UseVisualStyleBackColor = True
        '
        'btnSizableToolWindow
        '
        Me.btnSizableToolWindow.Location = New System.Drawing.Point(248, 144)
        Me.btnSizableToolWindow.Name = "btnSizableToolWindow"
        Me.btnSizableToolWindow.Size = New System.Drawing.Size(129, 31)
        Me.btnSizableToolWindow.TabIndex = 1
        Me.btnSizableToolWindow.Text = "SizableToolWindow"
        Me.btnSizableToolWindow.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(392, 144)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 222)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSizableToolWindow)
        Me.Controls.Add(Me.btnFixedToolWindow)
        Me.Controls.Add(Me.btnFixed3D)
        Me.Controls.Add(Me.btnFixedDialog)
        Me.Controls.Add(Me.btnSizable)
        Me.Controls.Add(Me.btnFixedSingle)
        Me.Controls.Add(Me.btnNone)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "폼의 테두리 속성"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNone As System.Windows.Forms.Button
    Friend WithEvents btnFixedSingle As System.Windows.Forms.Button
    Friend WithEvents btnFixed3D As System.Windows.Forms.Button
    Friend WithEvents btnFixedDialog As System.Windows.Forms.Button
    Friend WithEvents btnFixedToolWindow As System.Windows.Forms.Button
    Friend WithEvents btnSizable As System.Windows.Forms.Button
    Friend WithEvents btnSizableToolWindow As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
