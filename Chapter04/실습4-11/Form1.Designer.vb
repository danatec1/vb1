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
        Me.rbfBlue = New System.Windows.Forms.RadioButton()
        Me.rbfRed = New System.Windows.Forms.RadioButton()
        Me.rbfGreen = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.rbbBlue = New System.Windows.Forms.RadioButton()
        Me.rbbRed = New System.Windows.Forms.RadioButton()
        Me.rbbGreen = New System.Windows.Forms.RadioButton()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxFont.SuspendLayout()
        Me.pnlBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxFont
        '
        Me.grpBoxFont.Controls.Add(Me.rbfGreen)
        Me.grpBoxFont.Controls.Add(Me.rbfRed)
        Me.grpBoxFont.Controls.Add(Me.rbfBlue)
        Me.grpBoxFont.Location = New System.Drawing.Point(39, 33)
        Me.grpBoxFont.Name = "grpBoxFont"
        Me.grpBoxFont.Size = New System.Drawing.Size(146, 145)
        Me.grpBoxFont.TabIndex = 0
        Me.grpBoxFont.TabStop = False
        Me.grpBoxFont.Text = "[글꼴 색상]"
        '
        'rbfBlue
        '
        Me.rbfBlue.AutoSize = True
        Me.rbfBlue.Location = New System.Drawing.Point(17, 30)
        Me.rbfBlue.Name = "rbfBlue"
        Me.rbfBlue.Size = New System.Drawing.Size(71, 16)
        Me.rbfBlue.TabIndex = 0
        Me.rbfBlue.TabStop = True
        Me.rbfBlue.Text = "[파란색]"
        Me.rbfBlue.UseVisualStyleBackColor = True
        '
        'rbfRed
        '
        Me.rbfRed.AutoSize = True
        Me.rbfRed.Location = New System.Drawing.Point(17, 61)
        Me.rbfRed.Name = "rbfRed"
        Me.rbfRed.Size = New System.Drawing.Size(71, 16)
        Me.rbfRed.TabIndex = 0
        Me.rbfRed.TabStop = True
        Me.rbfRed.Text = "[빨간색]"
        Me.rbfRed.UseVisualStyleBackColor = True
        '
        'rbfGreen
        '
        Me.rbfGreen.AutoSize = True
        Me.rbfGreen.Location = New System.Drawing.Point(17, 93)
        Me.rbfGreen.Name = "rbfGreen"
        Me.rbfGreen.Size = New System.Drawing.Size(67, 16)
        Me.rbfGreen.TabIndex = 0
        Me.rbfGreen.TabStop = True
        Me.rbfGreen.Text = "[녹  색]"
        Me.rbfGreen.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(262, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 14)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "(배경 색상)"
        '
        'pnlBack
        '
        Me.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBack.Controls.Add(Me.rbbGreen)
        Me.pnlBack.Controls.Add(Me.rbbRed)
        Me.pnlBack.Controls.Add(Me.rbbBlue)
        Me.pnlBack.Location = New System.Drawing.Point(262, 46)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(126, 131)
        Me.pnlBack.TabIndex = 2
        '
        'rbbBlue
        '
        Me.rbbBlue.AutoSize = True
        Me.rbbBlue.Location = New System.Drawing.Point(21, 16)
        Me.rbbBlue.Name = "rbbBlue"
        Me.rbbBlue.Size = New System.Drawing.Size(69, 16)
        Me.rbbBlue.TabIndex = 0
        Me.rbbBlue.TabStop = True
        Me.rbbBlue.Text = "(파란색)"
        Me.rbbBlue.UseVisualStyleBackColor = True
        '
        'rbbRed
        '
        Me.rbbRed.AutoSize = True
        Me.rbbRed.Location = New System.Drawing.Point(21, 47)
        Me.rbbRed.Name = "rbbRed"
        Me.rbbRed.Size = New System.Drawing.Size(69, 16)
        Me.rbbRed.TabIndex = 0
        Me.rbbRed.TabStop = True
        Me.rbbRed.Text = "(빨간색)"
        Me.rbbRed.UseVisualStyleBackColor = True
        '
        'rbbGreen
        '
        Me.rbbGreen.AutoSize = True
        Me.rbbGreen.Location = New System.Drawing.Point(21, 79)
        Me.rbbGreen.Name = "rbbGreen"
        Me.rbbGreen.Size = New System.Drawing.Size(65, 16)
        Me.rbbGreen.TabIndex = 0
        Me.rbbGreen.TabStop = True
        Me.rbbGreen.Text = "(녹  색)"
        Me.rbbGreen.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblText.Location = New System.Drawing.Point(50, 197)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(338, 107)
        Me.lblText.TabIndex = 3
        Me.lblText.Text = "라디오 버튼 연습"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "종 료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 377)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.pnlBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpBoxFont)
        Me.Name = "frmMain"
        Me.Text = "라디오버튼 연습"
        Me.grpBoxFont.ResumeLayout(False)
        Me.grpBoxFont.PerformLayout()
        Me.pnlBack.ResumeLayout(False)
        Me.pnlBack.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBoxFont As System.Windows.Forms.GroupBox
    Friend WithEvents rbfGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbfRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbfBlue As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBack As System.Windows.Forms.Panel
    Friend WithEvents rbbGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbbRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbbBlue As System.Windows.Forms.RadioButton
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
