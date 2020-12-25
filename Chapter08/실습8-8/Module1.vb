Module Module1

    Sub Main()
        Dim str As String
        Console.WriteLine()
        While True
            Console.WriteLine("")
            Console.WriteLine("<문자열을 입력하세요.>")
            str = Console.ReadLine()
            If (str = "") Then Exit While
            Console.WriteLine("문자열:  {0} 입력되었습니다. ", str)
        End While
        Console.ReadLine()
    End Sub

End Module