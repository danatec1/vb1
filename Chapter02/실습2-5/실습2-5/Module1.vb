Module Module1

    Sub Main()
        Dim chrChar1, chrChar2, chrChar3, chrChar4,
                chrChar5, chrChar6 As Char
        Dim strString1, strString2, strString3 As String

        '문자 지정
        chrChar1 = "A"
        chrChar2 = "한"
        chrChar3 = "ABC" 'BC는 짤린다
        Console.WriteLine("Char1 = {0}, Char2 = {1}, Char3 = {2}" _
                         , chrChar1, chrChar2, chrChar3)
        chrChar4 = "1"
        chrChar5 = "2"
        chrChar6 = chrChar4 & chrChar5  'chrChar5 문자는 짤린다
        strString1 = chrChar4 + chrChar5 '2개의 문자는 결합
        Console.WriteLine("Char4 = {0}, Char5 = {1}, Char6 = {2},  String1 = {3}" _
                          , chrChar4, chrChar5, chrChar6, strString1)

        '문자열 지정
        strString1 = "Hello World!"  '이전의 문자는 지워지면서 대입된다
        strString2 = " 안녕하세요!"
        strString3 = strString1 & strString2
        Console.WriteLine("String1 = {0}, String2 = {1}" _
                          , strString1, strString2)
        Console.WriteLine("String3 = {0}", strString3)
        Console.ReadLine() '화면을 멈춘다
    End Sub

End Module
