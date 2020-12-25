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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.rchNotes = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUndo, Me.btnRedo, Me.btnRed, Me.btnBlue})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnUndo
        '
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(48, 20)
        Me.btnUndo.Text = "Undo"
        '
        'btnRedo
        '
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(46, 20)
        Me.btnRedo.Text = "Redo"
        '
        'btnRed
        '
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(43, 20)
        Me.btnRed.Text = "빨강"
        '
        'btnBlue
        '
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(43, 20)
        Me.btnBlue.Text = "파랑"
        '
        'rchNotes
        '
        Me.rchNotes.Location = New System.Drawing.Point(12, 27)
        Me.rchNotes.Name = "rchNotes"
        Me.rchNotes.Size = New System.Drawing.Size(409, 212)
        Me.rchNotes.TabIndex = 1
        Me.rchNotes.Text = "이 영역은 RichTextBox의 실습 영역입니다"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 262)
        Me.Controls.Add(Me.rchNotes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "RichTextBox 연습"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rchNotes As System.Windows.Forms.RichTextBox

End Class
