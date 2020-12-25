Module Module1
    '이벤트를 발생시킬 수 있게 인스턴스를 생성
    WithEvents shin1 As New MsgShin

    'shin1 클래스의 EventMsg 이벤트가 발생되어 수행한다.
    Private Sub Dsp_Msg(ByVal str1 As String) _
          Handles shin1.EventMsg
        Console.WriteLine("[2]" & str1)   '두 번째 문자열 출력
    End Sub

    Sub Main()
        'shin1 클래스 안의 TestRun 메소드를 호출한다.
        shin1.TestRun("홍길동")
    End Sub

End Module