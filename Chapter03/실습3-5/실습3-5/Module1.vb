Module Module1

    Sub Main()
        Dim i As Integer = 1, j As Integer = 2, k As Integer = 3
        Dim boo As Boolean
        boo = i < j And j < k
        Console.WriteLine("Result = {0}", boo)

        boo = i = j Or j < k And j > k
        Console.WriteLine("Result = {0}", boo)

        Console.WriteLine("True Or False = {0}", True Or False)
        '논리합의 결과 값인 true를 출력
        Console.WriteLine("True And False = {0}", True And False)
        '논리곱의 결과 값인 false를 출력
        Console.WriteLine("Not True = {0}", Not True)
        '논리부정의 결과 값인 false를 출력
        Console.WriteLine("****************************")

        Console.ReadLine()
    End Sub

End Module
