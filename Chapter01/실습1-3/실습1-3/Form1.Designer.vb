<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdInput = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(29, 110)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(355, 25)
        Me.txtOutput.TabIndex = 11
        '
        'cmdInput
        '
        Me.cmdInput.Location = New System.Drawing.Point(352, 50)
        Me.cmdInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdInput.Name = "cmdInput"
        Me.cmdInput.Size = New System.Drawing.Size(56, 28)
        Me.cmdInput.TabIndex = 10
        Me.cmdInput.Text = "입 력"
        Me.cmdInput.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(174, 52)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(146, 25)
        Me.txtInput.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "이름을 입력하세요!!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 186)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.cmdInput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "안녕하세요"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents cmdInput As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
End Class
