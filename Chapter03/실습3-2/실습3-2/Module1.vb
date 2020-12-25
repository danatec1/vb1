Module Module1

    Sub Main()
        Console.WriteLine("5 + 5 = {0}", 5 + 5)   '덧셈
        Console.WriteLine("5 - 4 = {0}", 5 - 4)   '뺄셈
        Console.WriteLine("5 * 2 = {0}", 5 * 2)   '곱셈
        Console.WriteLine("5 / 3 = {0}", 5 / 3)   '나눗셈

        Console.WriteLine("10 Mod 2 = {0}", 10 Mod 2)   '몫
        Console.WriteLine("10 \   4 = {0}", 10 \ 2) '나머지
        Console.WriteLine("10 ^   2 = {0}", 10 ^ 2) '승수

        Console.WriteLine("10 >  2  = {0}", 10 > 2) '비교(참)
        Console.WriteLine("10 <  2  = {0}", 10 < 2) '비교(거짓)
        Console.WriteLine("10 <= 10 = {0}", 10 <= 10)   '비교(참)
        '비교(거짓)
        Console.WriteLine("VB Like V? = {0}", "VB" Like "V")
        '비교(참)
        Console.WriteLine("VisualBasic 2019 like Visu* = {0}",
                           "VisualBasic" Like "Visu*")
        Console.ReadLine()
    End Sub

End Module
