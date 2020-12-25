Module Module1

    Sub Main()
        Dim q As New Queue()
        Dim i As Integer
        q.Enqueue("AAA")
        q.Enqueue(123)
        q.Enqueue(456.789)
        q.Enqueue("홍길동")
        q.Enqueue(10)
        q.Enqueue(11000.0)

        For i = 1 To 6
            Console.WriteLine("Queue 요소({0}) = {1}", _
           i, q.Dequeue())
        Next i
        Console.ReadLine()
    End Sub

End Module