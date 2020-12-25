<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.txtJava = New System.Windows.Forms.TextBox()
        Me.txtXml = New System.Windows.Forms.TextBox()
        Me.txtVb2015 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblJava = New System.Windows.Forms.Label()
        Me.lblXml = New System.Windows.Forms.Label()
        Me.lblVb2015 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(223, 239)
        Me.txtAvg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(63, 25)
        Me.txtAvg.TabIndex = 15
        '
        'txtTot
        '
        Me.txtTot.Location = New System.Drawing.Point(223, 195)
        Me.txtTot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(63, 25)
        Me.txtTot.TabIndex = 16
        '
        'txtJava
        '
        Me.txtJava.Location = New System.Drawing.Point(223, 149)
        Me.txtJava.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJava.Name = "txtJava"
        Me.txtJava.Size = New System.Drawing.Size(63, 25)
        Me.txtJava.TabIndex = 17
        '
        'txtXml
        '
        Me.txtXml.Location = New System.Drawing.Point(223, 106)
        Me.txtXml.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtXml.Name = "txtXml"
        Me.txtXml.Size = New System.Drawing.Size(63, 25)
        Me.txtXml.TabIndex = 18
        '
        'txtVb2015
        '
        Me.txtVb2015.Location = New System.Drawing.Point(223, 55)
        Me.txtVb2015.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVb2015.Name = "txtVb2015"
        Me.txtVb2015.Size = New System.Drawing.Size(63, 25)
        Me.txtVb2015.TabIndex = 19
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(223, 304)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 32)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "종 료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(65, 299)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(65, 38)
        Me.btnOk.TabIndex = 13
        Me.btnOk.Text = "확 인"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(63, 250)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(42, 15)
        Me.lblAvg.TabIndex = 12
        Me.lblAvg.Text = "평 균"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(63, 199)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(42, 15)
        Me.lblTot.TabIndex = 11
        Me.lblTot.Text = "합 계"
        '
        'lblJava
        '
        Me.lblJava.AutoSize = True
        Me.lblJava.Location = New System.Drawing.Point(61, 153)
        Me.lblJava.Name = "lblJava"
        Me.lblJava.Size = New System.Drawing.Size(39, 15)
        Me.lblJava.TabIndex = 10
        Me.lblJava.Text = "JAVA"
        '
        'lblXml
        '
        Me.lblXml.AutoSize = True
        Me.lblXml.Location = New System.Drawing.Point(61, 110)
        Me.lblXml.Name = "lblXml"
        Me.lblXml.Size = New System.Drawing.Size(36, 15)
        Me.lblXml.TabIndex = 9
        Me.lblXml.Text = "XML"
        '
        'lblVb2015
        '
        Me.lblVb2015.AutoSize = True
        Me.lblVb2015.Location = New System.Drawing.Point(61, 59)
        Me.lblVb2015.Name = "lblVb2015"
        Me.lblVb2015.Size = New System.Drawing.Size(134, 15)
        Me.lblVb2015.TabIndex = 8
        Me.lblVb2015.Text = "비주얼베이직 2019"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 392)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.txtJava)
        Me.Controls.Add(Me.txtXml)
        Me.Controls.Add(Me.txtVb2015)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblJava)
        Me.Controls.Add(Me.lblXml)
        Me.Controls.Add(Me.lblVb2015)
        Me.Name = "Form1"
        Me.Text = "성적 프로그램"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAvg As TextBox
    Friend WithEvents txtTot As TextBox
    Friend WithEvents txtJava As TextBox
    Friend WithEvents txtXml As TextBox
    Friend WithEvents txtVb2015 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents lblJava As Label
    Friend WithEvents lblXml As Label
    Friend WithEvents lblVb2015 As Label
End Class
