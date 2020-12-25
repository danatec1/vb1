Imports System.IO
Imports System.IO.File

Public Class frmMain
    Private Sub btnFileSave_Click(sender As Object, _
                e As EventArgs) Handles btnFileSave.Click
        Dim file_name As String = Application.StartupPath & "\Animals.txt"
        Using stream_writer As New StreamWriter(file_name)
            stream_writer.WriteLine(" 개")
            stream_writer.WriteLine(" 고양이.")
            stream_writer.WriteLine(" 사자")
            stream_writer.WriteLine(" 말")
            stream_writer.WriteLine(" 소")
            stream_writer.Close()
            MessageBox.Show("파일저장", "Ok",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub btnFileRead_Click(sender As Object, _
                e As EventArgs) Handles btnFileRead.Click
        '  파일 열기.
        Dim file_name As String = Application.StartupPath & "\Animals.txt"
        Dim stream_reader As StreamReader = OpenText(file_name)

        ' 파일의 끝까지 파일 읽기.
        Do Until stream_reader.EndOfStream()
            lstAnimals.Items.Add(stream_reader.ReadLine())
        Loop

        ' 파일 닫기.
        stream_reader.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, _
                e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
