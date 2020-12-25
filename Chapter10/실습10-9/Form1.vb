﻿Public Class frmMain

    Private Sub btnEllipse_Click(sender As Object, _
                        e As EventArgs) Handles btnEllipse.Click
        Dim myPen As Pen
        myPen = New Pen(Drawing.Color.Blue, 5)

        Dim myBrush As Brush
        myBrush = New SolidBrush(Color.Coral)


        Dim myGraphics As Graphics = Me.CreateGraphics

        Dim myRectangle As New Rectangle
        myRectangle.X = 10
        myRectangle.Y = 10

        myRectangle.Width = 200
        myRectangle.Height = 100

        myGraphics.DrawEllipse(myPen, myRectangle)
        myGraphics.FillEllipse(myBrush, myRectangle)

        myGraphics.DrawEllipse(myPen, 10, 150, 100, 100)
        myGraphics.FillEllipse(myBrush, 10, 150, 100, 100)
    End Sub
End Class
