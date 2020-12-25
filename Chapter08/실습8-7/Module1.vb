Module Module1

    Sub Main()
        Dim Alp As Char
        Dim c(3) As Integer
        While True '참일 경우만 반복
            Console.WriteLine("영문자 값을 입력하세요(Enter=종료) ")
            c(0) = Console.Read()
            If (c(0) = 13) Then Exit While 'Enter를 누른 경우 종료
            c(1) = Console.Read() 'Cr 값이 입력
            c(2) = Console.Read() 'Lf 값이  입력

            Alp = Convert.ToChar(c(0)) '문자로 변환

            Console.WriteLine("10진수 코드값= {0}, 문자내용 = {1} ",
                              c(0), Alp)
            'ASCII 값과 문자가 출력
        End While
        Console.ReadLine()
    End Sub

End Module