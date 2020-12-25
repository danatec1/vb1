Module Module1
    'Space(N) 함수는 지정한 수만큼의 공백으로 구성되는 문자열을 반환한다.
    Sub Main()
        Dim i As Integer, j As Integer
        Dim k As Integer
        Dim n As Integer
        Dim l As String, m As String, o As String
        Console.WriteLine(Space(15), "** 구 구 단 **")
        For i = 1 To 7 Step 3
            k = i + 1
            n = i + 2
            Console.WriteLine(Space(3) & i & "단" & Space(5) _
                    & k & "단" & Space(5) & n & "단")
            For j = 1 To 9
                '값이 10보다 작을 경우 공백을 추가한다
                l = IIf(i * j < 10, " " & i * j, i * j)
                m = IIf(k * j < 10, " " & k * j, k * j)
                o = IIf(n * j < 10, " " & n * j, n * j)
                Console.Write(Space(2) & i & "*" & j & "=" & l &
                        Space(2) & k & "*" & j & "=" & m)
                Console.WriteLine(Space(2) & n & "*" & j & "=" & o)
            Next j
            Console.WriteLine("")
            Console.WriteLine("")
        Next i
        Console.ReadLine()
    End Sub

End Module