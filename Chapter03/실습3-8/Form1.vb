Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        TextBox1.Text =
            "<--- 산술 연산자 --->" & vbCrLf &
            "3 ＾ 4 = " & 3 ^ 4 & vbCrLf &
            "4 ＊ 6 = " & 4 * 6 & vbCrLf &
            "8 ／ 3 = " & 8 / 3 & vbCrLf &
            "8 \ 3 = " & 8 \ 3 & vbCrLf &
            "8 Mod 3 = " & 8 Mod 3 & vbCrLf &
            "2 ＋ 5 = " & 2 + 5 & vbCrLf &
            "5 － 3 = " & 5 - 3 & vbCrLf & vbCrLf &
            "<--- 논리 연산자 --->" & vbCrLf &
            "23 ＝ 25 : " & CStr(23 = 25) & vbCrLf &
            "24 <> 24 : " & CStr(24 <> 24) & vbCrLf &
            "31 > 33 : " & CStr(31 > 33) & vbCrLf &
            "11 >= 10 : " & CStr(11 >= 10) & vbCrLf &
            "9 < 15 : " & CStr(9 < 15) & vbCrLf &
            "21 <= 21 : " & CStr(21 <= 21) & vbCrLf &
            "Basic Like Basi : " _
            & CStr("Basic" Like "Basi") _
            & vbCrLf & vbCrLf &
            "<--- 연산자 우선순위 --->" & vbCrLf &
            " 4 * 3 ^ 6 / 3 - 1 = " & (4 * 3 ^ 6 / 3 - 1) _
            & vbCrLf &
            " 4 * 3 ^ 6 / (3 - 1) = " _
            & (4 * 3 ^ 6 / (3 - 1))
        TextBox1.Focus() '텍스트 박스에 커서를 위치
        TextBox1.SelectionStart = TextBox1.TextLength
        '텍스트의 마지막 줄로 커서 이동
    End Sub
End Class
