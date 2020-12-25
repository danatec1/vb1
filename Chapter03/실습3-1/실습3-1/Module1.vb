Module Module1

    Sub Main()
        Dim x, y As Integer
        x = 10
        y = 3

        Console.WriteLine("x =  {0} , y = {1}", x, y)
        Console.WriteLine("곱  셈 :  {0} * {1} = {2}", x, y, x * y)
        Console.WriteLine("나눗셈 :  {0} / {1} = {2}", x, y, x / y)
        Console.WriteLine("덧  셈 :  {0} + {1} = {2}", x, y, x + y)
        Console.WriteLine("뺄  셈 :  {0} + {1} = {2}", x, y, x - y)
        Console.WriteLine("나머지 :  {0} % {1} = {2}", x, y, x Mod y)
        Console.WriteLine("몫     :  {0} \ {1} = {2}", x, y, x \ y)

        Console.ReadLine()
    End Sub

End Module
