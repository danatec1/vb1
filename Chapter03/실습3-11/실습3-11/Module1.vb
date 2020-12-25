Module Module1
    Sub Main()
        Dim a As Integer
        Dim b As String

        Console.Write("a = ")
        a = Console.ReadLine
        b = IIf(a = 10, "a는 10 입니다" _
                         , IIf(a > 10, "a는 10보다 큽니다" _
                         , "a는 10보다 작습니다"))
        Console.WriteLine(b)
        Console.ReadLine()

    End Sub
End Module