Module Module1
    Dim a() As Integer '동적 배열 선언
    Dim b() As Integer '동적 배열 선언
    Sub Main()
        Dim i As Integer

        ReDim a(5) '동적 배열의 크기 선언
        ReDim b(5) '동적 배열의 크기 선언
        For i = 1 To 5
            a(i) = i
        Next i
        b = a '배열 값을 한꺼번에 대입
        Console.Write("동적 배열 b(5)의 값들 : ")
        For i = 1 To 5
            Console.Write(" {0}", b(i))
        Next i
        Console.WriteLine("")
        Console.ReadLine()
    End Sub

End Module
