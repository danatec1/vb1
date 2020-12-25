Public Class frmMain

    Private Sub btnTwo_Click(ByVal sender As System.Object, _
                    ByVal e As EventArgs) Handles btnTwo.Click
        If MessageBox.Show("[확인] [취소] 중에서 선택하세요!!", _
         "2가지중에서 선택", MessageBoxButtons.OKCancel, _
        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) _
         = Windows.Forms.DialogResult.OK Then

            lblResults.Text = "[확인] 선택!!"
            '확인 선택 처리
        Else
            lblResults.Text = "[취소] 선택!!"
            '취소 선택 처리
        End If
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, _
                ByVal e As EventArgs) Handles btnThree.Click
        '결과 변수 선언
        Dim intResult As DialogResult

        '버튼 클릭 값 지정
        intResult = _
            MessageBox.Show("[예] [아니오] [취소]중에서 선택하세요!!", _
            "3가지중에서 선택", MessageBoxButtons.YesNoCancel, _
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3)

        '클릭된 결과의 처리
        Select Case intResult
            Case Windows.Forms.DialogResult.Yes
                lblResults.Text = "[예] 선택!!"
                '[예] 선택 처리
            Case Windows.Forms.DialogResult.No
                lblResults.Text = "[아니오] 선택!!"
                '[아니오] 선택 처리
            Case Windows.Forms.DialogResult.Cancel
                lblResults.Text = "[취소] 선택!!"
                '[취소] 선택 처리
        End Select
    End Sub
End Class