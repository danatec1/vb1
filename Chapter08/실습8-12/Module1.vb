Module Module1

    Sub Main()
        Dim DT As DateTime = DateTime.Now

        Console.WriteLine("현재 날짜와 시간 : {0}", DT)

        Console.WriteLine("{0} 년 {1} 월 {2} 일 {3} 번째 요일", _
                    DT.Year, DT.Month, DT.Day, DT.DayOfWeek)

        Console.WriteLine("{0} 시 {1} 분 {2} 초 ", _
                     DT.Hour, DT.Minute, DT.Second)
        Console.ReadLine()
    End Sub

End Module