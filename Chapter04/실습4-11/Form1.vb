Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
           Handles btnExit.Click
        End
    End Sub
    '글꼴 색상에서 파란색 라디오 버튼 선택 시 이벤트
    Private Sub rbfBlue_CheckedChanged(ByVal sender As  _
                System.Object, ByVal e As System.EventArgs) Handles _
                rbfBlue.CheckedChanged
        lblText.ForeColor = Color.Blue
    End Sub

    '글꼴 색상에서 빨간색 라디오 버튼 선택 시 이벤트
    Private Sub rbfRed_CheckedChanged(ByVal sender As  _
                System.Object, ByVal e As System.EventArgs) Handles _
                 rbfRed.CheckedChanged
        lblText.ForeColor = Color.Red
    End Sub

    '글꼴 색상에서 녹색 라디오 버튼 선택 시 이벤트
    Private Sub rbfGreen_CheckedChanged(ByVal sender As  _
            System.Object, ByVal e As System.EventArgs) Handles _
            rbfGreen.CheckedChanged
        lblText.ForeColor = Color.Green
    End Sub
    '배경 색상에서 파란색 라디오 버튼 선택 시 이벤트
    Private Sub rbbBlue_CheckedChanged(ByVal sender As  _
            System.Object, ByVal e As System.EventArgs) Handles _
            rbbBlue.CheckedChanged
        lblText.BackColor = Color.Blue
    End Sub

    '배경 색상에서 빨간색 라디오 버튼 선택 시 이벤트
    Private Sub rbbRed_CheckedChanged(ByVal sender As  _
            System.Object, ByVal e As System.EventArgs) Handles _
             rbbRed.CheckedChanged
        lblText.BackColor = Color.Red
    End Sub

    '배경 색상에서 녹색 라디오 버튼 선택 시 이벤트
    Private Sub rbbGreen_CheckedChanged(ByVal sender As  _
            System.Object, ByVal e As System.EventArgs) Handles _
            rbbGreen.CheckedChanged
        lblText.BackColor = Color.Green
    End Sub
End Class
