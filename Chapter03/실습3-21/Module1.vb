Module Module1

    Sub Main()
        Dim i As Integer
        Dim sports() As String = {"축구", "야구", "배구", "농구", "핸드볼"}
        Dim kooki As String

        Console.WriteLine(Space(5) + "-- 일반 For 문의 출력 --")

        For i = 0 To 4
            Console.WriteLine("구기 스포츠 = {0}", sports(i))
        Next
        Console.WriteLine("")
        Console.WriteLine(Space(5) + "-- For Each 문의 출력 --")

        For Each kooki In sports
            Console.WriteLine("구기 스포츠 = {0}", kooki)
        Next
        Console.ReadLine()
    End Sub

End Module