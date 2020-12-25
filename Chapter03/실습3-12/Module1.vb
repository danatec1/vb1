Module Module1
    Sub Main()
        Dim a As Integer
        Dim b As String
10:     Console.WriteLine("")
        Console.Write("점수를 입력하세요!(종료0)>")
        a = Console.ReadLine
        If a = 0 Then
            GoTo 30
        ElseIf a >= 90 Then
            b = "A"
        ElseIf a >= 80 Then
            b = "B"
        ElseIf a >= 70 Then
            b = "C"
        ElseIf a >= 60 Then
            b = "D"
        Else
            b = "과락"
        End If
        Console.WriteLine("")
        Console.WriteLine("{0} 점은 {1} 학점입니다.", a, b)
        GoTo 10
30:     Console.ReadLine()

    End Sub
End Module