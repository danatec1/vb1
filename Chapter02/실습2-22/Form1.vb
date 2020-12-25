Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim msg As String
        msg = MsgBox("빨간색을 선택하였습니까?", vbYesNo, "질문")
        If msg = vbYes Then
            MsgBox("빨간색을 선택하였습니다", , "답변")
        Else
            MsgBox("파란색을 선택하였습니다", , "답변")
        End If
    End Sub
End Class
