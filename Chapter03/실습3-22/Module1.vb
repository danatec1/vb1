Module Module1

    Sub Main()
        Dim i As Integer = 0
        Dim sum As Integer = 0

        Console.WriteLine("")

        Do While i < 100
            i = i + 2
            sum = sum + i
        Loop
        Console.WriteLine _
            ("Do While 문에서 2부터 100까지 짝수의 합은 {0}입니다 ", sum)


        i = 0
        sum = 0
        Do Until i = 100
            i = i + 2
            sum = sum + i
        Loop
        Console.WriteLine _
            ("Do Until 문에서 2부터 100까지 짝수의 합은 {0}입니다 ", sum)
        Console.ReadLine()
    End Sub

End Module