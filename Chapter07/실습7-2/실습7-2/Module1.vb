Module Module1
    Sub Main()
        ' 매개 변수로 전달할 값을 저장할 변수
        Dim First_no, Second_no As Integer
        ' Calc_Class라는 객체를 생성
        Dim Calc_Class As New Class1
        First_no = 3   ' 연산할 값 설정
        Second_no = 7  ' 연산할 값 설정

        ' 두 수의 합 연산
        Calc_Class.Calc_Hap(First_no, Second_no)
        Console.WriteLine(" 두 수의 합 : {0} + {1} = {2}",
                First_no, Second_no, Calc_Class.Hap)

        ' 두 수의 차 연산
        Calc_Class.Calc_Cha(First_no, Second_no)
        Console.WriteLine(" 두 수의 차 : {0} - {1} = {2}",
                First_no, Second_no, Calc_Class.Cha)
        ' 두 수의 곱 연산
        Calc_Class.Calc_Gop(First_no, Second_no)
        Console.WriteLine(" 두 수의 곱 : {0} * {1} = {2}",
                First_no, Second_no, Calc_Class.Gop)

        ' 두 수의 나눗셈 연산
        Calc_Class.Calc_Mul(First_no, Second_no)
        Console.WriteLine(" 두 수의 나누기 : {0} / {1} = {2}",
                First_no, Second_no, Calc_Class.Mul)
        Console.ReadLine()
    End Sub
End Module
