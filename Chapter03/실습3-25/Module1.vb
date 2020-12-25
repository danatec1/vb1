Module Module1

    Sub Main()
        Dim a As Integer
        On Error GoTo 10
        a = Int(20 / 0) '0으로 나누었으므로 에러 발생
        Console.WriteLine("에러발생 프로그램 실행 끝")

        Dim b As Integer
        On Error Resume Next
        b = Int(20 / 0) '0으로 나누었으나 에러 무시
        Console.WriteLine("에러 무시 프로그램 실행 끝")

        Console.ReadLine()
        Exit Sub 'sub 프로시저를 종료
10: '레이블 번호
        Console.WriteLine(ErrorToString() & " 에러발생")
        Resume Next '에러 발생한 다음 문장으로 실행제어를 이동

    End Sub

End Module