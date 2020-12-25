Public Class BaseClassTs
    ' 파생 클래스에서 재정의 가능하도록 Overridable 키워드 사용
    Public Overridable Sub Hello()
        Console.WriteLine("Overridable Hello Method")
    End Sub
End Class

Public Class ClassTs
    Inherits BaseClassTs
    ' BaseClassTs의 메소드를 제정의해서 사용할 수 있게 
    ' Shadow 키워드를 붙임
    ' Shadow 키워드를 사용하면 기초 클래스와 파생 클래스 안의 모든 
    ' 메소드를 사용할 수 있다.
    Public Shadows Sub Hello()
        Console.WriteLine("Shadow Hello Method")
    End Sub
End Class