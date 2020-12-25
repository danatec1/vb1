Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ' 데이터베이스 연결하기
        OleDbCon.Open()

        txtVer.Text = OleDbCon.ServerVersion ' DB 버젼 정보
        txtDb.Text = OleDbCon.Provider       ' DB 공급자정보
        txtStatus.Text = OleDbCon.State      ' DB 상태정보
    End Sub

    Private Sub btnCon_Click(sender As Object, e As EventArgs) _
        Handles btnCon.Click
        ' 데이터베이스 연결하기
        OleDbCon.Open()

        txtVer.Text = OleDbCon.ServerVersion ' DB 버젼 정보
        txtDb.Text = OleDbCon.Provider       ' DB 공급자정보
        txtStatus.Text = OleDbCon.State      ' DB 상태정보
    End Sub

    Private Sub btnDisCon_Click(sender As Object, e As EventArgs) _
        Handles btnDisCon.Click
        ' 데이터베이스 연결 끊기
        OleDbCon.Close()

        txtVer.Text = ""     ' DB 버젼 정보 Clear
        txtDb.Text = ""      ' DB 공급자정보 Clear
        txtStatus.Text = ""  ' DB 상태정보 Clear
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
        Handles btnExit.Click
        End
    End Sub
End Class
