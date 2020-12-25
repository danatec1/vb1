Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) _
                  Handles btnOk.Click
        Dim Last_Day As Integer

        Last_Day = Val(txtWol.Text) '월을 입력받아서 정수로 변환한다

        Select Case Last_Day
            Case 2 : lblIl.Text = "28일"
            Case 1, 3, 5, 7, 8, 12
                lblIl.Text = "31일"
            Case 4, 6, 9, 10, 11
                lblIl.Text = "30일"
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
                  Handles btnExit.Click
        End  '프로그램을 종료한다.
    End Sub
End Class
