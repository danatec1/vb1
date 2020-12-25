Public Class frmMain

    Private Sub btnL2r_Click(sender As Object, e As EventArgs) _
          Handles btnL2r.Click
        '왼쪽 선택 리스트 박스에서 선택된 항목을 
        '오른쪽 선택 리스트 항목에 추가한다.
        Dim i, k, cnt As Integer
        cnt = clbLeft.Items.Count

        k = 0
        For i = 1 To cnt
            If clbLeft.GetItemChecked(k) Then
                clbRight.Items.Add(clbLeft.Items.Item(k))
                clbLeft.Items.RemoveAt(k)
                cnt -= 1
            Else
                k += 1
            End If
        Next
    End Sub

    Private Sub btnR2l_Click(sender As Object, e As EventArgs) _
           Handles btnR2l.Click
        '오른쪽 선택 리스트 박스에서 선택된 항목을 
        '왼쪽 선택 리스트 항목에 추가한다.
        Dim i, k, cnt As Integer
        cnt = clbRight.Items.Count

        k = 0
        For i = 1 To cnt
            If clbRight.GetItemChecked(k) = True Then
                clbLeft.Items.Add(clbRight.Items.Item(k))
                clbRight.Items.RemoveAt(k)
                cnt -= 1
            Else
                k += 1
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
           Handles btnExit.Click
        End
    End Sub
End Class
