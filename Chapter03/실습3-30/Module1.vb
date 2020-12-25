Module Module1
    Function sum(ByVal a As Integer) As Integer
        Dim i, hap As Integer
        hap = 0
        For i = 1 To a
            If i < 10 Then
                Console.Write(" {0}", i)
            Else
                Console.Write(" {0}", i)
            End If
            hap = hap + i
            If i Mod 10 = 0 Then
                Console.WriteLine(" ")
            End If
        Next i
        Console.WriteLine(" ")
        sum = hap '함수명에 최종값을 대입
    End Function
    Sub Main()
        Dim b, hap As Integer
        Console.Write("종료 값을 입력하세요!")
        b = Console.ReadLine
        hap = sum(b) '함수 프로시저를 호출과 동시에 값을 받음
        Console.WriteLine _
            ("1부터 {0}까지의 합은 {1}입니다.", b, hap)
        Console.ReadLine()
    End Sub
End Module