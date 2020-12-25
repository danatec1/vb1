Public Class Form1
    Private Sub cmdInput_Click(sender As Object, e As EventArgs) Handles cmdInput.Click
        Dim strHello As String  '스트링형으로  strHello 라는 변수를 선언
        strHello = "안녕하세요? " + txtInput.Text + "님"
        txtOutput.Text = strHello
    End Sub
End Class
