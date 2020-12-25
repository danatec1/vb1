Public Class MsgShin

    Public Event EventMsg(ByVal str1 As String) '이벤트 선언

    Public Sub TestRun(ByVal str1 As String)    '테스트 메소드
        Console.WriteLine("[1]" & str1)          '첫 번째 문자를 출력

        'EvenrMst 이벤트를 발생시킨다.
        RaiseEvent EventMsg(str1)
        Console.WriteLine("[3]" & str1)
    End Sub
End Class