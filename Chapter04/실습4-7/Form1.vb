Public Class frmMain
    Private Sub frmMain_Load(ByVal sender As System.Object, _
          ByVal e As System.EventArgs) Handles MyBase.Load
        txtSingle.Text = ""  '값의 초기화
        txtMulti.Text = ""   '값의 초기화
        txtSingle.Focus()    '커서의 초기 위치를 지정

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnAdd.Click
        '문자열을 Append한다.
        'txtMulti.Text.Text += vbCrLf + txtSINGLE.Text
        txtMulti.AppendText(txtSingle.Text + vbCrLf)
        txtSingle.Text = "" '입력된 텍스트 지움
        txtSingle.Focus()    '커서의 초기 위치를 지정
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click
        txtSINGLE.Text = ""  '값의 초기화
        txtMULTI.Clear()     'txtMULTI의 모든 내용을 지운다.
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class