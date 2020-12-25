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
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.btnModal = New System.Windows.Forms.Button()
        Me.btnModaless = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("굴림체", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(17, 42)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(275, 27)
        Me.lblTitle1.TabIndex = 0
        Me.lblTitle1.Text = "폼 호출(열기) 방법"
        '
        'btnModal
        '
        Me.btnModal.Location = New System.Drawing.Point(17, 110)
        Me.btnModal.Name = "btnModal"
        Me.btnModal.Size = New System.Drawing.Size(62, 36)
        Me.btnModal.TabIndex = 1
        Me.btnModal.Text = "MODAL"
        Me.btnModal.UseVisualStyleBackColor = True
        '
        'btnModaless
        '
        Me.btnModaless.Location = New System.Drawing.Point(105, 110)
        Me.btnModaless.Name = "btnModaless"
        Me.btnModaless.Size = New System.Drawing.Size(88, 36)
        Me.btnModaless.TabIndex = 1
        Me.btnModaless.Text = "MODALESS"
        Me.btnModaless.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 110)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 36)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "종료(&X)"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 262)
        Me.Controls.Add(Me.btnModaless)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnModal)
        Me.Controls.Add(Me.lblTitle1)
        Me.Name = "frmMain"
        Me.Text = "Form 호출 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents btnModal As System.Windows.Forms.Button
    Friend WithEvents btnModaless As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
