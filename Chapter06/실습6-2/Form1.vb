Public Class frmMain
    Dim Select_node As Boolean = False '노드 선택 여부값을 위한 변수

    '종료 버튼 클릭 이벤트 정의
    Private Sub btnExit_Click(ByVal sender As System.Object,
             ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    '노드 추가 버튼 클릭 이벤트(부모노드 추가)
    Private Sub btnAdd_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnAdd.Click
        ' 추가하고자 하는 노드의 이름이 존재해야 만 한다.
        If Trim(txtName.Text) <> "" Then
            trvMain.Nodes.Add(txtName.Text)
        End If
    End Sub

    '선택 노드 삭제 이벤트 정의
    '노드가 존재하고 선택된 노드가 있어야만 가능하다.
    Private Sub btnDel_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnDel.Click
        ' 노드가 존재하고
        If trvMain.GetNodeCount(True) > 0 Then
            '선택 여부가 참이면
            If Select_node Then
                trvMain.Nodes.Remove(trvMain.SelectedNode)
            End If
        Else
            '노드가 존재하지 않으면 선택여부를 False로 정의한다.
            Select_node = False
        End If
    End Sub

    '자식노드 추가
    Private Sub btnApnd_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnApnd.Click
        '노드가 존재하고
        If trvMain.GetNodeCount(True) > 0 Then
            '노드가 선택되어잇다면
            If Select_node Then
                trvMain.SelectedNode.Nodes.Add(txtName.Text)
            End If
        Else
            '노드가 존재하지 않으면 선택여부를 False로 정의한다.
            Select_node = False
        End If
    End Sub

    '트리뷰에서 마우스 이벤트 즉, 선택 시 이벤트를 정의한다
    Private Sub trvMain_AfterSelect(ByVal sender As System.Object,
            ByVal e As System.Windows.Forms.TreeViewEventArgs) _
                       Handles trvMain.AfterSelect
        '선택여부를 참으로 한다
        If Select_node = False Then
            Select_node = True
        End If
    End Sub

End Class
