Module Module1

    Sub Main()
        Dim onObject, offObject As Object

        onObject = 1234
        Console.WriteLine("Object(integer) = {0}", onObject)

        onObject = 1234.5678
        Console.WriteLine("Object(single) = {0}", onObject)

        onObject = "가나다라"
        Console.WriteLine("Object(string) = {0}", onObject)

        offObject = Today()
        Console.WriteLine("Object(date) = {0}", offObject)
        Console.ReadLine() '화면을 멈춘다
    End Sub

End Module
