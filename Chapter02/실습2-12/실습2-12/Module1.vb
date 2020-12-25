Module Module1
    Dim aPublic As Integer

    Sub Main() '메인 모듈 선언
        Dim aInt As Integer
        aPublic = 30
        aInt = 50
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)
        subModule()  '서브 모듈을 호출
        Console.ReadLine() '화면을 멈춘다
    End Sub

    Sub subModule() '서브 모듈 선언
        Dim aInt As Integer
        aInt = 80  'Main 모듈과 변수명이 같다.
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)
    End Sub
End Module