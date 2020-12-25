Imports System.IO

Public Class frmMain
    Private Sub frmMain_Load() Handles MyBase.Load
        For Each drive_info As DriveInfo In DriveInfo.GetDrives()
            lstDrives.Items.Add(drive_info.Name)
        Next drive_info
    End Sub

    Private Sub lstDrives_SelectedIndexChanged() Handles _
        lstDrives.SelectedIndexChanged
        For Each ctl As Control In Me.Controls
            If (ctl.Name.StartsWith("lbl")) AndAlso _
                (TypeOf ctl Is Label) Then
                Dim lbl As Label = DirectCast(ctl, Label)
            End If
        Next ctl

        Dim drive_info As New DriveInfo(lstDrives.Text)
        lblName.Text = drive_info.Name()
        lblIsReady.Text = drive_info.IsReady().ToString
        lblDriveType.Text = drive_info.DriveType().ToString
        lblRootDirectory.Text = drive_info.RootDirectory.ToString
        If drive_info.IsReady() Then
            lblAvailableFreeSpace.Text = _
                drive_info.AvailableFreeSpace().ToString
            lblDriveFormat.Text = drive_info.DriveFormat()
            lblTotalFreeSpace.Text = _
                FormatBytes(drive_info.TotalFreeSpace, "0.00")
            lblVolumeLabel.Text = drive_info.VolumeLabel()
        End If
    End Sub

    ' Format a disk size in bytes as KB, MB, GB, etc.
    Private Function FormatBytes(num_bytes As Double, _
                                 format_str As String) As String
        Dim postfixes() As String = _
            {"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        For i As Integer = postfixes.Length - 1 To 0 Step -1
            If num_bytes > 1024 ^ i Then
                num_bytes /= 1024 ^ i
                Return num_bytes.ToString(format_str) & _
                            " " & postfixes(i)
            End If
        Next i

        Return num_bytes.ToString(format_str) & " Bytes"
    End Function
End Class