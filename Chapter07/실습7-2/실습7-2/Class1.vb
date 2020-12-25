Public Class Class1
    '변수 선언
    Public Hap As Integer   ' 두수의 합한 값 저장
    Public Cha As Integer   ' 두수의 뺀 값 저장
    Public Gop As Double    ' 두수의 곱한 값 저장
    Public Mul As Double    ' 두수의 나누기 값 저장

    ' Sub Calc_Hap 선언
    Public Sub Calc_Hap(ByVal a As Integer, ByVal b As Integer)
        Hap = a + b  ' 두 수의 합을 구한다.
    End Sub
    ' Sub Calc_Cha 선언
    Public Sub Calc_Cha(ByVal a As Integer, ByVal b As Integer)
        Cha = a - b ' 두 수의 차를 구한다.
    End Sub

    ' Sub Calc_Gop 선언
    Public Sub Calc_Gop(ByVal a As Integer, ByVal b As Integer)
        Gop = a * b  ' 두 수의 곱을 구한다.
    End Sub

    ' Sub Calc_Mul 선언
    Public Sub Calc_Mul(ByVal a As Integer, ByVal b _
                             As Integer)
        Mul = a / b ' 두 수의 나누기를 구한다.
    End Sub
End Class
