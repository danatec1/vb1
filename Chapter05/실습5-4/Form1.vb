Public Class frmMain
    Dim argFilename As String         ' 파일명 보관 변수
    Dim strModify As Boolean = False ' 변경 여부 
    Dim fileOpen As Boolean = False  ' 파일 Open 여부

    Private Sub 열기OToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 열기OToolStripMenuItem.Click
        Dim readFile As IO.StreamReader

        '열기 다이알로그 환경 설정
        OpenFileDialog1.Title = "파일 읽어오기"
        OpenFileDialog1.InitialDirectory = "c: \"
        OpenFileDialog1.Filter = "모든 파일(TXT, RTF) | *.TXT;*.RTF"
        '정상 Ok이면
        If OpenFileDialog1.ShowDialog = _
           Windows.Forms.DialogResult.OK Then
            argFilename = OpenFileDialog1.FileName
            lblStat.Text = "파일명 :" & argFilename
            readFile = New  _
               IO.StreamReader(OpenFileDialog1.FileName, _
                          System.Text.Encoding.Default)
            fileOpen = True ' 파일 Open 여부 설정
            rtxMemo.Text = readFile.ReadToEnd  ' 파일 읽기
            readFile.Close()    ' 파일 I/O 닫기
            readFile = Nothing  ' 메모리 해제
        End If
    End Sub

    Private Sub 저장SToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 저장SToolStripMenuItem.Click
        Dim writeFile As IO.StreamWriter

        '신규 파일인 경우 파일명 확인 후 저장
        If Trim(argFilename) = "" Then
            '저장 다이알로그 설정
            SaveFileDialog1.Title = "파일 저장하기"
            SaveFileDialog1.InitialDirectory = "c: \"
            SaveFileDialog1.FileName = argFilename
            SaveFileDialog1.Filter = "모든 파일(TXT, RTF) | .TXT;*.RTF"
            '정상 OK 이면
            If SaveFileDialog1.ShowDialog _
                 = Windows.Forms.DialogResult.OK Then
                argFilename = SaveFileDialog1.FileName
                lblStat.Text = "파일명 :" & argFilename
                writeFile = New  _
                IO.StreamWriter(SaveFileDialog1.FileName, False, _
                               System.Text.Encoding.Default)
                writeFile.Write(rtxMemo.Text)  ' 파일저장
                writeFile.Close()                 ' 파일 I/O 닫기
                writeFile = Nothing               ' 메모리 해제
                strModify = False                 ' 변경 여부 해제
            End If
        Else '기존 파일인 경우 무조건 저장
            writeFile = New IO.StreamWriter(argFilename, False, _
                        System.Text.Encoding.Default)
            writeFile.Write(rtxMemo.Text)  ' 파일저장
            writeFile.Close()               ' 파일 I/O 닫기
            writeFile = Nothing             ' 메모리 해제
            strModify = False               ' 변경 여부 해제
        End If
    End Sub

    Private Sub 다른이름으로저장AToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 다른이름으로저장AToolStripMenuItem.Click
        Dim writeFile As IO.StreamWriter

        '저장 다이알로그 환경 설정
        SaveFileDialog1.Title = "다른 이름으로 저장하기"
        SaveFileDialog1.InitialDirectory = "c: \"
        SaveFileDialog1.FileName = argFilename
        SaveFileDialog1.Filter = "모든 파일(TXT, RTF) | *.TXT;*.RTF"
        '정상 Ok이면
        If SaveFileDialog1.ShowDialog = _
               Windows.Forms.DialogResult.OK Then
            argFilename = SaveFileDialog1.FileName
            lblStat.Text = "파일명 :" & argFilename
            writeFile = New  _
            IO.StreamWriter(SaveFileDialog1.FileName, False, _
                            System.Text.Encoding.Default)
            writeFile.Write(rtxMemo.Text) ' 메모장을 저장한다.
            writeFile.Close()              ' 파일 I/O를 닫는다.
            writeFile = Nothing            ' 메모리 해제
            strModify = False              ' 변경 여부 해지
        End If
    End Sub

    Private Sub 페이지설정UToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 페이지설정UToolStripMenuItem.Click
        '상태 바에 메시지를 보여준다
        lblStat.Text = "페이지 설정 메뉴를 선택하였습니다."
    End Sub

    Private Sub 인쇄PToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 인쇄PToolStripMenuItem.Click
        '상태바에 메시지를 보여준다
        lblStat.Text = "인쇄 메뉴를 선택 하셨습니다."
    End Sub

    Private Sub 끝내기XToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 끝내기XToolStripMenuItem.Click
        Dim ans As Integer '메시지 결과값 저장할 정수형 변수

        '메모장에 변경 사항이 있으면
        If strModify = True Then
            ans = MsgBox("저장하지 않고 종료 하시겠습니까?", _
                         MsgBoxStyle.OkCancel, "종료")
            If ans = MsgBoxResult.Cancel Then  '취소 버튼 선택 시
                Exit Sub
            ElseIf ans = MsgBoxResult.Ok Then  '확인 버튼 선택 시
                End
            End If
        Else '메모장에 변경 사항이 없으면
            End
        End If
    End Sub

    Private Sub 메모장정보AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 메모장정보AToolStripMenuItem.Click
        '상태 바에 메시지를 보여준다
        lblStat.Text = "메모장 정보 메뉴를 선택하셨습니다."
    End Sub
    Private Sub rtxMemo_TextChanged(sender As System.Object, _
                 e As System.EventArgs)
        '파일 Open에 따른 변경이 아닌 경우
        If fileOpen = False Then
            strModify = True  '수정 여부를 True로
        Else  '파일 Open에 따른 변경인 경우
            strModify = False '수정 여부를 False로
            fileOpen = False  '파일 open 여부를 해지
        End If
    End Sub

    Private Sub 파일FToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                Handles 파일FToolStripMenuItem.Click

    End Sub
End Class
