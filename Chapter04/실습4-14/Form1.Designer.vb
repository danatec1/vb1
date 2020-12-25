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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.clbLeft = New System.Windows.Forms.CheckedListBox()
        Me.clbRight = New System.Windows.Forms.CheckedListBox()
        Me.btnL2r = New System.Windows.Forms.Button()
        Me.btnR2l = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(61, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(190, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "선택 목록간의 항목이동"
        '
        'clbLeft
        '
        Me.clbLeft.FormattingEnabled = True
        Me.clbLeft.Items.AddRange(New Object() {"항목-1", "항목-2", "항목-3"})
        Me.clbLeft.Location = New System.Drawing.Point(12, 62)
        Me.clbLeft.Name = "clbLeft"
        Me.clbLeft.Size = New System.Drawing.Size(122, 148)
        Me.clbLeft.TabIndex = 1
        '
        'clbRight
        '
        Me.clbRight.FormattingEnabled = True
        Me.clbRight.Items.AddRange(New Object() {"선택-1", "선택-2", "선택-3"})
        Me.clbRight.Location = New System.Drawing.Point(198, 62)
        Me.clbRight.Name = "clbRight"
        Me.clbRight.Size = New System.Drawing.Size(122, 148)
        Me.clbRight.TabIndex = 1
        '
        'btnL2r
        '
        Me.btnL2r.Location = New System.Drawing.Point(145, 62)
        Me.btnL2r.Name = "btnL2r"
        Me.btnL2r.Size = New System.Drawing.Size(43, 31)
        Me.btnL2r.TabIndex = 2
        Me.btnL2r.Text = "▶"
        Me.btnL2r.UseVisualStyleBackColor = True
        '
        'btnR2l
        '
        Me.btnR2l.Location = New System.Drawing.Point(145, 121)
        Me.btnR2l.Name = "btnR2l"
        Me.btnR2l.Size = New System.Drawing.Size(43, 31)
        Me.btnR2l.TabIndex = 2
        Me.btnR2l.Text = "◀"
        Me.btnR2l.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 222)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnR2l)
        Me.Controls.Add(Me.btnL2r)
        Me.Controls.Add(Me.clbRight)
        Me.Controls.Add(Me.clbLeft)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "선택목록박스 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents clbLeft As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbRight As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnL2r As System.Windows.Forms.Button
    Friend WithEvents btnR2l As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
