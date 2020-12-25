Public Class frmMain
    '변수와 개체의 선언
    Private strFileName As String
    Private strPrintRecord As String

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) _
        Handles btnOpen.Click
        'Open Dialog 속성의 설정
        With OpenFileDialog1
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
            '필터의 설정(기본은 txt 또는 모든 파일 지정)
            .FilterIndex = 1
            .Title = "Demo Open File Dialog"
        End With

        'Open 버튼을 클릭할 경우 open 다이얼로그가 나타남
        If OpenFileDialog1.ShowDialog =
               Windows.Forms.DialogResult.OK Then
            Try
                '경로와 파일 이름을 저장
                strFileName = OpenFileDialog1.FileName

                Dim fileContents As String
                fileContents =
                    My.Computer.FileSystem.ReadAllText(strFileName)

                '텍스트 박스에 파일 내용을 출력
                txtFile.Text = fileContents

            Catch ex As Exception '예외가 발생할 경우 메시지 출력
                MessageBox.Show(ex.Message, My.Application.Info.Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save Dialog 속성의 설정
        With SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strFileName
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Demo Save File Dialog"
        End With

        'Save 버튼을 클릭할 경우 save 다이얼로그가 나타남
        If SaveFileDialog1.ShowDialog =
          Windows.Forms.DialogResult.OK Then
            Try
                '경로와 이름을 저장
                strFileName = SaveFileDialog1.FileName
                My.Computer.FileSystem.WriteAllText(strFileName, txtFile.Text, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        'Font dialog 속성 지정
        FontDialog1.ShowColor = True

        '[확인] 버튼 클릭 시 Font 다이얼로그 보여줌
        '텍스트 박스에 폰트와 컬러를 수정
        If FontDialog1.ShowDialog =
           Windows.Forms.DialogResult.OK Then
            txtFile.Font = FontDialog1.Font
            txtFile.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        '[확인] 버튼 클릭 시 Font 다이얼로그 보여줌
        '폼에 배경색을 수정
        If ColorDialog1.ShowDialog =
            Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

End Class
