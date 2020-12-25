Module Module1

    Sub Main()
        Dim a As Integer = 10, b As Integer = 15
        Dim c As Integer = 5, d As Integer = 20

        Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d)
        Console.WriteLine("(a > b) Or (c > d) = {0}", (a > b) Or (c > d))
        Console.WriteLine("(a > b) And (c > d) = {0}", (a > b) And (c > d))
        Console.WriteLine("(a < b) Xor (c > d) = {0}", (a < b) Xor (c > d))
        Console.WriteLine("(a>b) AndAlso (c>d) = {0}", (a > b) AndAlso (c > d))
        Console.WriteLine("(a<b) OrElse (c>d) = {0}", (a < b) OrElse (c > d))
        Console.WriteLine("Not a = {0}, Not b = {1} ", Not a, Not b)
        Console.WriteLine("Not c = {0}, Not d = {1} ", Not c, Not d)
        Console.ReadLine()
    End Sub

End Module
