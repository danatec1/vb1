Module Module1

    Sub Main()
        Dim DT As DateTime = DateTime.Now

        Dim TS As New TimeSpan(3, 2, 1, 0)

        Console.WriteLine("현재 시간 : {0}", DT)
        Console.WriteLine("시간 차이 : {0}", TS)
        Console.WriteLine("합한 시간 : {0}", DT + TS)
        Console.ReadLine()
    End Sub

End Module