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
        Dim 주민번호Label As System.Windows.Forms.Label
        Dim 이름Label As System.Windows.Forms.Label
        Dim 주소Label As System.Windows.Forms.Label
        Dim 나이Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.회원DataSet = New 실습9_7.회원DataSet()
        Me.주소록BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.주소록TableAdapter = New 실습9_7.회원DataSetTableAdapters.주소록TableAdapter()
        Me.TableAdapterManager = New 실습9_7.회원DataSetTableAdapters.TableAdapterManager()
        Me.주소록BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.주소록BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.주민번호TextBox = New System.Windows.Forms.TextBox()
        Me.이름TextBox = New System.Windows.Forms.TextBox()
        Me.주소TextBox = New System.Windows.Forms.TextBox()
        Me.나이TextBox = New System.Windows.Forms.TextBox()
        주민번호Label = New System.Windows.Forms.Label()
        이름Label = New System.Windows.Forms.Label()
        주소Label = New System.Windows.Forms.Label()
        나이Label = New System.Windows.Forms.Label()
        CType(Me.회원DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.주소록BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.주소록BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.주소록BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '주민번호Label
        '
        주민번호Label.AutoSize = True
        주민번호Label.Location = New System.Drawing.Point(64, 80)
        주민번호Label.Name = "주민번호Label"
        주민번호Label.Size = New System.Drawing.Size(72, 15)
        주민번호Label.TabIndex = 1
        주민번호Label.Text = "주민번호:"
        '
        '이름Label
        '
        이름Label.AutoSize = True
        이름Label.Location = New System.Drawing.Point(81, 145)
        이름Label.Name = "이름Label"
        이름Label.Size = New System.Drawing.Size(42, 15)
        이름Label.TabIndex = 3
        이름Label.Text = "이름:"
        '
        '주소Label
        '
        주소Label.AutoSize = True
        주소Label.Location = New System.Drawing.Point(81, 202)
        주소Label.Name = "주소Label"
        주소Label.Size = New System.Drawing.Size(42, 15)
        주소Label.TabIndex = 5
        주소Label.Text = "주소:"
        '
        '나이Label
        '
        나이Label.AutoSize = True
        나이Label.Location = New System.Drawing.Point(81, 265)
        나이Label.Name = "나이Label"
        나이Label.Size = New System.Drawing.Size(42, 15)
        나이Label.TabIndex = 7
        나이Label.Text = "나이:"
        '
        '회원DataSet
        '
        Me.회원DataSet.DataSetName = "회원DataSet"
        Me.회원DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '주소록BindingSource
        '
        Me.주소록BindingSource.DataMember = "주소록"
        Me.주소록BindingSource.DataSource = Me.회원DataSet
        '
        '주소록TableAdapter
        '
        Me.주소록TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 실습9_7.회원DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.주소록TableAdapter = Me.주소록TableAdapter
        '
        '주소록BindingNavigator
        '
        Me.주소록BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.주소록BindingNavigator.BindingSource = Me.주소록BindingSource
        Me.주소록BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.주소록BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.주소록BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.주소록BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.주소록BindingNavigatorSaveItem})
        Me.주소록BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.주소록BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.주소록BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.주소록BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.주소록BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.주소록BindingNavigator.Name = "주소록BindingNavigator"
        Me.주소록BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.주소록BindingNavigator.Size = New System.Drawing.Size(405, 27)
        Me.주소록BindingNavigator.TabIndex = 0
        Me.주소록BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "새로 추가"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 24)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "전체 항목 수"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "삭제"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "처음으로 이동"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "이전으로 이동"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "위치"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(57, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "현재 위치"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "다음으로 이동"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "마지막으로 이동"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        '주소록BindingNavigatorSaveItem
        '
        Me.주소록BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.주소록BindingNavigatorSaveItem.Image = CType(resources.GetObject("주소록BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.주소록BindingNavigatorSaveItem.Name = "주소록BindingNavigatorSaveItem"
        Me.주소록BindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.주소록BindingNavigatorSaveItem.Text = "데이터 저장"
        '
        '주민번호TextBox
        '
        Me.주민번호TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.주소록BindingSource, "주민번호", True))
        Me.주민번호TextBox.Location = New System.Drawing.Point(142, 80)
        Me.주민번호TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.주민번호TextBox.Name = "주민번호TextBox"
        Me.주민번호TextBox.Size = New System.Drawing.Size(114, 25)
        Me.주민번호TextBox.TabIndex = 2
        '
        '이름TextBox
        '
        Me.이름TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.주소록BindingSource, "이름", True))
        Me.이름TextBox.Location = New System.Drawing.Point(142, 141)
        Me.이름TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.이름TextBox.Name = "이름TextBox"
        Me.이름TextBox.Size = New System.Drawing.Size(114, 25)
        Me.이름TextBox.TabIndex = 4
        '
        '주소TextBox
        '
        Me.주소TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.주소록BindingSource, "주소", True))
        Me.주소TextBox.Location = New System.Drawing.Point(142, 199)
        Me.주소TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.주소TextBox.Name = "주소TextBox"
        Me.주소TextBox.Size = New System.Drawing.Size(114, 25)
        Me.주소TextBox.TabIndex = 6
        '
        '나이TextBox
        '
        Me.나이TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.주소록BindingSource, "나이", True))
        Me.나이TextBox.Location = New System.Drawing.Point(142, 261)
        Me.나이TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.나이TextBox.Name = "나이TextBox"
        Me.나이TextBox.Size = New System.Drawing.Size(114, 25)
        Me.나이TextBox.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 328)
        Me.Controls.Add(나이Label)
        Me.Controls.Add(Me.나이TextBox)
        Me.Controls.Add(주소Label)
        Me.Controls.Add(Me.주소TextBox)
        Me.Controls.Add(이름Label)
        Me.Controls.Add(Me.이름TextBox)
        Me.Controls.Add(주민번호Label)
        Me.Controls.Add(Me.주민번호TextBox)
        Me.Controls.Add(Me.주소록BindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "DataSet 실습"
        CType(Me.회원DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.주소록BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.주소록BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.주소록BindingNavigator.ResumeLayout(False)
        Me.주소록BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 회원DataSet As 실습9_7.회원DataSet
    Friend WithEvents 주소록BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 주소록TableAdapter As 실습9_7.회원DataSetTableAdapters.주소록TableAdapter
    Friend WithEvents TableAdapterManager As 실습9_7.회원DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 주소록BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 주소록BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents 주민번호TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 이름TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 주소TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 나이TextBox As System.Windows.Forms.TextBox

End Class
