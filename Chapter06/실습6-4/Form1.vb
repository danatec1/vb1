Public Class frmMain

    Private Sub frmMain_Load(sender As Object, _
                e As EventArgs) Handles MyBase.Load
        pgbarSort.Minimum = 0    '프로그래스바 Min값 설정
        pgbarSort.Maximum = 100  '프로그래스바 Max값 설정
        pgbarSort.Step = 10      '프로그래스바 Step값 설정
    End Sub

    Private Sub btnSort_Click(sender As Object, _
                e As EventArgs) Handles btnSort.Click
        Dim i, j, k, tmp As Integer
        Dim sNUM() As Integer = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
        rtxtSort.Text = " ----- SORT Start ----- "
        '오름 차수 정렬을 한다.
        For i = 0 To 9
            For j = i + 1 To 9
                If sNUM(i) > sNUM(j) Then
                    tmp = sNUM(i)
                    sNUM(i) = sNUM(j)
                    sNUM(j) = tmp
                End If
            Next
            '현재 Sort하기 위해 회전 한 횟수 및 결과 값을 보여준다.
            rtxtSort.Text = rtxtSort.Text + vbCrLf _
                          + Str(i + 1) + "회전 : "
            For k = 0 To 9
                rtxtSort.Text += Str(sNUM(k))
            Next k

            '프로그래스바 증가
            pgbarSort.Increment(10)
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
