Imports System.Collections.Generic
Imports System.Collections

Module Module1

    Sub Main()

        Dim al As New ArrayList()
        Dim j As Integer = 0
        Dim d_test() As Double = {1.6, 2.3, 3.2}
        Dim i_test() As Integer = {2, 3, 4}

        For i = 0 To d_test.Length - 1
            al.Add(d_test(i))
        Next i

        For i = 0 To i_test.Length - 1
            al.Add(i_test(i))
        Next i

        For Each o As Object In al
            Console.WriteLine("al[{0}] = {1}", j, o)
            j += 1
        Next o
        Console.ReadLine()
    End Sub

End Module
