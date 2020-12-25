Module Module1

    Sub Main()
        Dim a As Integer
        Console.Write("학과 코드를 입력하세요!>")
        a = Console.ReadLine
        Select Case a
            Case 205 : Console.WriteLine("205는 건축과입니다")
            Case 209
                Console.WriteLine("209는 컴퓨터정보과입니다.")
            Case 201
                Console.WriteLine("201은 정보통신과입니다.")
            Case 202
                Console.WriteLine("202는 유아보육과입니다.")
            Case Else
                Console.WriteLine("학과 코드가 없는 학과입니다.")
        End Select
        Console.ReadLine()
    End Sub

End Module