Public Class frmMain
    Private Sub frmMain_Load(ByVal sender As System.Object, _
          ByVal e As System.EventArgs) Handles MyBase.Load
        txtNAME.Text = ""  '성명 초기화
        txtAGE.Text = ""   '나이 초기화

        txtNAME.Focus()    '커서의 위치를 정의한다.

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) _
        Handles btnOk.Click
        '콤보 박스에 입력한 값을 넣어준다.
        cbList.Items.Add(txtName.Text & _
              "                                  " & txtAge.Text)
        txtName.Text = ""  '성명 초기화
        txtAge.Text = ""   '나이 초기화

        txtName.Focus()    '커서의 위치를 정의한다.

    End Sub

    '삭제 버튼 클릭 이벤트 정의
    Private Sub btnDel_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnDel.Click
        cbList.Items.RemoveAt(cbList.SelectedIndex)
        txtName.Text = ""  '성명 초기화
        txtAge.Text = ""   '나이 초기화

        txtName.Focus()    '커서의 위치를 정의한다.
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
        Handles btnExit.Click
        End
    End Sub
End Class
