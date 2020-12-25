Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
        Handles btnExit.Click
        End
    End Sub

    '체크박스 클릭 이벤트
    Private Sub chkStr1_CheckedChanged(ByVal sender As  _
              System.Object, ByVal e As System.EventArgs) Handles _
              chkStr1.CheckedChanged
        lblSample.Text = "" '라벨의 값을 지워준다.
        Str_Make()         '문자열 조합 Procedure를 호출한다.
    End Sub

    '체크박스 클릭 이벤트
    Private Sub chkIStr2_CheckedChanged(ByVal sender As  _
              System.Object, ByVal e As System.EventArgs) Handles _
             chkStr2.CheckedChanged
        lblSample.Text = "" '라벨의 값을 지워준다.
        Str_Make()         '문자열 조합 Procedure를 호출한다.
    End Sub
   
    '체크박스 클릭 이벤트
    Private Sub chkStr3_CheckedChanged(ByVal sender As  _
            System.Object, ByVal e As System.EventArgs) Handles _
            chkStr3.CheckedChanged
        lblSample.Text = "" '라벨의 값을 지워준다.
        Str_Make()         '문자열 조합 Procedure를 호출한다.
    End Sub
    '체크박스에 체크된 문자열에 대해 순서대로 연결하여 보여준다.
    Private Sub Str_Make()
        ' chkSTR1값이 체크되어 있으면
        If chkSTR1.CheckState = CheckState.Checked Then
            lblSample.Text += chkStr1.Text & vbCrLf
        End If

        ' chkSTR2값이 체크되어 있으면
        If chkSTR2.CheckState = CheckState.Checked Then
            lblSample.Text += chkStr2.Text & vbCrLf
        End If

        ' chkSTR3값이 체크되어 있으면
        If chkSTR3.CheckState = CheckState.Checked Then
            lblSample.Text += chkStr3.Text & vbCrLf
        End If
    End Sub
End Class
