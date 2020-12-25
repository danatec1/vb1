Public Class frmMain
    Sub ShowTax()
        Const TaxRate As Single = 0.08 ' 8% 세율
        Dim strPrice As String          ' 문자열로 정의된 금액 변수
        Dim decPrice As Decimal         ' Decomal 로 선언된 금액 변수
        Dim Tax_class As New TaxClass   ' Class 변수 선언(객체 생성)

        ' 금액 지정
        strPrice = txtAmt.Text
        decPrice = CDec(txtAmt.Text)

        '세율을 구하는 두 가지 유형의 Class Method 호출.
        MessageBox.Show(Tax_class.TaxAmount(strPrice, TaxRate))
        MessageBox.Show(Tax_class.TaxAmount(decPrice, TaxRate))

    End Sub

    Private Sub btnTax_Click(sender As Object, _
                e As EventArgs) Handles btnTax.Click
        ShowTax()   ' 세금 계산 후 메시창 띄우기
    End Sub
End Class
