Public Class frmMain

    Private Sub 파일ToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 파일ToolStripMenuItem.Click
        TextBox1.Text = "[파일] 메뉴가 선택되었습니다"
    End Sub

    Private Sub 새로만들기NToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 새로만들기NToolStripMenuItem.Click
        TextBox1.Text = "[새로 만들기]메뉴가 선택되었습니다"
    End Sub

    Private Sub 열기OToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 열기OToolStripMenuItem.Click
        TextBox1.Text = "[열기] 메뉴가 선택되었습니다"
    End Sub

    Private Sub 저장SToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 저장SToolStripMenuItem.Click
        TextBox1.Text = "[저장]메뉴가 선택되었습니다"
    End Sub

    Private Sub 다른이름으로저장AToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 다른이름으로저장AToolStripMenuItem.Click
        TextBox1.Text = "[다른 이름으로 저장]메뉴가 선택되었습니다"
    End Sub

    Private Sub 페이지설정UToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 페이지설정UToolStripMenuItem.Click
        TextBox1.Text = "[페이지 설정]메뉴가 선택되었습니다"
    End Sub

    Private Sub 인쇄PToolStripMenuItem_Click(sender As Object, e As EventArgs) _
               Handles 인쇄PToolStripMenuItem.Click
        TextBox1.Text = "[인쇄]메뉴가 선택되었습니다"
    End Sub

    Private Sub 끝내기XToolStripMenuItem_Click(sender As Object, e As EventArgs) _
               Handles 끝내기XToolStripMenuItem.Click
        End
    End Sub

    Private Sub 도움말ToolStripMenuItem_Click(sender As Object, e As EventArgs) _
              Handles 도움말ToolStripMenuItem.Click
        TextBox1.Text = "[도움말]메뉴가 선택되었습니다"
    End Sub

    Private Sub 메모장정보AToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles 메모장정보AToolStripMenuItem.Click
        TextBox1.Text = "[메모장 정보]메뉴가 선택되었습니다"
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
