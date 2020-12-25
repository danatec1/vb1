Module Module1

    Sub Main()
        Dim aBool As Boolean
        Dim aInteger As Integer

        Console.WriteLine("aBool = {0} ", aBool)
        aInteger = aBool
        Console.WriteLine("Boolean의 상수값 = {0} ", aInteger)
        Console.WriteLine()
        aBool = Not aBool
        Console.WriteLine("aBool = {0} ", aBool)

        aInteger = aBool
        Console.WriteLine("Boolean의 상수값 = {0} ", aInteger)
        Console.ReadLine() '화면을 멈춘다
    End Sub

End Module
