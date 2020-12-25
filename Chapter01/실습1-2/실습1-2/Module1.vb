Module Module1

    Sub Main()
        Console.WriteLine("좋아하는 프로그램을 입력하고 [Enter]를 누르세요")
        Dim language As String
        language = Console.ReadLine() '콘솔에서 입력을 기다린다.
        language = language.ToUpper '소문자가 입력되면 대문자로 바뀐다
        If language = "VISUAL BASIC" Or
            language = "VB" Or
            language = "VB.NET" Then
            Console.WriteLine("아주 좋습니다!")
        Else
            Console.WriteLine(language & " 는 비주얼베이직이 아닙니다.")
        End If
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("엔터를 누르면 프로그램이 종료됩니다")
        Console.ReadLine() '화면을 멈춘다.
    End Sub

End Module
