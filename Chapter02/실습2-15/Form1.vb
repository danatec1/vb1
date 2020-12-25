Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) _
        Handles Me.Click
        Static intValue As Integer
        intValue = intValue + 1 '변수의 연산
        MessageBox.Show("intValue 값은 " & intValue)
    End Sub
End Class
