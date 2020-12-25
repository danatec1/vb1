Public Class frmMain

    Private Sub 주소록BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 주소록BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.주소록BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.회원DataSet)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 '회원DataSet.주소록' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
        Me.주소록TableAdapter.Fill(Me.회원DataSet.주소록)

    End Sub
End Class
