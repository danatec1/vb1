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
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtOdd = New System.Windows.Forms.TextBox()
        Me.txtEven = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblOdd = New System.Windows.Forms.Label()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 258)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 38)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(76, 258)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(87, 38)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "실행"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(211, 202)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(114, 25)
        Me.txtResult.TabIndex = 10
        '
        'txtOdd
        '
        Me.txtOdd.Location = New System.Drawing.Point(211, 150)
        Me.txtOdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOdd.Name = "txtOdd"
        Me.txtOdd.Size = New System.Drawing.Size(114, 25)
        Me.txtOdd.TabIndex = 11
        '
        'txtEven
        '
        Me.txtEven.Location = New System.Drawing.Point(211, 99)
        Me.txtEven.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEven.Name = "txtEven"
        Me.txtEven.Size = New System.Drawing.Size(114, 25)
        Me.txtEven.TabIndex = 12
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("굴림", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblResult.Location = New System.Drawing.Point(65, 202)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(138, 27)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "결       과"
        '
        'lblOdd
        '
        Me.lblOdd.AutoSize = True
        Me.lblOdd.Font = New System.Drawing.Font("굴림", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblOdd.Location = New System.Drawing.Point(65, 150)
        Me.lblOdd.Name = "lblOdd"
        Me.lblOdd.Size = New System.Drawing.Size(134, 27)
        Me.lblOdd.TabIndex = 8
        Me.lblOdd.Text = "홀수의 합"
        '
        'lblEven
        '
        Me.lblEven.AutoSize = True
        Me.lblEven.Font = New System.Drawing.Font("굴림", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblEven.Location = New System.Drawing.Point(67, 98)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(134, 27)
        Me.lblEven.TabIndex = 7
        Me.lblEven.Text = "짝수의 합"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("굴림", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(65, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(314, 34)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "1~100까지의 숫자"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 328)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtOdd)
        Me.Controls.Add(Me.txtEven)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblOdd)
        Me.Controls.Add(Me.lblEven)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "1~100까지의 짝수와 홀수의 차이"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtOdd As TextBox
    Friend WithEvents txtEven As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblOdd As Label
    Friend WithEvents lblEven As Label
    Friend WithEvents lblTitle As Label
End Class
