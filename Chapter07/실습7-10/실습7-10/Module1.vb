Module Module1
    Sub Main()
        Dim Robo1 As Robot = New Robot
        Dim interA1 As ImyInterfaceA = Robo1
        Dim interB1 As ImyInterfaceB = Robo1

        interA1.Move1("손")
        interB1.Move2("발")
    End Sub
End Module