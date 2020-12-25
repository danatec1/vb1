Module Module1
    Sub Main()
        Dim Rob1 As Robot = New Robot
        Dim succer As String
        '클래스와 인터페이스를 연결한다.
        Dim inter1 As ImyInterface = Rob1
        inter1.Move("손")
        succer = inter1.Pickup("축구공")
    End Sub
End Module