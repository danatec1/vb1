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
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.btnLabel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(59, 41)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(41, 12)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "lblOne"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(59, 74)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(43, 12)
        Me.lblTwo.TabIndex = 0
        Me.lblTwo.Text = "lblTwo"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(59, 110)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(51, 12)
        Me.lblThree.TabIndex = 0
        Me.lblThree.Text = "lblThree"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Font = New System.Drawing.Font("굴림", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblFour.Location = New System.Drawing.Point(59, 147)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(68, 19)
        Me.lblFour.TabIndex = 0
        Me.lblFour.Text = "lblFour"
        '
        'btnLabel
        '
        Me.btnLabel.Location = New System.Drawing.Point(149, 200)
        Me.btnLabel.Name = "btnLabel"
        Me.btnLabel.Size = New System.Drawing.Size(125, 38)
        Me.btnLabel.TabIndex = 1
        Me.btnLabel.Text = "Label 변환"
        Me.btnLabel.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 262)
        Me.Controls.Add(Me.btnLabel)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Name = "frmMain"
        Me.Text = "실습4-5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents btnLabel As System.Windows.Forms.Button

End Class
