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
        Me.lbAmt = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.lbTaxRate = New System.Windows.Forms.Label()
        Me.btnTax = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbAmt
        '
        Me.lbAmt.AutoSize = True
        Me.lbAmt.Location = New System.Drawing.Point(44, 54)
        Me.lbAmt.Name = "lbAmt"
        Me.lbAmt.Size = New System.Drawing.Size(29, 12)
        Me.lbAmt.TabIndex = 0
        Me.lbAmt.Text = "금액"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(106, 55)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(136, 21)
        Me.txtAmt.TabIndex = 1
        '
        'lbTaxRate
        '
        Me.lbTaxRate.AutoSize = True
        Me.lbTaxRate.Location = New System.Drawing.Point(113, 94)
        Me.lbTaxRate.Name = "lbTaxRate"
        Me.lbTaxRate.Size = New System.Drawing.Size(101, 12)
        Me.lbTaxRate.TabIndex = 0
        Me.lbTaxRate.Text = "세율 : 0.08 ( 8% )"
        '
        'btnTax
        '
        Me.btnTax.Location = New System.Drawing.Point(106, 155)
        Me.btnTax.Name = "btnTax"
        Me.btnTax.Size = New System.Drawing.Size(95, 31)
        Me.btnTax.TabIndex = 2
        Me.btnTax.Text = "계산"
        Me.btnTax.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnTax)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.lbTaxRate)
        Me.Controls.Add(Me.lbAmt)
        Me.Name = "frmMain"
        Me.Text = "오버로딩된 속성 및 메소드"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbAmt As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents lbTaxRate As System.Windows.Forms.Label
    Friend WithEvents btnTax As System.Windows.Forms.Button

End Class
