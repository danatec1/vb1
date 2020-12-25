Imports System
Imports System.Collections
Imports System.Collections.Specialized

Module Module1

    Sub Main()
        Dim myCol As New StringCollection()
        Dim i As Integer
        Dim myArr() As String = _
           {"RED", "orange", "yellow", "RED", "green", _
            "blue", "RED", "indigo", "violet", "RED"}

        myCol.AddRange(myArr)

        Console.WriteLine("foreach 문으로 데이터의 요소 출력!")
        PrintValues1(myCol)

        Console.WriteLine _
            ("IEnumerator를 이용하여 데이터의 요소를 출력!")
        PrintValues2(myCol)

        Console.WriteLine _
            ("카운트와 항목의 속성을 이용하여 데이터의 요소를 출력")
        PrintValues3(myCol)

        myCol.Add("* white") '데이터의 끝에 추가
        myCol.Insert(3, "* gray") '3번 데이터 다음에 추가

        Console.WriteLine("데이터의 끝과 3번 데이터 다음에 추가:")
        PrintValues1(myCol)

        'yellow 데이터 제거
        myCol.Remove("yellow")

        Console.WriteLine("yellow 데이터 제거 후:")
        PrintValues1(myCol)

        'RED 데이터를 모두 제거
        i = myCol.IndexOf("RED")
        While (i > -1)
            myCol.RemoveAt(i)
            i = myCol.IndexOf("RED")
        End While

        '모든 RED 데이터의 제거를 검증.
        If (myCol.Contains("RED")) Then
            Console.WriteLine _
                ("*** 아직 RED 데이터가 포함되어 있습니다")
        End If
        Console.WriteLine("모든 RED 데이터를 제거 후")
        PrintValues1(myCol)
        Console.ReadLine()
    End Sub

    '현재 상태의 데이터 출력.
    Sub PrintValues1(myCol As StringCollection)
        '서브 프로시저의 시작

        '요소의 결과값을 출력하는데 입력 데이터의 반대 순서대로 출력
        For Each obj As Object In myCol
            Console.WriteLine("   {0}", obj)
        Next obj
        Console.WriteLine()
    End Sub

    'enumerator를 사용하여 현재 데이터 출력
    Sub PrintValues2(myCol As StringCollection)
        Dim myEnumerator As StringEnumerator _
            = myCol.GetEnumerator()

        While (myEnumerator.MoveNext())
            Console.WriteLine("   {0}", myEnumerator.Current)
        End While
        Console.WriteLine()
    End Sub

    '카운트와 항목의 속성 사용
    Sub PrintValues3(myCol As StringCollection)
        For i = 0 To myCol.Count - 1
            Console.WriteLine("   {0}", myCol(i))
        Next
        Console.WriteLine()
    End Sub

End Module