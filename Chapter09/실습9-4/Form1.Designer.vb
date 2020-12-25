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
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.OleDbCon = New System.Data.OleDb.OleDbConnection()
        Me.OleDbCmd = New System.Data.OleDb.OleDbCommand()
        Me.SuspendLayout()
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(43, 51)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(67, 15)
        Me.lblRegNo.TabIndex = 0
        Me.lblRegNo.Text = "주민번호"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(43, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "이름"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(43, 124)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(37, 15)
        Me.lblAddr.TabIndex = 0
        Me.lblAddr.Text = "주소"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(43, 164)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 15)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "나이"
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(160, 41)
        Me.txtRegNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(166, 25)
        Me.txtRegNo.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(160, 82)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 25)
        Me.txtName.TabIndex = 1
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(160, 124)
        Me.txtAddr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(166, 25)
        Me.txtAddr.TabIndex = 1
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(160, 160)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(166, 25)
        Me.txtAge.TabIndex = 1
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(61, 229)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(265, 35)
        Me.btnInput.TabIndex = 2
        Me.btnInput.Text = "데이터베이스 등록"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'OleDbCon
        '
        Me.OleDbCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\원고\VB2019\VB2019(예제)\실습9-2\회원.ac" &
    "cdb"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 328)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRegNo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "데이터 등록"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtRegNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents OleDbCon As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbCmd As System.Data.OleDb.OleDbCommand

End Class
