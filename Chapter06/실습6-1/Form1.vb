Public Class frmMain

    Private Sub lboxChoose_SelectedIndexChanged(sender As Object, _
                e As EventArgs) Handles lboxChoose.SelectedIndexChanged
        'ListBox의 선택 인덱스에 따른 ListView 항목 설정
        If lboxChoose.SelectedIndex = 0 Then '큰 아이콘
            lvMain.LargeImageList = ImageList1
            lvMain.View = View.LargeIcon
        ElseIf lboxChoose.SelectedIndex = 1 Then '작은 아이콘
            lvMain.SmallImageList = ImageList1
            lvMain.View = View.SmallIcon
        ElseIf lboxChoose.SelectedIndex = 2 Then '간단히
            lvMain.SmallImageList = ImageList1
            lvMain.View = View.List
        ElseIf lboxChoose.SelectedIndex = 3 Then '자세히
            lvMain.SmallImageList = ImageList1
            lvMain.View = View.Details
        End If
    End Sub

    Private Sub lvMain_SelectedIndexChanged(sender As Object, _
                e As EventArgs) Handles lvMain.SelectedIndexChanged
        Dim i As Integer

        For i = 0 To lvMain.Items.Count - 1
            If lvMain.Items(i).Selected = True Then
                MsgBox(lvMain.Items(i).Text, _
                MsgBoxStyle.Information, "확인")
                Exit For
            End If
        Next
    End Sub

    Private Sub frmMain_Load(sender As Object, _
                e As EventArgs) Handles MyBase.Load
        '리스트 박스의 선택을 인덱스 0으로 Setting 한다.
        lboxChoose.SelectedIndex = 0
        lvMain.LargeImageList = ImageList1
        lvMain.View = View.LargeIcon
    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
