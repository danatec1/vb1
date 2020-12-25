Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNum11.Text = ""       'txtNUM11의 값을 초기화한다.
        txtNum12.Text = ""       'txtNUM12의 값을 초기화한다. 
        txtNum13.Text = ""       'txtNUM13의 값을 초기화한다.
        txtNum21.Text = ""       'txtNUM21의 값을 초기화한다. 
        txtNum22.Text = ""       'txtNUM22의 값을 초기화한다.
        txtNum23.Text = ""       'txtNUM23의 값을 초기화한다. 
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim num1, num2 As Integer   '정수형 변수 num1, num2를 선언
        Dim num3, num4 As Integer   '정수형 변수 num3, num4를 선언

        num1 = Val(txtNum11.Text)
        num2 = Val(txtNum12.Text)

        Add_Val(num1, num2)         '두 수에 각각 100을 더한다.

        txtNum13.Text = num1 + num2 'num1과 num2를 더한 값을 대입

        num3 = Val(txtNum21.Text)
        num4 = Val(txtNum22.Text)

        Add_Ref(num3, num4)         '두수에 각각 200을 더한다.

        txtNum23.Text = num3 + num4 'num1과 num2를 더한 값을 대입
    End Sub
    '값에 의한 인수의 전달
    Private Sub Add_Val(ByVal p_num1 As Integer,
              ByVal p_num2 As Integer)
        p_num1 = p_num1 + 100  '전달받은 num1에 100을 더한다.
        p_num2 = p_num2 + 100  '전달받은 num2에 100을 더한다.
    End Sub
    '참조에 의한 인수의 전달
    Private Sub Add_Ref(ByRef p_num1 As Integer,
              ByRef p_num2 As Integer)
        p_num1 = p_num1 + 200  '전달받은 num1에 200을 더한다.
        p_num2 = p_num2 + 200  '전달받은 num1에 200을 더한다.
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
