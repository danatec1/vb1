Module Module1

    Sub Main()
        Dim myStack As New Stack()
        'Stack을 사용하기 위해 선언

        'Push 메소드를 이용하여 Stack 객체에 데이터를 수록
        myStack.Push("Hello")
        myStack.Push("World")
        myStack.Push("!")

        ' Stack 객체의 데이터 건수와 값을 출력
        Console.WriteLine("myStack : " + myStack.ToString)
        Console.WriteLine(vbTab + "건수:    {0}", myStack.Count)


        Console.WriteLine(vbTab + "<Stack 저장 값>")
        PrintValues(myStack)
        Console.ReadLine()
    End Sub
    Sub PrintValues(myCollection As IEnumerable)
        '서브 프로시저의 시작

        '요소의 결과 값을 출력하는데 입력 데이터의 반대 순서대로 출력
        For Each obj As Object In myCollection
            Console.Write(vbTab + "{0}", obj)
            Console.WriteLine()
        Next obj
    End Sub

End Module
