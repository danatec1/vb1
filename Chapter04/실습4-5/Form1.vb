Public Class frmMain

    Private Sub btnLabel_Click(sender As Object, e As EventArgs) _
                 Handles btnLabel.Click
        lblOne.Text = "레이블 : 기본 표시"

        lblTwo.Text = _
            "레이블 : Fixed3D, BackColor(분홍색), ForeColor(파랑)"
        lblTwo.BorderStyle = BorderStyle.Fixed3D
        lblTwo.BackColor = Color.Pink
        lblTwo.ForeColor = Color.Blue

        lblThree.AutoSize = True
        lblThree.Text = "레이블 : AutoSize(True)"

        lblFour.Text = "레이블 : Size=9, Bold=True"
    End Sub
End Class
