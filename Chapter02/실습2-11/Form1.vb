Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        CLang = Val(TextBox1.Text)
        Java = Val(TextBox2.Text)
        Html5 = Val(TextBox3.Text)
        Total = Val(CLang + Java + Html5)
        Label5.Text = Total
    End Sub
End Class
