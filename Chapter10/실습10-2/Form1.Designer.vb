﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnRectacle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRectacle
        '
        Me.btnRectacle.Location = New System.Drawing.Point(114, 244)
        Me.btnRectacle.Name = "btnRectacle"
        Me.btnRectacle.Size = New System.Drawing.Size(148, 46)
        Me.btnRectacle.TabIndex = 0
        Me.btnRectacle.Text = "사각형 그리기"
        Me.btnRectacle.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 322)
        Me.Controls.Add(Me.btnRectacle)
        Me.Name = "frmMain"
        Me.Text = "사각형 그리기 연습"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRectacle As System.Windows.Forms.Button

End Class
