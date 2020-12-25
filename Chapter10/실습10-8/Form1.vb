Public Class frmMain

    Private Sub btnRectacle_Click(sender As Object, _
                        e As EventArgs) Handles btnRectacle.Click
        Dim myPen As Pen
        Dim myBrush As Brush

        myPen = New Pen(Drawing.Color.Blue, 5)
        myBrush = New SolidBrush(Color.Coral)

        Dim myGraphics As Graphics = Me.CreateGraphics
        myPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid
        myGraphics.DrawRectangle(myPen, 10, 10, 100, 50)
        myGraphics.FillRectangle(myBrush, 10, 10, 100, 50)

        myPen.DashStyle = Drawing.Drawing2D.DashStyle.DashDotDot
        myGraphics.DrawRectangle(myPen, 160, 10, 100, 50)
        myGraphics.FillRectangle(myBrush, 160, 10, 100, 50)
    End Sub
End Class
