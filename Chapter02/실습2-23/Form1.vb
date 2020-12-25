Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Message, Title, MyValue
        Message = "임의의 값을 입력하시오"
        Title = "InputBox Demo"
        MyValue = InputBox(Message, Title)

        If MyValue = "" Then
            MsgBox("입력된 값이 없습니다!",
                       vbExclamation + vbOKOnly, "오류")
        Else
            MsgBox("입력된 값은 " + MyValue + "입니다!",
                       vbInformation + vbOKOnly, "입력")
        End If
    End Sub
End Class
