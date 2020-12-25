Public Class frmMain
    '마우스가 버튼 컨트롤에 들어온 경우의 이벤트 처리
    Private Sub btnPrint_MouseEnter(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnPrint.MouseEnter
        btnPrint.ImageIndex = 1 '버튼의 이미지 목록의 인덱스를 1로
    End Sub

    '마우스가 버튼 컨트롤에서 나간 경우의 이벤트 처리
    Private Sub btnPrint_MouseLeave(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnPrint.MouseLeave
        btnPrint.ImageIndex = 0 '버튼의 이미지 목록의 인덱스를 0으로
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles btnPrint.Click
        End
    End Sub
End Class
