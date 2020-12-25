Interface ImyInterface
    Sub Move(mySelect As String)
    Function Pickup(mySel As String) As String
End Interface

Public Class Robot
    Implements ImyInterface

    Private Sub Move(ByVal mySelect As String) _
    Implements ImyInterface.Move

        If mySelect = "손" Then
            Console.WriteLine("손으로 잡아라")
        Else
            Console.WriteLine("발로 차라")
        End If

    End Sub

    Public Function Pickup(mySel As String) As String _
           Implements ImyInterface.Pickup

        If mySel = "축구공" Then
            Console.WriteLine("축구공을 잡았다.")
        Else
            Console.WriteLine("야구공을 잡았다.")
        End If
    End Function
End Class