Public Class Form1
    Dim Sum As Integer '과목의 합계값을 저장하기 위해 선언
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
                         Handles MyBase.Load
        '폼 객체의 값을 초기화한다.
        txtVb2015.Text = ""      'VB 점수 값을 지워준다.
        txtXml.Text = ""    'XML 점수 값을 지워준다.
        txtJava.Text = ""    'JAVA 점수 값을 지워준다.
        txtTot.Text = ""     '합계 점수 값을 지워준다.
        txtAvg.Text = ""    '평균 점수 값을 지워준다. 
        Sum = 0    '과목 점수의 합계를 저장하는 변수를 초기화한다.
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) _
                 Handles btnOk.Click
        '합과 평균을 구한다.
        Sum = Val(txtVb2015.Text) + Val(txtXml.Text) _
                   + Val(txtJava.Text) '입력값을 숫자로 변환한다
        txtTot.Text = Sum
        txtAvg.Text = Int(Sum / 3)

        '평균으로 학점을 뽑아 메시지 박스로 표현한다.
        If Sum / 3 >= 90 Then
            MsgBox("축하합니다! A학점", MsgBoxStyle.Information,
                "학점 메시지")
        ElseIf Sum / 3 >= 80 Then
            MsgBox("축하합니다! B학점", MsgBoxStyle.Information,
                 "학점 메시지")
        ElseIf Sum / 3 >= 70 Then
            MsgBox("좀더 노력하세요! C학점",
                 MsgBoxStyle.Information, "학점 메시지")
        ElseIf Sum / 3 >= 60 Then
            MsgBox("분발해야 되겠군요! D학점",
                  MsgBoxStyle.Information, "학점 메시지")
        Else
            MsgBox("구제불능이군요! F학점",
                 MsgBoxStyle.Information, "학점 메시지")
        End If

        '폼 객체의 값을 초기화 한다.
        txtVb2015.Text = ""      'VB 점수 값을 지워준다.
        txtXml.Text = ""     'XML 점수 값을 지워준다.
        txtJava.Text = ""    'JAVA 점수 값을 지워준다.
        txtTot.Text = ""     '합계 점수 값을 지워준다.
        txtAvg.Text = ""    '평균 점수 값을 지워준다. 
        Sum = 0    '과목 점수의 합계를 저장하는 변수를 초기화한다.

        txtVb2015.Focus() 'Visual Basic 입력창으로 Focus를 이동한다.

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End  '프로그램을 종료한다.
    End Sub
End Class
