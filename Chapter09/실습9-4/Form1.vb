Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e _
              As System.EventArgs) Handles MyBase.Load
        ' 데이터베이스 연결하기
        OleDbCon.Open() ' 데이터베이스 객체 설정하기
        OleDbCmd.Connection = OleDbCon
    End Sub

    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e _
                 As System.EventArgs) Handles MyBase.Closed

        ' 데이터베이스 연결 끊기
        OleDbCon.Close()
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e _
                As System.EventArgs) Handles btnInput.Click
        Dim iResult As Integer = 0

        ' 데이터 등록 문장 만들기
        OleDbCmd.CommandText = "Insert Into 주소록 (주민번호, 이름, " _
                              & "주소, 나이) Values ( " _
                              & " '" & txtRegNo.Text & "',  " _
                              & " '" & txtName.Text & "',  " _
                              & " '" & txtAddr.Text & "',  " _
                              & txtAge.Text & " )"

        ' 입력된 결과 레코드 수 가져오기
        iResult = Val(OleDbCmd.ExecuteNonQuery().ToString())

        '메시지 출력
        MessageBox.Show(iResult & " 개의 레코드가 입력되었습니다")
    End Sub

End Class