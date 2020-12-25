Public Class frmMain
    '새로운 폼 생성 시마다 카운터를 위한 변수
    Dim FrmCount As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(sender As Object, _
        e As EventArgs) Handles ExitToolStripMenuItem.Click
        '메인 메뉴의 Exit 메뉴 클릭 이벤트 정의
        End
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender _
                As Object, e As EventArgs) _
                Handles CascadeToolStripMenuItem.Click
        '메인 메뉴의 [WIndows]-[Cascade] 메뉴 클릭 이벤트 정의
        '자식 창을 Cascade 정렬한다.
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender _
                As Object, e As EventArgs) _
                Handles TileVerticalToolStripMenuItem.Click
        '메인 메뉴의 [WIndows]-[TileVertical] 메뉴 클릭 이벤트 정의
        '자식 창을 TileVertical 정렬한다.
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles NewToolStripMenuItem.Click
        '메인 메뉴의 [File]-[New] 메뉴 클릭 이벤트 정의
        Dim NewMDIChild As New Form2   '폼을 생성

        NewMDIChild.MdiParent = Me   '자식 창의 부모 창을 설정해 준다.
        FrmCount += 1                'Form 생성 횟수의 증가
        NewMDIChild.Text = "NewForm(" & FrmCount & ")"
        NewMDIChild.Show()           '새로운 자식 창을 보여준다
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles CloseToolStripMenuItem.Click
        '메인 메뉴의 [File]-[Close] 메뉴 클릭 이벤트 정의
        Dim CurMDIChild As New Form2   '폼을 생성

        '현재 활성 중인 자식 창을 알아낸다.
        CurMDIChild = Me.ActiveMdiChild
        '활성 자식 창이 존재 하지 않는 경우
        If CurMDIChild Is Nothing Then
            Return
        Else ' 자식 창이 존재하는 경우
            CurMDIChild.Close()  '폼을 종료한다.
        End If
    End Sub

    Private Sub TileHolizontalToolStripMenuItem_Click(sender As _
                Object, e As EventArgs) Handles TileHolizontalToolStripMenuItem.Click
        '메인 메뉴의 [WIndows]-[TileHorizontal] 메뉴 클릭 이벤트 정의
        '자식 창을 TileHorizontal 정렬한다.
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
End Class