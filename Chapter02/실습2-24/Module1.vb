Module Module1
    Sub Main()

        Randomize() '실행 시마다 다른 계열의 난수를 발생

        Console.WriteLine("Rnd() = {0}", Int(Rnd() * 100))
        Console.WriteLine("int(3.6) = {0}, int(-3.6) = {1}",
                                 Int(3.6), Int(-3.6))
        Console.WriteLine("fix(3.6) = {0}, fix(-3.6) = {1}",
                                 Fix(3.6), Fix(-3.6))
        Console.WriteLine("Abs(-3.6) = {0}", Math.Abs(-3.6))
        Console.WriteLine("Sqrt(4) = {0}", Math.Sqrt(4))
        Console.WriteLine("Sign(4) = {0}", Math.Sign(3.6))
        Console.WriteLine("Sin(30) = {0}", Math.Sin(30))
        Console.WriteLine("Cos(30) = {0}", Math.Cos(30))
        Console.WriteLine("Tan(90) = {0}", Math.Tan(90))
        Console.WriteLine("Exp(1) = {0}", Math.Exp(1))
        Console.WriteLine("Log(2.718) = {0}", Math.Log(2.718))
        Console.ReadLine()
    End Sub
End Module