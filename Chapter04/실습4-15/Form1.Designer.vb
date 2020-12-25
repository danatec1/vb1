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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cbList = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblName.Location = New System.Drawing.Point(31, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "성명"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAge.Location = New System.Drawing.Point(154, 36)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(42, 16)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "나이"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(38, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(95, 21)
        Me.txtName.TabIndex = 1
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(157, 70)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(39, 21)
        Me.txtAge.TabIndex = 1
        '
        'cbList
        '
        Me.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbList.FormattingEnabled = True
        Me.cbList.Location = New System.Drawing.Point(42, 116)
        Me.cbList.Name = "cbList"
        Me.cbList.Size = New System.Drawing.Size(153, 20)
        Me.cbList.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(217, 70)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(43, 33)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "등록"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(217, 116)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(43, 33)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "삭제"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 165)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 231)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbList)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMain"
        Me.Text = "콤보박스 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cbList As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
