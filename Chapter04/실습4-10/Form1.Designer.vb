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
        Me.grpBoxFont = New System.Windows.Forms.GroupBox()
        Me.chkStr1 = New System.Windows.Forms.CheckBox()
        Me.chkStr2 = New System.Windows.Forms.CheckBox()
        Me.chkStr3 = New System.Windows.Forms.CheckBox()
        Me.lblSample = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxFont.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxFont
        '
        Me.grpBoxFont.Controls.Add(Me.chkStr3)
        Me.grpBoxFont.Controls.Add(Me.chkStr2)
        Me.grpBoxFont.Controls.Add(Me.chkStr1)
        Me.grpBoxFont.Location = New System.Drawing.Point(14, 59)
        Me.grpBoxFont.Name = "grpBoxFont"
        Me.grpBoxFont.Size = New System.Drawing.Size(131, 127)
        Me.grpBoxFont.TabIndex = 0
        Me.grpBoxFont.TabStop = False
        Me.grpBoxFont.Text = "[단어]"
        '
        'chkStr1
        '
        Me.chkStr1.AutoSize = True
        Me.chkStr1.Location = New System.Drawing.Point(30, 20)
        Me.chkStr1.Name = "chkStr1"
        Me.chkStr1.Size = New System.Drawing.Size(72, 16)
        Me.chkStr1.TabIndex = 0
        Me.chkStr1.Text = "우리나라"
        Me.chkStr1.UseVisualStyleBackColor = True
        '
        'chkStr2
        '
        Me.chkStr2.AutoSize = True
        Me.chkStr2.Location = New System.Drawing.Point(30, 51)
        Me.chkStr2.Name = "chkStr2"
        Me.chkStr2.Size = New System.Drawing.Size(72, 16)
        Me.chkStr2.TabIndex = 0
        Me.chkStr2.Text = "대한민국"
        Me.chkStr2.UseVisualStyleBackColor = True
        '
        'chkStr3
        '
        Me.chkStr3.AutoSize = True
        Me.chkStr3.Location = New System.Drawing.Point(30, 82)
        Me.chkStr3.Name = "chkStr3"
        Me.chkStr3.Size = New System.Drawing.Size(96, 16)
        Me.chkStr3.TabIndex = 0
        Me.chkStr3.Text = "아름다운나라"
        Me.chkStr3.UseVisualStyleBackColor = True
        '
        'lblSample
        '
        Me.lblSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSample.Location = New System.Drawing.Point(151, 62)
        Me.lblSample.Name = "lblSample"
        Me.lblSample.Size = New System.Drawing.Size(123, 123)
        Me.lblSample.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(102, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "종 료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSample)
        Me.Controls.Add(Me.grpBoxFont)
        Me.Name = "frmMain"
        Me.Text = "체크박스 연습"
        Me.grpBoxFont.ResumeLayout(False)
        Me.grpBoxFont.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxFont As System.Windows.Forms.GroupBox
    Friend WithEvents chkStr3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStr2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStr1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblSample As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
