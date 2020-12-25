Public Class frmMain

    Private Sub btnRectacle_Click(sender As Object, _
                        e As EventArgs) Handles btnRectacle.Click
        Dim myPen As Pen
        myPen = New Pen(Drawing.Color.Red, 5)
        Dim myGraphics As Graphics = Me.CreateGraphics
        myPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
        myGraphics.DrawRectangle(myPen, 10, 10, 100, 50)
        myPen.DashStyle = Drawing.Drawing2D.DashStyle.DashDotDot
        myGraphics.DrawRectangle(myPen, 160, 10, 100, 50)
    End Sub
End Class
