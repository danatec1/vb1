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
        Me.lblIl = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblWol = New System.Windows.Forms.Label()
        Me.txtWol = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIl
        '
        Me.lblIl.AutoSize = True
        Me.lblIl.Location = New System.Drawing.Point(64, 150)
        Me.lblIl.Name = "lblIl"
        Me.lblIl.Size = New System.Drawing.Size(0, 15)
        Me.lblIl.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(172, 198)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(71, 198)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(61, 38)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "확인"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblWol
        '
        Me.lblWol.AutoSize = True
        Me.lblWol.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblWol.Location = New System.Drawing.Point(233, 93)
        Me.lblWol.Name = "lblWol"
        Me.lblWol.Size = New System.Drawing.Size(35, 24)
        Me.lblWol.TabIndex = 5
        Me.lblWol.Text = "월"
        '
        'txtWol
        '
        Me.txtWol.Location = New System.Drawing.Point(57, 93)
        Me.txtWol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWol.Name = "txtWol"
        Me.txtWol.Size = New System.Drawing.Size(148, 25)
        Me.txtWol.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 328)
        Me.Controls.Add(Me.lblIl)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblWol)
        Me.Controls.Add(Me.txtWol)
        Me.Name = "Form1"
        Me.Text = "월별 날짜"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIl As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lblWol As Label
    Friend WithEvents txtWol As TextBox
End Class
