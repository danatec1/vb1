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
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.TabCtrlMAIN = New System.Windows.Forms.TabControl()
        Me.TabPg_1 = New System.Windows.Forms.TabPage()
        Me.lbPage1 = New System.Windows.Forms.Label()
        Me.TabPg_2 = New System.Windows.Forms.TabPage()
        Me.lbPAGE2 = New System.Windows.Forms.Label()
        Me.TabCtrlMAIN.SuspendLayout()
        Me.TabPg_1.SuspendLayout()
        Me.TabPg_2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(223, 12)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(62, 33)
        Me.btnEXIT.TabIndex = 5
        Me.btnEXIT.Text = "종료"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'TabCtrlMAIN
        '
        Me.TabCtrlMAIN.Controls.Add(Me.TabPg_1)
        Me.TabCtrlMAIN.Controls.Add(Me.TabPg_2)
        Me.TabCtrlMAIN.Location = New System.Drawing.Point(12, 33)
        Me.TabCtrlMAIN.Name = "TabCtrlMAIN"
        Me.TabCtrlMAIN.SelectedIndex = 0
        Me.TabCtrlMAIN.Size = New System.Drawing.Size(256, 217)
        Me.TabCtrlMAIN.TabIndex = 4
        '
        'TabPg_1
        '
        Me.TabPg_1.Controls.Add(Me.lbPage1)
        Me.TabPg_1.Location = New System.Drawing.Point(4, 22)
        Me.TabPg_1.Name = "TabPg_1"
        Me.TabPg_1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPg_1.Size = New System.Drawing.Size(248, 191)
        Me.TabPg_1.TabIndex = 0
        Me.TabPg_1.Text = "TabPage1_연습"
        Me.TabPg_1.UseVisualStyleBackColor = True
        '
        'lbPage1
        '
        Me.lbPage1.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbPage1.ForeColor = System.Drawing.Color.Blue
        Me.lbPage1.Location = New System.Drawing.Point(24, 50)
        Me.lbPage1.Name = "lbPage1"
        Me.lbPage1.Size = New System.Drawing.Size(198, 66)
        Me.lbPage1.TabIndex = 0
        Me.lbPage1.Text = "탭 페이지-1"
        Me.lbPage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPg_2
        '
        Me.TabPg_2.Controls.Add(Me.lbPAGE2)
        Me.TabPg_2.Location = New System.Drawing.Point(4, 22)
        Me.TabPg_2.Name = "TabPg_2"
        Me.TabPg_2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPg_2.Size = New System.Drawing.Size(248, 191)
        Me.TabPg_2.TabIndex = 1
        Me.TabPg_2.Text = "TabPage2_연습"
        Me.TabPg_2.UseVisualStyleBackColor = True
        '
        'lbPAGE2
        '
        Me.lbPAGE2.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbPAGE2.ForeColor = System.Drawing.Color.Red
        Me.lbPAGE2.Location = New System.Drawing.Point(25, 54)
        Me.lbPAGE2.Name = "lbPAGE2"
        Me.lbPAGE2.Size = New System.Drawing.Size(198, 66)
        Me.lbPAGE2.TabIndex = 1
        Me.lbPAGE2.Text = "탭 페이지-2"
        Me.lbPAGE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 262)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.TabCtrlMAIN)
        Me.Name = "frmMain"
        Me.Text = "TabControl 연습"
        Me.TabCtrlMAIN.ResumeLayout(False)
        Me.TabPg_1.ResumeLayout(False)
        Me.TabPg_2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents TabCtrlMAIN As System.Windows.Forms.TabControl
    Friend WithEvents TabPg_1 As System.Windows.Forms.TabPage
    Friend WithEvents lbPage1 As System.Windows.Forms.Label
    Friend WithEvents TabPg_2 As System.Windows.Forms.TabPage
    Friend WithEvents lbPAGE2 As System.Windows.Forms.Label

End Class
