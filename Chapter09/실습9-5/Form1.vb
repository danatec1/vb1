Public Class frmMain

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) _
        Handles btnSelect.Click
        Dim myReader As OleDb.OleDbDataReader

        ' 컬렉션에 있는 모든 내용을 지운다.
        lbRegnNo.Items.Clear()

        ' 데이터베이스에 연결한다.
        OleDbCon.Open()
        OleDbCmd.Connection = OleDbCon
        ' 조회하고자 하는 SQL 문장 작성 후 Reader 객체에 할당한다.
        OleDbCmd.CommandText = "Select 주민번호 from 주소록"
        myReader = OleDbCmd.ExecuteReader()

        ' 데이터를 읽어서 자료값이 없을때가지 ListBox에 추가한다.
        While (myReader.Read())
            lbRegnNo.Items.Add(myReader.GetString(0))
        End While

        'reader 객체를 닫는다.
        myReader.Close()

        ' 데이터베이스 연결을 종료한다.
        OleDbCon.Close()
    End Sub

    Private Sub lbRegnNo_SelectedIndexChanged(sender As Object, _
                e As EventArgs) Handles lbRegnNo.SelectedIndexChanged
        Dim myReader As OleDb.OleDbDataReader

        ' 텍스트 박스의 내용을 지운다.
        txtRegNo.Text = "" ' 주민번호
        txtName.Text = ""  ' 이름
        txtAddr.Text = ""  ' 주소
        txtAge.Text = ""   ' 나이

        ' 데이터베이스에 연결한다.
        OleDbCon.Open()

        ' w조회하고자하는 SQL 문장 작성 후 Reader 객체에 할당한다.
        OleDbCmd.CommandText = "Select 주민번호, 이름, 주소, 나이 " _
                             & " from 주소록 where 주민번호 = '" _
                             & lbRegnNo.SelectedItem() & "' "
        myReader = OleDbCmd.ExecuteReader()

        ' 데이터를 읽어서 자료값이 없을때까지 ListBox에 추가한다.
        While (myReader.Read())
            txtRegNo.Text = myReader.GetString(0)         ' 주민번호
            txtName.Text = myReader.GetString(1)          ' 이름
            txtAddr.Text = myReader.GetString(2)          ' 주소
            txtAge.Text = myReader.GetInt32(3).ToString() ' 나이
        End While

        'reader 객체를 닫는다.
        myReader.Close()

        ' 데이터베이스 연결을 종료한다.
        OleDbCon.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
        Handles btnExit.Click
        End
    End Sub
End Class
