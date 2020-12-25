﻿Public Class Member

    Public name As String ' 성명
    Public kor As Integer ' 국어
    Public eng As Integer ' 영어
    Public mat As Integer '수학

End Class

Public Class PyoungKyoon
    Inherits Member      ' Member Class 를 상속받는다.

    Public Avg As Double '평균값을 저장한 변수

    Sub New(ByVal p_name As String, ByVal p_kor As Integer,
             ByVal p_eng As Integer, ByVal p_mat As Integer)
        name = p_name ' 이름대입
        kor = p_kor   ' 국어점수
        eng = p_eng   ' 영어점수
        mat = p_mat   ' 수학점수

        '세 과목에 대한 평균점수를 구한다.
        Avg = Val(Format((kor + eng + mat) / 3, "##0.00"))
    End Sub
End Class

