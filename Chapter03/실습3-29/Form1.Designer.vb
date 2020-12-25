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
        Me.txtNum23 = New System.Windows.Forms.TextBox()
        Me.txtNum22 = New System.Windows.Forms.TextBox()
        Me.txtNum13 = New System.Windows.Forms.TextBox()
        Me.txtNum21 = New System.Windows.Forms.TextBox()
        Me.txtNum12 = New System.Windows.Forms.TextBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.txtNum11 = New System.Windows.Forms.TextBox()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(267, 243)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 39)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(102, 243)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 39)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "계산"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "+"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "+"
        '
        'txtNum23
        '
        Me.txtNum23.Location = New System.Drawing.Point(314, 169)
        Me.txtNum23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum23.Name = "txtNum23"
        Me.txtNum23.Size = New System.Drawing.Size(109, 25)
        Me.txtNum23.TabIndex = 7
        '
        'txtNum22
        '
        Me.txtNum22.Location = New System.Drawing.Point(174, 169)
        Me.txtNum22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum22.Name = "txtNum22"
        Me.txtNum22.Size = New System.Drawing.Size(109, 25)
        Me.txtNum22.TabIndex = 8
        '
        'txtNum13
        '
        Me.txtNum13.Location = New System.Drawing.Point(314, 78)
        Me.txtNum13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum13.Name = "txtNum13"
        Me.txtNum13.Size = New System.Drawing.Size(109, 25)
        Me.txtNum13.TabIndex = 9
        '
        'txtNum21
        '
        Me.txtNum21.Location = New System.Drawing.Point(26, 169)
        Me.txtNum21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum21.Name = "txtNum21"
        Me.txtNum21.Size = New System.Drawing.Size(109, 25)
        Me.txtNum21.TabIndex = 10
        '
        'txtNum12
        '
        Me.txtNum12.Location = New System.Drawing.Point(174, 78)
        Me.txtNum12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum12.Name = "txtNum12"
        Me.txtNum12.Size = New System.Drawing.Size(109, 25)
        Me.txtNum12.TabIndex = 11
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Location = New System.Drawing.Point(24, 138)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(122, 15)
        Me.lblTitle2.TabIndex = 5
        Me.lblTitle2.Text = "참조에 의한 호출"
        '
        'txtNum11
        '
        Me.txtNum11.Location = New System.Drawing.Point(26, 78)
        Me.txtNum11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum11.Name = "txtNum11"
        Me.txtNum11.Size = New System.Drawing.Size(109, 25)
        Me.txtNum11.TabIndex = 12
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Location = New System.Drawing.Point(24, 46)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(107, 15)
        Me.lblTitle1.TabIndex = 6
        Me.lblTitle1.Text = "값에 의한 호출"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 328)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum23)
        Me.Controls.Add(Me.txtNum22)
        Me.Controls.Add(Me.txtNum13)
        Me.Controls.Add(Me.txtNum21)
        Me.Controls.Add(Me.txtNum12)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.txtNum11)
        Me.Controls.Add(Me.lblTitle1)
        Me.Name = "frmMain"
        Me.Text = "Procedure 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum23 As TextBox
    Friend WithEvents txtNum22 As TextBox
    Friend WithEvents txtNum13 As TextBox
    Friend WithEvents txtNum21 As TextBox
    Friend WithEvents txtNum12 As TextBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents txtNum11 As TextBox
    Friend WithEvents lblTitle1 As Label
End Class
