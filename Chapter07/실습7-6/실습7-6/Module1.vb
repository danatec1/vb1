Module Module1
    Sub Main()
        Dim Rob1 As Robot = New Robot        '파생 클래스
        Rob1.Info()

        Dim Rob2 As BasRobot = New Robot     '기초 클래스
        Rob2.Info()
    End Sub
End Module