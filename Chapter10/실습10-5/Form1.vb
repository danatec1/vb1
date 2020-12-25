Public Class frmMain

    Private Sub btnString_Click(sender As Object, _
                         e As EventArgs) Handles btnString.Click
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myFont As Font
        Dim myBrush As Brush
        Dim userMsg As String

        userMsg = InputBox("문자열을 입력하세요?", "문자열 입력!!", _
                           "여기에 문자열을 입력하세요", 100, 200)

        myBrush = New Drawing.SolidBrush(Color.DarkOrchid)
        myFont = New System.Drawing.Font("Verdana", 20, FontStyle.Underline)

        myGraphics.DrawString(userMsg, myFont, myBrush, 10, 10)
    End Sub
End Class
