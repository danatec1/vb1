Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object,
              ByVal e As System.EventArgs) Handles MyBase.Load
        txtStr1.Text = ""       'txtSTR1의 값을 초기화한다.
        txtStr2.Text = ""       'txtSTR2의 값을 초기화한다.
        txtStr3.Text = ""       'txtSTR3의 값을 초기화한다.
        txtNum1.Text = ""       'txtNUM1의 값을 초기화한다.
        txtNum2.Text = ""       'txtNUM2의 값을 초기화한다.
        txtNum3.Text = ""       'txtNUM3의 값을 초기화한다.

        txtStr1.Focus()         '커서의 위치를 지정한다.
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object,
              ByVal e As System.EventArgs) Handles btnOk.Click
        '입력된 두 개의 문자열을 합친 후 값을 대입
        txtStr3.Text = AddStr(txtStr1.Text, txtStr2.Text)

        txtNum3.Text = AddNum(txtNum1.Text, txtNum2.Text)
    End Sub
    '문자열 합치기
    Private Function AddStr(ByVal p_str1 As String,
                    ByVal p_str2 As String) As String
        '전달받은 두 개의 문자열을 연결하여 Return한다.
        Return (p_str1 & p_str2)
    End Function

    '두 수 더하기
    Private Function AddNum(ByVal p_num1 As String,
                ByVal p_num2 As String) As Double
        '전달받은 두개의 문자열을 숫자로 변환 후 Return한다.
        Return (Val(p_num1) + Val(p_num2))
    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
