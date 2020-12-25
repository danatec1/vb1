Imports System.Security
Imports System.Security.Permissions

Public Class frmMain

    Private Sub btnWriteFile_Click(sender As Object, _
                e As EventArgs) Handles btnWriteFile.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, _
                e As EventArgs) Handles MyBase.Load
        Dim file_name As String = Application.StartupPath
        If file_name.EndsWith("\bin\Debug") Then file_name.Replace("\bin\Debug", "")
        txtFileName.Text = file_name & "\FileSave.txt"
    End Sub
    Private Sub btnWriteFile_Click() Handles btnWriteFile.Click
        System.IO.File.WriteAllText(txtFileName.Text, txtContents.Text)
        MessageBox.Show("파일저장", "Ok",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFileOpen_Click(sender As Object, _
                e As EventArgs) Handles btnFileOpen.Click
        ' 파일 번호 부여.
        Dim file_num As Integer = FreeFile()

        ' 파일 열기.
        Dim file_name As String = Application.StartupPath
        If file_name.EndsWith("\bin\Debug") Then
            file_name = file_name.Replace("\bin\Debug", "")
        End If
        file_name &= "\bin\Debug\FileSave.txt"
        FileOpen(file_num, file_name,
            OpenMode.Input, OpenAccess.Read, OpenShare.Shared)

        ' 파일의 내용 읽기
        Dim txt As String = ""
        Do While Not EOF(file_num)
            ' Read a line.
            txt &= LineInput(file_num) & vbCrLf & vbCrLf
        Loop
        MessageBox.Show(txt, "파일 내용",
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Close the file.
        FileClose(file_num)
    End Sub
End Class
