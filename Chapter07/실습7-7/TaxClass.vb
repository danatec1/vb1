Public Class TaxClass
    '세금을 계산 시 금액을 매개변수로 10진수로 받는다.
    Overloads Function TaxAmount(ByVal decPrice As Decimal, _
              ByVal TaxRate As Single) As String
        TaxAmount = "Price is a Decimal. Tax is $" & _
                    (CStr(decPrice * TaxRate))
    End Function

    '세금을 계산 시 금액을 매개변수로 문자열로 받는다.
    Overloads Function TaxAmount(ByVal strPrice As String, _
              ByVal TaxRate As Single) As String
        TaxAmount = "Price is a String. Tax is $" & _
                    CStr((CDec(strPrice) * TaxRate))
    End Function
End Class
