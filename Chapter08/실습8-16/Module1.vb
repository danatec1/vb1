Imports System.Collections.Generic
Imports System.Collections

Module Module1

    Sub Main()
        Dim hash1 As New Hashtable()

        hash1.Add("690810", "홍길동")
        hash1.Add("701116", "이순신")
        hash1.Add("740210", "강감찬")

        For Each item1 As String In hash1.Keys
            'key data type에 의한 foreach 출력
            Console.WriteLine(item1 + "       " + hash1(item1))
        Next item1

        Console.ReadLine()
    End Sub
End Module