Module Module1

    Sub Main()
        Dim i, sum As Integer
        i = -2 : sum = 0
20:     '20번지 레이블
        i = i + 3
        sum = sum + i
        If i = 100 Then GoTo 30
        GoTo 20
30: '30번지 레이블
        Console.WriteLine("1+4+7+ ... + 100 = {0}", sum)
        Console.ReadLine()

    End Sub

End Module