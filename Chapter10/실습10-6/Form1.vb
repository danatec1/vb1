Public Class frmMain

    Private Sub btnPolygon_Click(sender As Object,
                e As EventArgs) Handles btnPolygon.Click

        Dim myPen1 As Pen

        Dim A1 As New Point(10, 10)
        Dim B1 As New Point(100, 50)
        Dim C1 As New Point(60, 150)

        Dim myPoints1 As Point() = {A1, B1, C1}
        myPen1 = New Pen(Drawing.Color.Blue, 5)

        Dim myGraphics1 As Graphics = Me.CreateGraphics
        myGraphics1.DrawPolygon(myPen1, myPoints1)

        Dim myPen2 As Pen

        Dim A2 As New Point(10, 180)
        Dim B2 As New Point(100, 150)
        Dim C2 As New Point(120, 210)
        Dim D2 As New Point(60, 200)

        Dim myPoints2 As Point() = {A2, B2, C2, D2}

        myPen2 = New Pen(Drawing.Color.Red, 5)

        Dim myGraphics2 As Graphics = Me.CreateGraphics
        myGraphics2.DrawPolygon(myPen2, myPoints2)


    End Sub
End Class
