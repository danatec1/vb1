Public Class frmMain

    Private Sub btnPen_Click(sender As Object, e As EventArgs) Handles btnPen.Click
        Dim myGraphics As Graphics = Me.CreateGraphics

        Dim myPen As Pen

        myPen = New Pen(Brushes.DarkMagenta, 10)
        myGraphics.DrawLine(myPen, 10, 10, 100, 10)

    End Sub
End Class
