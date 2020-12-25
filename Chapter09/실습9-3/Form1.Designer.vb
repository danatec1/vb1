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
        Me.OleDbCon = New System.Data.OleDb.OleDbConnection()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblDb = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtVer = New System.Windows.Forms.TextBox()
        Me.txtDb = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.btnDisCon = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OleDbCon
        '
        Me.OleDbCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\원고\VB2019\VB2019(예제)\실습9-2\회원.ac" &
    "cdb"
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(45, 69)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(132, 15)
        Me.lblVer.TabIndex = 0
        Me.lblVer.Text = "데이터베이스 버전"
        '
        'lblDb
        '
        Me.lblDb.AutoSize = True
        Me.lblDb.Location = New System.Drawing.Point(45, 121)
        Me.lblDb.Name = "lblDb"
        Me.lblDb.Size = New System.Drawing.Size(132, 15)
        Me.lblDb.TabIndex = 0
        Me.lblDb.Text = "현재 데이터베이스"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(45, 174)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(132, 15)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "데이터베이스 버전"
        '
        'txtVer
        '
        Me.txtVer.Location = New System.Drawing.Point(201, 62)
        Me.txtVer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVer.Name = "txtVer"
        Me.txtVer.Size = New System.Drawing.Size(193, 25)
        Me.txtVer.TabIndex = 1
        '
        'txtDb
        '
        Me.txtDb.Location = New System.Drawing.Point(201, 118)
        Me.txtDb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDb.Name = "txtDb"
        Me.txtDb.Size = New System.Drawing.Size(193, 25)
        Me.txtDb.TabIndex = 1
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(201, 170)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(193, 25)
        Me.txtStatus.TabIndex = 1
        '
        'btnCon
        '
        Me.btnCon.Location = New System.Drawing.Point(50, 241)
        Me.btnCon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(86, 40)
        Me.btnCon.TabIndex = 2
        Me.btnCon.Text = "DB 연결"
        Me.btnCon.UseVisualStyleBackColor = True
        '
        'btnDisCon
        '
        Me.btnDisCon.Location = New System.Drawing.Point(173, 241)
        Me.btnDisCon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDisCon.Name = "btnDisCon"
        Me.btnDisCon.Size = New System.Drawing.Size(86, 40)
        Me.btnDisCon.TabIndex = 2
        Me.btnDisCon.Text = "DB 끊기"
        Me.btnDisCon.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(290, 241)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "종 료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 328)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisCon)
        Me.Controls.Add(Me.btnCon)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtDb)
        Me.Controls.Add(Me.txtVer)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDb)
        Me.Controls.Add(Me.lblVer)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "데이터베이스 연결"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OleDbCon As System.Data.OleDb.OleDbConnection
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblDb As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtVer As System.Windows.Forms.TextBox
    Friend WithEvents txtDb As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnCon As System.Windows.Forms.Button
    Friend WithEvents btnDisCon As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
