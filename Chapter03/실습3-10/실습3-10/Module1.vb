Module Module1

    Sub Main()
        Dim num As Integer
        Console.Write("1개의 정수를 입력하시오 > ")
        num = Console.ReadLine '데이터를 입력

        If (num > 5) Then
            Console.WriteLine("입력한 수는 5보다 큽니다.")
        ElseIf (num < 5) Then
            Console.WriteLine("입력한 수는 5보다 작습니다.")
        Else
            Console.WriteLine("입력한 수는 5입니다.")
        End If
        Console.ReadLine()
    End Sub

End Module