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
        Me.frmString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'frmString
        '
        Me.frmString.Location = New System.Drawing.Point(101, 262)
        Me.frmString.Name = "frmString"
        Me.frmString.Size = New System.Drawing.Size(170, 48)
        Me.frmString.TabIndex = 0
        Me.frmString.Text = "문자열 그리기"
        Me.frmString.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 344)
        Me.Controls.Add(Me.frmString)
        Me.Name = "frmMain"
        Me.Text = "문자열 그리기 연습"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmString As System.Windows.Forms.Button

End Class
