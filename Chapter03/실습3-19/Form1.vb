Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOdd.Text = ""
        txtEven.Text = ""
        txtResult.Text = ""

        txtEven.Focus()   '텍스트에 커서를 위치한다
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        '실행 버튼 클릭 시 1 ~ 100까지의 짝수 값, 홀수 값 및
        '차이 값을 구한다.
        Dim i, j As Integer   'For문에서 사용할 변수를 선언한다.

        Dim Ehap As Integer   '짝수 값의 합을 저장할 변수 선언
        Dim Ohap As Integer   '홀수 값의 합을 저장할 변수 선언
        Dim Count As Integer  '1 ~ 100까지의 증가 값을 저장할 변수
        Dim nam As Integer    '나머지 값을 저장할 변수 선언

        For i = 1 To 10       'i값이 1부터 10까지 증가하면서 반복
            For j = 1 To 10     'j값이 1부터 10까지 증가하면서 반복
                Count = Count + 1 'Count 값을 1만큼 증가시킨다.
                nam = Count Mod 2 'Count값을 2로 나눈 나머지 값 대입

                If nam = 0 Then   'nam 값이 0(짝수)이면
                    Ehap += Count '짝수의 합에 Count값을 더한다. 
                Else              'nam 값이 1(홀수)이면
                    Ohap += Count '홀수의 합에 Count값을 더한다.
                End If
            Next j
        Next i

        txtEven.Text = Ehap       '짝수 값을 Text 컨트롤에 대입
        txtOdd.Text = Ohap       '홀수 값을 Text 컨트롤에 대입
        txtResult.Text = Ehap - Ohap '짝수-홀수 값을 Text 컨트롤에 대입

        btnOk.Focus()             '커서의 위치를 실행 버튼에 둠

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End  '프로그램을 종료한다.
    End Sub
End Class
