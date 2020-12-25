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
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.txtContents = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblFileContent = New System.Windows.Forms.Label()
        Me.btnFileOpen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnWriteFile.Location = New System.Drawing.Point(131, 164)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(87, 21)
        Me.btnWriteFile.TabIndex = 19
        Me.btnWriteFile.Text = "파일 저장"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'txtContents
        '
        Me.txtContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContents.Location = New System.Drawing.Point(83, 56)
        Me.txtContents.Multiline = True
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(424, 88)
        Me.txtContents.TabIndex = 18
        Me.txtContents.Text = "Where there is a will, there is way." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rome was not built in a day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time and tide" & _
    " wait for no man." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-71, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Contents:"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(83, 12)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(424, 21)
        Me.txtFileName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-71, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "File name:"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(24, 15)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(41, 12)
        Me.lblFilename.TabIndex = 20
        Me.lblFilename.Text = "파일명"
        '
        'lblFileContent
        '
        Me.lblFileContent.AutoSize = True
        Me.lblFileContent.Location = New System.Drawing.Point(24, 59)
        Me.lblFileContent.Name = "lblFileContent"
        Me.lblFileContent.Size = New System.Drawing.Size(53, 12)
        Me.lblFileContent.TabIndex = 20
        Me.lblFileContent.Text = "파일내용"
        '
        'btnFileOpen
        '
        Me.btnFileOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFileOpen.Location = New System.Drawing.Point(249, 164)
        Me.btnFileOpen.Name = "btnFileOpen"
        Me.btnFileOpen.Size = New System.Drawing.Size(87, 21)
        Me.btnFileOpen.TabIndex = 19
        Me.btnFileOpen.Text = "파일 읽기"
        Me.btnFileOpen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(378, 164)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 21)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 208)
        Me.Controls.Add(Me.lblFileContent)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFileOpen)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.txtContents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "FileWrite&FileRead"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWriteFile As System.Windows.Forms.Button
    Friend WithEvents txtContents As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents lblFileContent As System.Windows.Forms.Label
    Friend WithEvents btnFileOpen As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
