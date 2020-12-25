Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
         Handles MyBase.Load
        Dim intValue As Integer '변수의 선언
        intValue = 27          '변수의 할당
        intValue = intValue + 1 '변수의 연산
        MessageBox.Show("intValue 값은 " & intValue)
    End Sub
End Class
