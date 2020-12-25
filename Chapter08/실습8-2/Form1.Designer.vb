<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVolumeLabel = New System.Windows.Forms.Label()
        Me.lblLabelVolume = New System.Windows.Forms.Label()
        Me.lblTotalFreeSpace = New System.Windows.Forms.Label()
        Me.lblLabelTotal = New System.Windows.Forms.Label()
        Me.lblRootDirectory = New System.Windows.Forms.Label()
        Me.lblLabelRoot = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLabelName = New System.Windows.Forms.Label()
        Me.lblIsReady = New System.Windows.Forms.Label()
        Me.lblLabelIsReady = New System.Windows.Forms.Label()
        Me.lblDriveType = New System.Windows.Forms.Label()
        Me.lblLabelDrivetype = New System.Windows.Forms.Label()
        Me.lblDriveFormat = New System.Windows.Forms.Label()
        Me.lblLabelDrive = New System.Windows.Forms.Label()
        Me.lblAvailableFreeSpace = New System.Windows.Forms.Label()
        Me.lblLabelAvaliable = New System.Windows.Forms.Label()
        Me.lstDrives = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblVolumeLabel
        '
        Me.lblVolumeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVolumeLabel.Location = New System.Drawing.Point(274, 99)
        Me.lblVolumeLabel.Name = "lblVolumeLabel"
        Me.lblVolumeLabel.Size = New System.Drawing.Size(266, 21)
        Me.lblVolumeLabel.TabIndex = 67
        '
        'lblLabelVolume
        '
        Me.lblLabelVolume.AutoSize = True
        Me.lblLabelVolume.Location = New System.Drawing.Point(144, 105)
        Me.lblLabelVolume.Name = "lblLabelVolume"
        Me.lblLabelVolume.Size = New System.Drawing.Size(83, 12)
        Me.lblLabelVolume.TabIndex = 66
        Me.lblLabelVolume.Text = "Volume Label"
        '
        'lblTotalFreeSpace
        '
        Me.lblTotalFreeSpace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFreeSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFreeSpace.Location = New System.Drawing.Point(274, 165)
        Me.lblTotalFreeSpace.Name = "lblTotalFreeSpace"
        Me.lblTotalFreeSpace.Size = New System.Drawing.Size(266, 21)
        Me.lblTotalFreeSpace.TabIndex = 65
        '
        'lblLabelTotal
        '
        Me.lblLabelTotal.AutoSize = True
        Me.lblLabelTotal.Location = New System.Drawing.Point(143, 171)
        Me.lblLabelTotal.Name = "lblLabelTotal"
        Me.lblLabelTotal.Size = New System.Drawing.Size(102, 12)
        Me.lblLabelTotal.TabIndex = 64
        Me.lblLabelTotal.Text = "Total Free Space"
        '
        'lblRootDirectory
        '
        Me.lblRootDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRootDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRootDirectory.Location = New System.Drawing.Point(274, 77)
        Me.lblRootDirectory.Name = "lblRootDirectory"
        Me.lblRootDirectory.Size = New System.Drawing.Size(266, 21)
        Me.lblRootDirectory.TabIndex = 63
        '
        'lblLabelRoot
        '
        Me.lblLabelRoot.AutoSize = True
        Me.lblLabelRoot.Location = New System.Drawing.Point(145, 83)
        Me.lblLabelRoot.Name = "lblLabelRoot"
        Me.lblLabelRoot.Size = New System.Drawing.Size(84, 12)
        Me.lblLabelRoot.TabIndex = 62
        Me.lblLabelRoot.Text = "Root Directory"
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(274, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(266, 21)
        Me.lblName.TabIndex = 61
        '
        'lblLabelName
        '
        Me.lblLabelName.AutoSize = True
        Me.lblLabelName.Location = New System.Drawing.Point(142, 16)
        Me.lblLabelName.Name = "lblLabelName"
        Me.lblLabelName.Size = New System.Drawing.Size(39, 12)
        Me.lblLabelName.TabIndex = 60
        Me.lblLabelName.Text = "Name"
        '
        'lblIsReady
        '
        Me.lblIsReady.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIsReady.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIsReady.Location = New System.Drawing.Point(274, 32)
        Me.lblIsReady.Name = "lblIsReady"
        Me.lblIsReady.Size = New System.Drawing.Size(266, 21)
        Me.lblIsReady.TabIndex = 59
        '
        'lblLabelIsReady
        '
        Me.lblLabelIsReady.AutoSize = True
        Me.lblLabelIsReady.Location = New System.Drawing.Point(142, 38)
        Me.lblLabelIsReady.Name = "lblLabelIsReady"
        Me.lblLabelIsReady.Size = New System.Drawing.Size(55, 12)
        Me.lblLabelIsReady.TabIndex = 58
        Me.lblLabelIsReady.Text = "Is Ready"
        '
        'lblDriveType
        '
        Me.lblDriveType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDriveType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDriveType.Location = New System.Drawing.Point(274, 55)
        Me.lblDriveType.Name = "lblDriveType"
        Me.lblDriveType.Size = New System.Drawing.Size(266, 21)
        Me.lblDriveType.TabIndex = 57
        '
        'lblLabelDrivetype
        '
        Me.lblLabelDrivetype.AutoSize = True
        Me.lblLabelDrivetype.Location = New System.Drawing.Point(143, 61)
        Me.lblLabelDrivetype.Name = "lblLabelDrivetype"
        Me.lblLabelDrivetype.Size = New System.Drawing.Size(66, 12)
        Me.lblLabelDrivetype.TabIndex = 56
        Me.lblLabelDrivetype.Text = "Drive Type"
        '
        'lblDriveFormat
        '
        Me.lblDriveFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDriveFormat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDriveFormat.Location = New System.Drawing.Point(274, 121)
        Me.lblDriveFormat.Name = "lblDriveFormat"
        Me.lblDriveFormat.Size = New System.Drawing.Size(266, 21)
        Me.lblDriveFormat.TabIndex = 55
        '
        'lblLabelDrive
        '
        Me.lblLabelDrive.AutoSize = True
        Me.lblLabelDrive.Location = New System.Drawing.Point(145, 126)
        Me.lblLabelDrive.Name = "lblLabelDrive"
        Me.lblLabelDrive.Size = New System.Drawing.Size(76, 12)
        Me.lblLabelDrive.TabIndex = 54
        Me.lblLabelDrive.Text = "Drive Format"
        '
        'lblAvailableFreeSpace
        '
        Me.lblAvailableFreeSpace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvailableFreeSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvailableFreeSpace.Location = New System.Drawing.Point(274, 143)
        Me.lblAvailableFreeSpace.Name = "lblAvailableFreeSpace"
        Me.lblAvailableFreeSpace.Size = New System.Drawing.Size(266, 21)
        Me.lblAvailableFreeSpace.TabIndex = 53
        '
        'lblLabelAvaliable
        '
        Me.lblLabelAvaliable.AutoSize = True
        Me.lblLabelAvaliable.Location = New System.Drawing.Point(143, 149)
        Me.lblLabelAvaliable.Name = "lblLabelAvaliable"
        Me.lblLabelAvaliable.Size = New System.Drawing.Size(125, 12)
        Me.lblLabelAvaliable.TabIndex = 52
        Me.lblLabelAvaliable.Text = "Available Free Space"
        '
        'lstDrives
        '
        Me.lstDrives.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstDrives.FormattingEnabled = True
        Me.lstDrives.ItemHeight = 12
        Me.lstDrives.Location = New System.Drawing.Point(0, 0)
        Me.lstDrives.Name = "lstDrives"
        Me.lstDrives.Size = New System.Drawing.Size(117, 262)
        Me.lstDrives.TabIndex = 51
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 262)
        Me.Controls.Add(Me.lblVolumeLabel)
        Me.Controls.Add(Me.lblLabelVolume)
        Me.Controls.Add(Me.lblTotalFreeSpace)
        Me.Controls.Add(Me.lblLabelTotal)
        Me.Controls.Add(Me.lblRootDirectory)
        Me.Controls.Add(Me.lblLabelRoot)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblLabelName)
        Me.Controls.Add(Me.lblIsReady)
        Me.Controls.Add(Me.lblLabelIsReady)
        Me.Controls.Add(Me.lblDriveType)
        Me.Controls.Add(Me.lblLabelDrivetype)
        Me.Controls.Add(Me.lblDriveFormat)
        Me.Controls.Add(Me.lblLabelDrive)
        Me.Controls.Add(Me.lblAvailableFreeSpace)
        Me.Controls.Add(Me.lblLabelAvaliable)
        Me.Controls.Add(Me.lstDrives)
        Me.Name = "frmMain"
        Me.Text = "DriveInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVolumeLabel As System.Windows.Forms.Label
    Friend WithEvents lblLabelVolume As System.Windows.Forms.Label
    Friend WithEvents lblTotalFreeSpace As System.Windows.Forms.Label
    Friend WithEvents lblLabelTotal As System.Windows.Forms.Label
    Friend WithEvents lblRootDirectory As System.Windows.Forms.Label
    Friend WithEvents lblLabelRoot As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLabelName As System.Windows.Forms.Label
    Friend WithEvents lblIsReady As System.Windows.Forms.Label
    Friend WithEvents lblLabelIsReady As System.Windows.Forms.Label
    Friend WithEvents lblDriveType As System.Windows.Forms.Label
    Friend WithEvents lblLabelDrivetype As System.Windows.Forms.Label
    Friend WithEvents lblDriveFormat As System.Windows.Forms.Label
    Friend WithEvents lblLabelDrive As System.Windows.Forms.Label
    Friend WithEvents lblAvailableFreeSpace As System.Windows.Forms.Label
    Friend WithEvents lblLabelAvaliable As System.Windows.Forms.Label
    Friend WithEvents lstDrives As System.Windows.Forms.ListBox

End Class
