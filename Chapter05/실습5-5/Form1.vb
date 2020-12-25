Public Class frmMain
    Private Sub btnModal_Click(sender As Object, _
                 e As EventArgs) Handles btnModal.Click
        'Modal 버튼 클릭 이벤트
        Dim frm2 As New frmSnd    '폼 생성
        frm2.lblTitle2.Text = "Modal로 생성된 Form"
        frm2.ShowDialog()         'Modal로 폼 생성
    End Sub

    Private Sub btnModaless_Click(sender As Object, _
                e As EventArgs) Handles btnModaless.Click
        'Modaless 버튼 클릭 이벤트
        Dim frm2 As New frmSnd    '폼 생성
        frm2.lblTitle2.Text = "Modaless로 생성된 Form"
        frm2.Show()               'Modaless로 폼 생성
    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        '종료 버튼 클릭 이벤트
        End
    End Sub
End Class
