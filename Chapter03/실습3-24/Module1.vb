Module Module1

    Sub Main()
        Dim i As Integer

        i = 10                  'i를 10으로 초기화
        Do While i <= 60        'i <= 60까지 반복
            Console.Write(" {0}", i)
            If i = 40 Then Exit Do 'i=40 이면 Do-Loop를 빠져 나간다.
            i = i + 5       'i를 5증가시킴
        Loop
        Console.WriteLine("")
        Console.WriteLine("루프 종료후의 i = {0} ", i)
        Console.ReadLine()
    End Sub

End Module