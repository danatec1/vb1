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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPolygon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPolygon
        '
        Me.btnPolygon.Location = New System.Drawing.Point(147, 323)
        Me.btnPolygon.Name = "btnPolygon"
        Me.btnPolygon.Size = New System.Drawing.Size(205, 49)
        Me.btnPolygon.TabIndex = 0
        Me.btnPolygon.Text = "다각형 그리기"
        Me.btnPolygon.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 403)
        Me.Controls.Add(Me.btnPolygon)
        Me.Name = "frmMain"
        Me.Text = "다각형 그리기 연습"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPolygon As Button
End Class
