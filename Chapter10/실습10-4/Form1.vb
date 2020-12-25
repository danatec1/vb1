Public Class frmMain

    Private Sub frmString_Click(sender As Object, _
                 e As EventArgs) Handles frmString.Click
        Dim myGraphics As Graphics = Me.CreateGraphics

        Dim myFont As Font

        Dim myBrush As Brush

        myBrush = New Drawing.SolidBrush(Color.DarkOrchid)

        myFont = New System.Drawing.Font("Verdana", 20, FontStyle.Underline)

        myGraphics.DrawString("Visual Basic 2019", myFont, myBrush, 10, 10)

    End Sub
End Class
