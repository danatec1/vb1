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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtStr3 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtStr2 = New System.Windows.Forms.TextBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.txtStr1 = New System.Windows.Forms.TextBox()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 243)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 39)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(104, 243)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 39)
        Me.btnOk.TabIndex = 32
        Me.btnOk.Text = "붙이기"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "+"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "+"
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(316, 170)
        Me.txtNum3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(109, 25)
        Me.txtNum3.TabIndex = 21
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(176, 170)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(109, 25)
        Me.txtNum2.TabIndex = 22
        '
        'txtStr3
        '
        Me.txtStr3.Location = New System.Drawing.Point(316, 79)
        Me.txtStr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStr3.Name = "txtStr3"
        Me.txtStr3.Size = New System.Drawing.Size(109, 25)
        Me.txtStr3.TabIndex = 23
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(28, 170)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(109, 25)
        Me.txtNum1.TabIndex = 24
        '
        'txtStr2
        '
        Me.txtStr2.Location = New System.Drawing.Point(176, 79)
        Me.txtStr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStr2.Name = "txtStr2"
        Me.txtStr2.Size = New System.Drawing.Size(109, 25)
        Me.txtStr2.TabIndex = 25
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Location = New System.Drawing.Point(26, 139)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(92, 15)
        Me.lblTitle2.TabIndex = 19
        Me.lblTitle2.Text = "두 수 더하기"
        '
        'txtStr1
        '
        Me.txtStr1.Location = New System.Drawing.Point(28, 79)
        Me.txtStr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStr1.Name = "txtStr1"
        Me.txtStr1.Size = New System.Drawing.Size(109, 25)
        Me.txtStr1.TabIndex = 26
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Location = New System.Drawing.Point(26, 47)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(102, 15)
        Me.lblTitle1.TabIndex = 20
        Me.lblTitle1.Text = "문자로 붙이기"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 328)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtStr3)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtStr2)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.txtStr1)
        Me.Controls.Add(Me.lblTitle1)
        Me.Name = "frmMain"
        Me.Text = "Function 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum3 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtStr3 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtStr2 As TextBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents txtStr1 As TextBox
    Friend WithEvents lblTitle1 As Label
End Class
