Public Class Class1
    Public Function class1_test(ByVal a As Integer, _
               ByVal b As Integer) As Integer
        class1_test = a + b  '두 수의 합을 구한다
    End Function
    Public Function class1_test(ByVal a As String, _
                ByVal b As String, ByVal c As String) As String
        class1_test = a & b & c '문자열을 합친다
    End Function
End Class