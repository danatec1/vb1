Module Module1

    Sub Main()
        Dim dblNumber As Double, slgNumber As Single,
             decNumber, decResult As Decimal

        'Double Single 값의 지정
        dblNumber = 45.34
        slgNumber = 56.78
        Console.WriteLine("Double = {0}, Single = {1}",
              dblNumber, slgNumber)

        'Decimal 값의 연산
        decNumber = 235.85  '23585로 저장되지만 235.85로 표현된다. 
        decResult = 328.558 * 12.4051
        Console.WriteLine("Decimal = {0},  Decimal 연산 결과 = {1}" _
                          , decNumber, decResult)
        Console.ReadLine() '화면을 멈춘다

    End Sub

End Module
