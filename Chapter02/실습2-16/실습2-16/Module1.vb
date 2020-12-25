Module Module1
    Private Const PI As Single = 3.1459265
    Const Radius = 5

    Sub Main()
        Dim area, duire As Single
        area = PI * Radius * Radius
        duire = 2 * PI * Radius

        Console.WriteLine("원의 면적은 : {0}", area)
        Console.WriteLine("원의 둘레는 : {0}", duire)
        Console.ReadLine()
    End Sub

End Module