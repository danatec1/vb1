Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, _
                  ByVal e As EventArgs) Handles MyBase.Load
        txtStr.Text = ""        '문자열을 clear한다.
        lbxMain.Items.Clear()  '목록상자를 CLear한다.

        txtStr.Focus()          '커서의 위치를 설정한다.
    End Sub
    '추가 버튼 클릭 이벤트를 설정한다.
    Private Sub btnAdd_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnAdd.Click

        '추가하고자 하는 문자열이 존재하는지 확인 후 추가한다.
        If txtStr.Text.Trim <> "" Then
            lbxMain.Items.Add(txtStr.Text)

            txtStr.Text = "" '문자열을 clear한다.
            txtStr.Focus()   '커서의 위치를 설정한다.
        End If
    End Sub
    '선택 항목 삭제' 버튼 클릭 이벤트
    Private Sub btnDel_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnDel.Click
        Dim i As Integer

        '선택 항목이 존재하는지 확인한다.
        If lbxMain.SelectedIndex = -1 Then
            Exit Sub
        End If

        '등록된 항목 수만큼 반복하면서 선택 여부를 확인하고
        '선택된 항목이라면 해당 항목을 삭제한다.
        For i = lbxMain.Items.Count - 1 To 0 Step -1
            If lbxMain.GetSelected(i) = True Then
                lbxMain.Items.Remove(lbxMain.SelectedItem)
            End If
        Next i
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
