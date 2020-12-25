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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("USB", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CDROM", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("내컴퓨터", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("휴지통", 3)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("네트워크", 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lboxChoose = New System.Windows.Forms.ListBox()
        Me.lvMain = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lboxChoose
        '
        Me.lboxChoose.FormattingEnabled = True
        Me.lboxChoose.ItemHeight = 15
        Me.lboxChoose.Items.AddRange(New Object() {"큰아이콘", "작은아이콘", "간단히 ", "자세히"})
        Me.lboxChoose.Location = New System.Drawing.Point(26, 56)
        Me.lboxChoose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lboxChoose.Name = "lboxChoose"
        Me.lboxChoose.Size = New System.Drawing.Size(157, 169)
        Me.lboxChoose.TabIndex = 0
        '
        'lvMain
        '
        Me.lvMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvMain.HideSelection = False
        Me.lvMain.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.lvMain.LargeImageList = Me.ImageList1
        Me.lvMain.Location = New System.Drawing.Point(207, 59)
        Me.lvMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvMain.Name = "lvMain"
        Me.lvMain.Size = New System.Drawing.Size(250, 254)
        Me.lvMain.SmallImageList = Me.ImageList1
        Me.lvMain.TabIndex = 1
        Me.lvMain.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "이미지"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "설명"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "USB.BMP")
        Me.ImageList1.Images.SetKeyName(1, "CDDRIVE.BMP")
        Me.ImageList1.Images.SetKeyName(2, "MYCOMP.BMP")
        Me.ImageList1.Images.SetKeyName(3, "WASTE.BMP")
        Me.ImageList1.Images.SetKeyName(4, "NETWORK.BMP")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(69, 272)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lvMain)
        Me.Controls.Add(Me.lboxChoose)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "ListView 연습"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lboxChoose As System.Windows.Forms.ListBox
    Friend WithEvents lvMain As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
