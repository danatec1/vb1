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
        Me.components = New System.ComponentModel.Container()
        Me.rtxMemo = New System.Windows.Forms.RichTextBox()
        Me.ContextMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.파일FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.페이지설정UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.인쇄PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.메모장정보AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.ContextMnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtxMemo
        '
        Me.rtxMemo.ContextMenuStrip = Me.ContextMnu
        Me.rtxMemo.Location = New System.Drawing.Point(8, 8)
        Me.rtxMemo.Name = "rtxMemo"
        Me.rtxMemo.Size = New System.Drawing.Size(270, 228)
        Me.rtxMemo.TabIndex = 0
        Me.rtxMemo.Text = ""
        '
        'ContextMnu
        '
        Me.ContextMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일FToolStripMenuItem, Me.도움말HToolStripMenuItem})
        Me.ContextMnu.Name = "ContextMnu"
        Me.ContextMnu.Size = New System.Drawing.Size(171, 48)
        '
        '파일FToolStripMenuItem
        '
        Me.파일FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기NToolStripMenuItem, Me.열기OToolStripMenuItem, Me.저장SToolStripMenuItem, Me.다른이름으로저장AToolStripMenuItem, Me.ToolStripMenuItem1, Me.페이지설정UToolStripMenuItem, Me.인쇄PToolStripMenuItem, Me.ToolStripMenuItem2, Me.끝내기XToolStripMenuItem})
        Me.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem"
        Me.파일FToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.파일FToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.파일FToolStripMenuItem.Text = "파일(&F)"
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
        Me.페이지설정UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
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
        '도움말HToolStripMenuItem
        '
        Me.도움말HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.메모장정보AToolStripMenuItem})
        Me.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem"
        Me.도움말HToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.도움말HToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.도움말HToolStripMenuItem.Text = "도움말(&H)"
        '
        '메모장정보AToolStripMenuItem
        '
        Me.메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem"
        Me.메모장정보AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.메모장정보AToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.메모장정보AToolStripMenuItem.Text = "메모장 정보(&A)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblStat
        '
        Me.lblStat.Location = New System.Drawing.Point(0, 243)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(279, 21)
        Me.lblStat.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.rtxMemo)
        Me.Name = "frmMain"
        Me.Text = "컨텍스트 메뉴"
        Me.ContextMnu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxMemo As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMnu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 파일FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 새로만들기NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 열기OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 저장SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다른이름으로저장AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 페이지설정UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 인쇄PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 끝내기XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 메모장정보AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblStat As System.Windows.Forms.Label

End Class
