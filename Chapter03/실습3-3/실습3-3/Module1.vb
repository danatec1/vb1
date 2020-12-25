Module Module1

    Sub Main()
        Dim a, b, x As Integer

        a = 10
        b = 10

        a = a * 9 + 10
        b *= 9 + 10

        Console.WriteLine("a = {0}", a)
        Console.WriteLine("b = {0}", b)
        Console.WriteLine("x = {0}", x)
        Console.WriteLine("***************")

        x = 10
        x += 10  'x+10을 x에 대입
        Console.WriteLine("x += 10값은 {0}", x)

        x -= 10  'x-10을 x에 대입
        Console.WriteLine("x -= 10값은 {0}", x)

        x *= 5  'x*5를 x에 대입
        Console.WriteLine("x *= 5값은  {0}", x)

        x /= 10  'x 나누기 10을 x에 대입
        Console.WriteLine("x /= 10값은 {0}", x)

        Console.ReadLine()
    End Sub

End Module
