Module Module1
    Sub Main()
        ' 파생 클래스
        Dim ClsTs As ClassTs = New ClassTs
        ClsTs.Hello()

        ' 기초 클래스
        Dim ClsTs2 As BaseClassTs = New ClassTs
        ClsTs2.Hello()
    End Sub
End Module