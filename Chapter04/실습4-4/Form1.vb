Public Class frmMain
    Dim newForm2 As New Form2

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) _
               Handles btnNormal.Click
        newForm2.WindowState = FormWindowState.Normal
        newForm2.Text = "Normal"
        newForm2.Show()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) _
                Handles btnMinimized.Click
        newForm2.WindowState = FormWindowState.Minimized
        newForm2.Text = "Minimized"
        newForm2.Show()
    End Sub

    Private Sub btnMaximized_Click(sender As Object, e As EventArgs) _
                 Handles btnMaximized.Click
        newForm2.WindowState = FormWindowState.Maximized
        newForm2.Text = "Maximized"
        newForm2.Show()
    End Sub
End Class
