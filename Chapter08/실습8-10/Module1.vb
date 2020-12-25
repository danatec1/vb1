Module Module1

    Sub Main()
        Dim squares(10) As Integer '일반 배열 선언

        For i As Integer = 0 To 10
            squares(i) = i * i '데이터값 저장
        Next i

        Dim txt As String = "일반 배열:" & vbCrLf
        '텍스트 문자열에 제목 저장
        For i As Integer = 0 To 10
            txt &= squares(i).ToString & vbCrLf
            '배열 값의 저장
        Next i
        Console.WriteLine(txt)

        Dim squareA As Array = _
            Array.CreateInstance(GetType(Integer), 11)
        ' 11개의 배열 객체 선언
        For i As Integer = 0 To 10
            squareA.SetValue(i * i, i) '배열에 값 저장
        Next i

        Dim txt2 As String = "객체 배열:" & vbCrLf
        For i As Integer = 0 To 10
            txt2 &= squareA.GetValue(i).ToString & vbCrLf
            '배열 값을 텍스트에 전달
        Next i
        Console.WriteLine(txt2)
        Console.Read()
    End Sub

End Module