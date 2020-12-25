Public Class frmMain

    Private Sub btnOne_Click(ByVal sender As System.Object, _
           ByVal e As System.EventArgs) Handles btnOne.Click
        lblDisplay.Text = btnOne.Text

    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, _
           ByVal e As System.EventArgs) Handles btnTwo.Click
        lblDisplay.Text = btnTwo.Text
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, _
           ByVal e As System.EventArgs) Handles btnThree.Click
        lblDisplay.Text = btnThree.Text
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
           ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class