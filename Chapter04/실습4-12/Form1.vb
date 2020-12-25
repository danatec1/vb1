Public Class frmMain
    '폼 Load 시 컨트롤의 초기 값을 초기화한다.
    Private Sub frmMain_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        '직각 삼각형의 값을 True로 한다.
        rbtnTri.Checked = True
        '역 직각 삼각형의 값을 False로 한다.
        rbtnReTri.Checked = False

        lblResult.Text = ""       '레이블의 값을 초기화한다.
        btnOK.Focus()           '커서의 위치를 지정한다.
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) _
            Handles btnOk.Click
        Dim row, col, no As Integer
        Dim Str_Arr(10, 10) As Integer
        lblResult.Text = ""       'rtxtRST의 값을 초기화한다.

        '2차원 배열의 값을 0으로 초기화한다.
        For row = 0 To 9
            For col = 0 To 9
                Str_Arr(row, col) = 0
            Next
        Next

        no = 1 '배열에 넣어줄 값의 초기화
        '선택 메뉴가 직각 삼각형인 경우
        If rbtnTri.Checked = True Then
            For row = 0 To 9
                For col = 9 - row To 9
                    Str_Arr(row, col) = no
                    no += 1
                Next
            Next
        Else '선택 메뉴가 역 직각 삼각형인 경우
            For row = 0 To 9
                For col = 0 To row
                    Str_Arr(col, row) = no
                    no += 1
                Next
            Next
        End If

        'Setting된 배열의 값을 화면에 보여준다.
        For row = 0 To 9
            For col = 0 To 9
                If Str_Arr(row, col) = 0 Then
                    lblResult.Text &= "    "
                Else
                    lblResult.Text &= "    " & _
                            Format(Str_Arr(row, col), "00")
                End If
            Next
            lblResult.Text &= vbCrLf
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) _
           Handles btnExit.Click
        End
    End Sub
End Class
