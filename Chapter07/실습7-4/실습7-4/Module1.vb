Module Module1
    Sub main()
        Dim man As PyoungKyoon _
            = New PyoungKyoon("홍길동", 90, 89, 87)

        ' 매개변수로 넘긴 점수의 평균을 구한다.
        Console.WriteLine("평균은 {0} ", man.Avg)
        Console.ReadLine()
    End Sub
End Module