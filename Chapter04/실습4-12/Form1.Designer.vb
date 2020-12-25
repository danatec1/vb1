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
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.rbtnReTri = New System.Windows.Forms.RadioButton()
        Me.rbtnTri = New System.Windows.Forms.RadioButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.rbtnReTri)
        Me.grpMenu.Controls.Add(Me.rbtnTri)
        Me.grpMenu.Location = New System.Drawing.Point(12, 21)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(249, 53)
        Me.grpMenu.TabIndex = 0
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "정렬과정 및 결과"
        '
        'rbtnReTri
        '
        Me.rbtnReTri.AutoSize = True
        Me.rbtnReTri.Location = New System.Drawing.Point(143, 25)
        Me.rbtnReTri.Name = "rbtnReTri"
        Me.rbtnReTri.Size = New System.Drawing.Size(99, 16)
        Me.rbtnReTri.TabIndex = 0
        Me.rbtnReTri.TabStop = True
        Me.rbtnReTri.Text = "역삼각형 배열"
        Me.rbtnReTri.UseVisualStyleBackColor = True
        '
        'rbtnTri
        '
        Me.rbtnTri.AutoSize = True
        Me.rbtnTri.Location = New System.Drawing.Point(13, 25)
        Me.rbtnTri.Name = "rbtnTri"
        Me.rbtnTri.Size = New System.Drawing.Size(87, 16)
        Me.rbtnTri.TabIndex = 0
        Me.rbtnTri.TabStop = True
        Me.rbtnTri.Text = "삼각형 배열"
        Me.rbtnTri.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(45, 89)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(51, 27)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "정렬"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 27)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(12, 132)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(296, 155)
        Me.lblResult.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 305)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "frmMain"
        Me.Text = "정렬 연습(2차원 배열)"
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnReTri As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTri As System.Windows.Forms.RadioButton
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
