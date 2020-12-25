Module Module1

    Sub Main()
        Dim a(0 To 2, 0 To 4) As Integer '2차원 배열선언
        Dim b(0 To 2, 0 To 4) As Integer '2차원 배열선언
        Dim c(0 To 2, 0 To 4) As Integer '2차원 배열선언
        Dim k = 0, n = 1 '초기값 부여
        For i = 0 To 2
            For j = 0 To 4
                k = k + 2 : a(i, j) = k 'a 배열의 요소에 값 부여
                n = n + 2 : b(i, j) = n 'b 배열의 요소에 값 부여
                c(i, j) = a(i, j) + b(i, j) 'c 배열의 요소에 값 부여
        Next j, i

        For i = 0 To 2
            For j = 0 To 4
                If (a(i, j) < 10) Then
                    Console.Write("  {0}", a(i, j)) 'a 배열의 출력
                Else
                    Console.Write(" {0}", a(i, j)) 'a 배열의 출력
                End If
            Next j
            Console.Write(" : ")
            For j = 0 To 4
                If (b(i, j) < 10) Then
                    Console.Write("  {0}", b(i, j)) 'b 배열의 출력
                Else
                    Console.Write(" {0}", b(i, j)) 'b 배열의 출력
                End If
            Next j
            Console.Write(" : ")
            For j = 0 To 4
                If (c(i, j) < 10) Then
                    Console.Write("  {0}", c(i, j)) 'c 배열의 출력
                Else
                    Console.Write(" {0}", c(i, j)) 'c 배열의 출력
                End If
            Next j
            Console.WriteLine("")
        Next i
        Console.ReadLine()
    End Sub

End Module