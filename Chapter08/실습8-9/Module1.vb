Module Module1

    Sub Main(ByVal cmdArgs() As String)
        Console.Write(vbCrLf)
        Console.Write(123)
        Console.Write(vbTab)
        Console.WriteLine(123.456)
        Console.WriteLine("대한민국")
        Console.Write(vbCrLf)

        Console.WriteLine("**** 명령 라인 agrs****")
        For x As Integer = 0 To cmdArgs.Length - 1
            Console.WriteLine("Args: {0}", cmdArgs(x))
        Next x
        Console.ReadLine()
    End Sub

End Module