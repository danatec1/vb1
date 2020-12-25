Public Class frmMain

    Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim G As Graphics
        G = Me.CreateGraphics
        G.FillRectangle(New SolidBrush(Color.Yellow), ClientRectangle)
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim txtFont As New Font("Verdana", 36, FontStyle.Bold)
        G.DrawLine(New Pen(Color.Green), CInt(Me.Width / 2),
              CInt(0), CInt(Me.Width / 2), CInt(Me.Height))
        G.DrawLine(New Pen(Color.Green), 0, CInt(Me.Height / 2),
              CInt(Me.Width), CInt(Me.Height / 2))
        Dim str As String = "Visual Basic 2019"
        Dim txtSize As SizeF
        txtSize = G.MeasureString(str, txtFont)
        Dim txtX, txtY As Integer
        txtX = (Me.Width - txtSize.Width) / 2
        txtY = (Me.Height - txtSize.Height) / 2
        G.DrawString(str, txtFont, New SolidBrush(Color.Red), txtX, txtY)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
