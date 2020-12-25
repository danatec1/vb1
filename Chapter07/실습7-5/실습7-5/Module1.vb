Module Module1
    Sub main()
        Dim cal_avg As PyoungKyoon = New PyoungKyoon

        ' 매개변수로 넘긴 점수의 평균을 구한다.
        cal_avg.Calc_avg()
        Console.WriteLine("평균은 {0} ", cal_avg.ret_avg)
        Console.ReadLine()
    End Sub
End Module