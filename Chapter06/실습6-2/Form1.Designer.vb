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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnApnd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExit.Location = New System.Drawing.Point(197, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 32)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "종료"
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDel.Location = New System.Drawing.Point(197, 165)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(136, 32)
        Me.btnDel.TabIndex = 22
        Me.btnDel.Text = "선택노드삭제"
        '
        'btnApnd
        '
        Me.btnApnd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApnd.Location = New System.Drawing.Point(197, 117)
        Me.btnApnd.Name = "btnApnd"
        Me.btnApnd.Size = New System.Drawing.Size(136, 32)
        Me.btnApnd.TabIndex = 21
        Me.btnApnd.Text = "자식추가"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(197, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 32)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "노드추가"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(197, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(136, 21)
        Me.txtName.TabIndex = 19
        '
        'trvMain
        '
        Me.trvMain.Location = New System.Drawing.Point(13, 21)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.Size = New System.Drawing.Size(168, 296)
        Me.trvMain.TabIndex = 18
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 343)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnApnd)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.trvMain)
        Me.Name = "frmMain"
        Me.Text = "TreeView 연습"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnApnd As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents trvMain As System.Windows.Forms.TreeView

End Class
