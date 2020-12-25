Module Module1

    Sub Main()
        Dim mySL As New SortedList()
        'Sortedlist를 사용하기 위해 선언 한다

        'Add 메소드를 이용하여 Sortedlist 객체에 데이터를 수록한다.
        mySL.Add("Second", "World")
        mySL.Add("First", "Hello")
        mySL.Add("Third", "!")

        'Sortedlist 객체의 데이터 건수와 용량을 출력한다.
        Console.WriteLine("mySL : " + mySL.ToString)
        Console.WriteLine("  데이터 건수:    {0}", mySL.Count)
        Console.WriteLine("  용량: {0}", mySL.Capacity)
        Console.WriteLine("  키와 값:")
        PrintKeysAndValues(mySL)
    End Sub
    Sub PrintKeysAndValues(myList As SortedList)
        '서브 프로시저의 시작

        Dim i As Integer
        Console.WriteLine(vbTab + "키-" + vbTab + "값-")

        '키와 결과 값을 출력하는 메소드를 호출한다
        For i = 0 To myList.Count - 1
            '키와 결과 값을 출력하는데 키의 순서대로 출력된다
            Console.WriteLine(vbTab + "{0}:" + vbTab + "{1}", _
                myList.GetKey(i), myList.GetByIndex(i))
        Next
        Console.WriteLine()
        Console.ReadLine()
    End Sub

End Module