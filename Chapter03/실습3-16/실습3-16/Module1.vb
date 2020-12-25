Module Module1

    Sub Main()
        Dim aDim(5), bDim(0 To 5) As Integer
        Dim i, j As Integer

        For i = 0 To 4
            aDim(i) = i + 1
            Console.WriteLine("aDim 배열 {0}방 값은 {1}  " _
                    , i, aDim(i))
        Next
        Console.WriteLine("")

        j = 5
        For i = 0 To 4
            bDim(i) = j + i + 1
            Console.WriteLine("bDim 배열 {0}방 값은 {1}  " _
                  , i, bDim(i))
        Next
        Console.ReadLine()

    End Sub

End Module