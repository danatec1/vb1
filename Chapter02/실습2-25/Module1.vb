Module Module1

    Sub Main()
        Dim a As String
        a = "Visual Basic 2019"
        Console.WriteLine("LCase={0}", LCase(a)) '대문자를 소문자로
        Console.WriteLine("UCase={0}", UCase(a)) '소문자를 대문자로
        Console.WriteLine("Left={0}", Left(a, 12)) '왼쪽 12자
        Console.WriteLine("Right={0}", Right(a, 3)) '오른쪽 2자
        Console.WriteLine("Mid={0}", Mid(a, 8, 5)) '8번째 글자이후 5글자
        Console.WriteLine("Len={0}", Len(a)) '문자열의 길이
        a = "    Visual Basic 2019    "
        Console.WriteLine("|" & LTrim(a) & "|")
        Console.WriteLine("|" & RTrim(a) & "|")
        Console.WriteLine("|" & Trim(a) & "|")
        Console.ReadLine()
    End Sub

End Module