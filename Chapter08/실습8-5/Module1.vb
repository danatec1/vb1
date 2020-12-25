Module Module1

    Sub Main()
        Dim str1 As String = "VisualBasic"
        Dim str2 As String = "program "
        Dim newString As String
        Console.WriteLine("str1 + str2 = " + str1 + " " + str2)

        Console.WriteLine("str1.substring(2) = {0}", str1.Substring(2))
        Console.WriteLine("str1.substring(0,2) = {0}", str1.Substring(0, 2))

        Console.WriteLine("str1.toLowerCase() = {0}", str1.ToLower())
        Console.WriteLine("str2.toUpperCase() =  {0}", str2.ToUpper())

        newString = " " + str1 + " " + str2 + vbCrLf
        Console.WriteLine("newString.trim() = {0}", newString.Trim())
        Console.ReadLine()
    End Sub

End Module