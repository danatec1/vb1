Public Class frmMain

    'Form Load 시 이벤트 정의
    Private Sub frmMain_Load(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles MyBase.Load
        'DateTimePicker의 Format과 라벨 초기 값 지정
        DTPkrMain.Format = DateTimePickerFormat.Long
        lbDt.Text = DTPkrMain.Text
    End Sub

    '종료 버튼 클릭 이벤트를 정의한다.
    Private Sub btnExit_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'DateTimePicker 유형을 Long형으로 선택 시 이벤트 정의
    Private Sub rbtnLong_CheckedChanged(ByVal sender As  _
                System.Object, _
       ByVal e As System.EventArgs) Handles rbtnLONG.CheckedChanged

        If rbtnLONG.Checked = True Then   'Long형이 선택 된 경우
            DTPkrMain.Format = DateTimePickerFormat.Long
            lbDt.Text = DTPkrMain.Text
        End If

    End Sub

    'DateTimePicker 유형을 Short형으로 선택 시 이벤트 정의
    Private Sub rbtnSHORT_CheckedChanged(ByVal sender As  _
                System.Object, _
       ByVal e As System.EventArgs) Handles rbtnSHORT.CheckedChanged

        If rbtnSHORT.Checked = True Then   'Short형이 선택 된 경우
            DTPkrMain.Format = DateTimePickerFormat.Short
            lbDt.Text = DTPkrMain.Text
        End If

    End Sub

    'DateTimePicker 유형을 Custom형으로 선택 시 이벤트 정의
    Private Sub rbtnCUSTOM_CheckedChanged(ByVal sender As  _
                System.Object, _
       ByVal e As System.EventArgs) Handles rbtnCUSTOM.CheckedChanged

        If rbtnCUSTOM.Checked = True Then  'Custom형이 선택 된 경우
            DTPkrMain.Format = DateTimePickerFormat.Custom
            DTPkrMain.CustomFormat = "yyyy년 MM월 dd일 HH시 mm분 ss초"
            lbDT.Text = DTPkrMAIN.Text
        End If
    End Sub

    'DateTimePicker 컨트롤 변경 내용 존재 시 이벤트 정의
    Private Sub DTPkrMain_ValueChanged(ByVal sender As  _
                System.Object, _
        ByVal e As System.EventArgs) Handles DTPkrMain.ValueChanged

        lbDt.Text = DTPkrMain.Text

    End Sub
End Class
