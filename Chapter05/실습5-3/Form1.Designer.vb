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
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.페이지설정UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.인쇄PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.메모장정보AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.도움말ToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(284, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기NToolStripMenuItem, Me.열기OToolStripMenuItem, Me.저장SToolStripMenuItem, Me.다른이름으로저장AToolStripMenuItem, Me.ToolStripMenuItem1, Me.페이지설정UToolStripMenuItem, Me.인쇄PToolStripMenuItem, Me.ToolStripMenuItem2, Me.끝내기XToolStripMenuItem})
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.파일ToolStripMenuItem.Text = "파일"
        '
        '새로만들기NToolStripMenuItem
        '
        Me.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem"
        Me.새로만들기NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.새로만들기NToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)"
        '
        '열기OToolStripMenuItem
        '
        Me.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem"
        Me.열기OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.열기OToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.열기OToolStripMenuItem.Text = "열기(&O)"
        '
        '저장SToolStripMenuItem
        '
        Me.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem"
        Me.저장SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.저장SToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.저장SToolStripMenuItem.Text = "저장(&S)"
        '
        '다른이름으로저장AToolStripMenuItem
        '
        Me.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem"
        Me.다른이름으로저장AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.다른이름으로저장AToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(&A)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(233, 6)
        '
        '페이지설정UToolStripMenuItem
        '
        Me.페이지설정UToolStripMenuItem.Name = "페이지설정UToolStripMenuItem"
        Me.페이지설정UToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.페이지설정UToolStripMenuItem.Text = "페이지 설정(&U)"
        '
        '인쇄PToolStripMenuItem
        '
        Me.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem"
        Me.인쇄PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.인쇄PToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.인쇄PToolStripMenuItem.Text = "인쇄(&P)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(233, 6)
        '
        '끝내기XToolStripMenuItem
        '
        Me.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem"
        Me.끝내기XToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.끝내기XToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.끝내기XToolStripMenuItem.Text = "끝내기(&X)"
        '
        '도움말ToolStripMenuItem
        '
        Me.도움말ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.메모장정보AToolStripMenuItem})
        Me.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem"
        Me.도움말ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.도움말ToolStripMenuItem.Text = "도움말"
        '
        '메모장정보AToolStripMenuItem
        '
        Me.메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem"
        Me.메모장정보AToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.메모장정보AToolStripMenuItem.Text = "메모장 정보(&A)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 21)
        Me.TextBox1.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "frmMain"
        Me.Text = "메모장"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 새로만들기NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 열기OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 저장SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다른이름으로저장AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 페이지설정UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 인쇄PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 끝내기XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 메모장정보AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
