Public Class frmMain
    Dim frmForm2 As New frmForm2
    Dim fbsFormBorderStyle() As String = _
       {"None", "FixedSingle", "Fixed3D", "FixedDialog", "Sizable", _
         "FixedToolWindow", "SizableToolWindow"}
    Private Sub btnNone_Click(sender As Object, e As EventArgs) Handles btnNone.Click
        frmForm2.FormBorderStyle = 0
        frmForm2.Text = fbsFormBorderStyle(0)
        frmForm2.Show()
    End Sub

    Private Sub btnFixedSingle_Click(sender As Object, e As EventArgs) Handles btnFixedSingle.Click
        frmForm2.FormBorderStyle = 1
        frmForm2.Text = fbsFormBorderStyle(1) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnFixed3D_Click(sender As Object, e As EventArgs) Handles btnFixed3D.Click
        frmForm2.FormBorderStyle = 2
        frmForm2.Text = fbsFormBorderStyle(2) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnFixedDialog_Click(sender As Object, e As EventArgs) Handles btnFixedDialog.Click
        frmForm2.FormBorderStyle = 3
        frmForm2.Text = fbsFormBorderStyle(3) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnSizable_Click(sender As Object, e As EventArgs) Handles btnSizable.Click
        frmForm2.FormBorderStyle = 4
        frmForm2.Text = fbsFormBorderStyle(4) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnFixedToolWindow_Click(sender As Object, e As EventArgs) Handles btnFixedToolWindow.Click
        frmForm2.FormBorderStyle = 5
        frmForm2.Text = fbsFormBorderStyle(5) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnSizableToolWindow_Click(sender As Object, e As EventArgs) Handles btnSizableToolWindow.Click
        frmForm2.FormBorderStyle = 6
        frmForm2.Text = fbsFormBorderStyle(6) & " 테두리 유형"
        frmForm2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
