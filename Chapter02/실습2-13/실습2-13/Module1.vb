Module Module1
    Public gi_Sum As Integer    'gi_Sum 변수를 정수형으로 선언
    Public gi_Avg As Integer    'gi_Avg 변수를 정수형으로 선언

    Sub Main()
        'Eng를 정수형 변수로 선언하면서 초기값을 지정
        Dim Eng As Integer = 80
        Dim Kor As Integer      'Kor, Sum을 정수형 변수로 선언
        Kor = 90                'Kor 변수에 값 90을 대입

        'Sum 변수에 Kor값과 Eng값을 더한 값을 대입.
        gi_Sum = Kor + Eng

        Sub_Avg()       '평균값을 구하는 함수를 호출

        Console.WriteLine("국어={0},영어={1}, 합계={2}",
                           Kor, Eng, gi_Sum)
        Console.ReadLine() '화면을 멈춘다

    End Sub

    Sub Sub_Avg()
        Dim Kor As Integer = 70 'Kor 변수에 값 70을 대입.
        Dim Eng As Integer = 60 'Eng 변수에 값 60을 대입.
        'gi_Sum 변수에 Kor값과 Eng값을 더한 값을 대입.
        gi_Sum = Kor + Eng

        'gi_Avg에 gi_Sum 값을 2로 나눈 몫의 값을 대입.
        gi_Avg = gi_Sum \ 2

        Console.WriteLine("합계={0}, 평균={1}", gi_Sum, gi_Avg)
    End Sub
End Module
