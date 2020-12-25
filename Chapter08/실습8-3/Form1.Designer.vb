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
        Me.btnFileRead = New System.Windows.Forms.Button()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(237, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "종 료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFileRead
        '
        Me.btnFileRead.Location = New System.Drawing.Point(237, 96)
        Me.btnFileRead.Name = "btnFileRead"
        Me.btnFileRead.Size = New System.Drawing.Size(87, 34)
        Me.btnFileRead.TabIndex = 4
        Me.btnFileRead.Text = "파일 읽기"
        Me.btnFileRead.UseVisualStyleBackColor = True
        '
        'btnFileSave
        '
        Me.btnFileSave.Location = New System.Drawing.Point(237, 39)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(87, 34)
        Me.btnFileSave.TabIndex = 5
        Me.btnFileSave.Text = "파일 저장"
        Me.btnFileSave.UseVisualStyleBackColor = True
        '
        'lstAnimals
        '
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.ItemHeight = 12
        Me.lstAnimals.Location = New System.Drawing.Point(-7, 3)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(222, 256)
        Me.lstAnimals.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFileRead)
        Me.Controls.Add(Me.btnFileSave)
        Me.Controls.Add(Me.lstAnimals)
        Me.Name = "frmMain"
        Me.Text = "StreamReaderWriter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFileRead As System.Windows.Forms.Button
    Friend WithEvents btnFileSave As System.Windows.Forms.Button
    Friend WithEvents lstAnimals As System.Windows.Forms.ListBox

End Class
