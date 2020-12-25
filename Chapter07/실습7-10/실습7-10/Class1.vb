Interface ImyInterfaceA
    Sub Move1(mySelect As String)
End Interface

Interface ImyInterfaceB
    Sub Move2(mySelect As String)
End Interface

Public Class Robot
    ' 두 개의 인터페이스를 연결한다.
    Implements ImyInterfaceA, ImyInterfaceB

    Private Sub Move(mySelect As String) _
    Implements ImyInterfaceA.Move1, ImyInterfaceB.Move2
        If mySelect = "손" Then
            Console.WriteLine("손으로 잡아라")
        Else
            Console.WriteLine("발로 차라")
        End If
    End Sub

End Class