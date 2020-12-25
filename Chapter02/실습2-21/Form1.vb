Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg, button, title As String
        msg = "MsgBox의 기호 상수를 나타냅니다." &
                Chr(10) & "줄이 바뀌었습니다."
        button = vbYesNoCancel + vbInformation
        title = "MsgBox 함수"
        MsgBox(msg, button, title)
    End Sub
End Class
