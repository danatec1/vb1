Public Class BasRobot

    '파생 클래스에서 재정의 가능하도록 
    'Overrideable Key Word를 붙인다.
    Public Overridable Sub Info()
        Console.WriteLine("기본엔진:양호")
    End Sub

End Class

Public Class Robot
    Inherits BasRobot
    '기초 클래스의 메소드를 재정의 가능하도록 
    'Overrides Key Word를 붙여준다.
    Public Overrides Sub Info()
        Console.WriteLine("로봇엔진:양호")
    End Sub

End Class
