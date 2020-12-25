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
        Me.lbDt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCustom = New System.Windows.Forms.RadioButton()
        Me.rbtnSHORT = New System.Windows.Forms.RadioButton()
        Me.rbtnLONG = New System.Windows.Forms.RadioButton()
        Me.DTPkrMain = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 32)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "종료"
        '
        'lbDt
        '
        Me.lbDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDt.Location = New System.Drawing.Point(10, 119)
        Me.lbDt.Name = "lbDt"
        Me.lbDt.Size = New System.Drawing.Size(264, 64)
        Me.lbDt.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnCustom)
        Me.GroupBox1.Controls.Add(Me.rbtnSHORT)
        Me.GroupBox1.Controls.Add(Me.rbtnLONG)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 48)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'rbtnCustom
        '
        Me.rbtnCustom.Location = New System.Drawing.Point(168, 16)
        Me.rbtnCustom.Name = "rbtnCustom"
        Me.rbtnCustom.Size = New System.Drawing.Size(72, 24)
        Me.rbtnCustom.TabIndex = 2
        Me.rbtnCustom.Text = "Custom"
        '
        'rbtnSHORT
        '
        Me.rbtnSHORT.Location = New System.Drawing.Point(88, 16)
        Me.rbtnSHORT.Name = "rbtnSHORT"
        Me.rbtnSHORT.Size = New System.Drawing.Size(64, 24)
        Me.rbtnSHORT.TabIndex = 1
        Me.rbtnSHORT.Text = "Short"
        '
        'rbtnLONG
        '
        Me.rbtnLONG.Checked = True
        Me.rbtnLONG.Location = New System.Drawing.Point(8, 16)
        Me.rbtnLONG.Name = "rbtnLONG"
        Me.rbtnLONG.Size = New System.Drawing.Size(64, 24)
        Me.rbtnLONG.TabIndex = 0
        Me.rbtnLONG.TabStop = True
        Me.rbtnLONG.Text = "Long"
        '
        'DTPkrMain
        '
        Me.DTPkrMain.Location = New System.Drawing.Point(10, 31)
        Me.DTPkrMain.Name = "DTPkrMain"
        Me.DTPkrMain.Size = New System.Drawing.Size(264, 21)
        Me.DTPkrMain.TabIndex = 12
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lbDt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DTPkrMain)
        Me.Name = "frmMain"
        Me.Text = "DateTimePicker 연습"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbDt As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCustom As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSHORT As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnLONG As System.Windows.Forms.RadioButton
    Friend WithEvents DTPkrMain As System.Windows.Forms.DateTimePicker

End Class
