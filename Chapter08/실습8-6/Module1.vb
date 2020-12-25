Imports System.Text

Module Module1

    Sub Main()

        'stringbuilder 클래스 선언 
        Dim str3 As New StringBuilder("ABCDEFG")
        Dim str4 As New StringBuilder("HIJKLMN")
        Console.WriteLine(str3.ToString() + str4.ToString())
        str3.Append(" and  ")
        Console.WriteLine(str3.ToString() + str4.ToString())

        Dim str5 As New StringBuilder("알파벳 : ", 40)
        ' "알파벳 : "(문자열로 초기화), 용량을 40으로 지정

        For c As Integer = 65 To 90
            'ASCII 코드를 문자로 변환
            str5.Append(Convert.ToChar(c))

            'for문으로 작업한 C를 
            'Append(초기화시킨 문자열(알파벳 : ) 뒤에 덧붙임
        Next c

        str5(10) = "_"
        '스트링빌더 클래스의 10번쨰  인덱스 다음에 _로 변경
        Console.WriteLine(str5)

        '"_"를 "E"로 변경
        str5.Replace("_", "E")
        Console.WriteLine(str5.ToString)

        '10번째 @@@를 삽입
        str5.Insert(10, "@@@")
        Console.WriteLine(str5.ToString)

        '삽입 문자를 제거
        str5.Remove(10, 3)
        Console.WriteLine(str5.ToString)
        Console.ReadLine()
    End Sub

End Module