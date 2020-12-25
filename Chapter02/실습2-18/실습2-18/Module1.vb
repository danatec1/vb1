Module Module1

    Sub Main()

        Dim a As Double = 6.5
        Dim b As Integer = 6
        Dim c As Integer = 10
        Dim avg As Integer = CInt((CInt(a) + b + c)) / 3
        Console.WriteLine("평균 = {0}", avg)  'a,b,c의 평균

        Dim conCint As Integer = CInt(94.75) 'Integer 변환
        Console.WriteLine("Integer 변환 = {0}", conCint)

        Dim str As String = "\2,345.67"
        Dim dec As Decimal = CDec(str) 'Decimal 변환
        Console.WriteLine("Decimal 변환 = {0}", dec)

        Dim decstr = CStr(dec) 'String 변환
        Console.WriteLine("String 변환 = {0}", decstr)

        Dim stype = CType(dec, String) 'String 변환
        Console.WriteLine("Type의 String 변환 = {0}", stype)

        Console.ReadLine()
    End Sub

End Module