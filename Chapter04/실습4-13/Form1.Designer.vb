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
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.lbxMain = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(35, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(41, 12)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "문자열"
        '
        'txtStr
        '
        Me.txtStr.Location = New System.Drawing.Point(34, 60)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(166, 21)
        Me.txtStr.TabIndex = 1
        '
        'lbxMain
        '
        Me.lbxMain.FormattingEnabled = True
        Me.lbxMain.ItemHeight = 12
        Me.lbxMain.Location = New System.Drawing.Point(34, 102)
        Me.lbxMain.Name = "lbxMain"
        Me.lbxMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxMain.Size = New System.Drawing.Size(165, 124)
        Me.lbxMain.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(218, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 39)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "추가"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(218, 124)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(54, 39)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "선택항목삭제"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 39)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbxMain)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "목록박스 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtStr As System.Windows.Forms.TextBox
    Friend WithEvents lbxMain As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
