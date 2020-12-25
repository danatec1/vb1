Imports System
Imports System.IO

Module module1
    Sub Main()
        Dim dispText As String = "abc"
        Dim str1, str2, str3 As String
        Dim num1 As Integer
        'String형의 변수 distext를 작성하여 "abc"로 초기화
        Console.WriteLine(dispText) '『abc』로 표시
        dispText = "def"  'dispText에 "def"에 대입

        '문자열은 +연산자로 연결된다.
        str1 = "abc"
        str2 = "def"
        Console.WriteLine(str1 + str2) ' 『abcdef』로 표시
        '또한 문자열에 수치형의 데이터를 ＋연산자로 연결하면 
        '수치는 문자열에 타입 변환되어 연결된다.

        num1 = 2019
        str3 = "올해의 연도는? "
        str3 = str3 + Str(num1)
        Console.WriteLine(str3) '『 올해의 연도는? 2019 』로 표시
        Console.ReadLine()
    End Sub

End Module