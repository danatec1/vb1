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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.rtxtSort = New System.Windows.Forms.RichTextBox()
        Me.pgbarSort = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "종료"
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(128, 271)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(72, 24)
        Me.btnSort.TabIndex = 18
        Me.btnSort.Text = "정렬"
        '
        'rtxtSort
        '
        Me.rtxtSort.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.rtxtSort.Location = New System.Drawing.Point(14, 31)
        Me.rtxtSort.Name = "rtxtSort"
        Me.rtxtSort.Size = New System.Drawing.Size(256, 186)
        Me.rtxtSort.TabIndex = 17
        Me.rtxtSort.Text = ""
        '
        'pgbarSort
        '
        Me.pgbarSort.Location = New System.Drawing.Point(14, 233)
        Me.pgbarSort.Name = "pgbarSort"
        Me.pgbarSort.Size = New System.Drawing.Size(256, 32)
        Me.pgbarSort.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("굴림", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "SORT할 숫자 : 10,9,8,7,6,5,4,3,2,1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.rtxtSort)
        Me.Controls.Add(Me.pgbarSort)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "프로그래스바 연습"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents rtxtSort As System.Windows.Forms.RichTextBox
    Friend WithEvents pgbarSort As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
