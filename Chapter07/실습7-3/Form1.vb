Public Class frmMain
    Dim 실습7_3 As New Class1  '실습 7_3의 클래스를 생성한다.

    Private Sub btnNum_Click(sender As Object, _
                e As EventArgs) Handles btnNum.Click
        Dim a, b As Integer
        a = Val(txtNum1.Text)  '입력된 값을 숫자로 변환
        b = Val(txtNum2.Text)
        '실습 7_3 객체의 class1_test 메소드를 호출한다
        txtResult.Text = Str(실습7_3.class1_test(a, b))
    End Sub

    Private Sub btnChar_Click(sender As Object, _
                e As EventArgs) Handles btnChar.Click
        Dim a, b As String
        a = txtNum1.Text
        b = txtNum2.Text
        txtResult.Text = 실습7_3.class1_test(a, " &  ", b)
    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
