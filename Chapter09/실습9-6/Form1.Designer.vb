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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.회원DataSet = New 실습9_6.회원DataSet()
        Me.주소록BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.주소록TableAdapter = New 실습9_6.회원DataSetTableAdapters.주소록TableAdapter()
        Me.주민번호DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.이름DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.주소DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.나이DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.회원DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.주소록BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.주민번호DataGridViewTextBoxColumn, Me.이름DataGridViewTextBoxColumn, Me.주소DataGridViewTextBoxColumn, Me.나이DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.주소록BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(409, 228)
        Me.DataGridView1.TabIndex = 0
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
        '주민번호DataGridViewTextBoxColumn
        '
        Me.주민번호DataGridViewTextBoxColumn.DataPropertyName = "주민번호"
        Me.주민번호DataGridViewTextBoxColumn.HeaderText = "주민번호"
        Me.주민번호DataGridViewTextBoxColumn.Name = "주민번호DataGridViewTextBoxColumn"
        '
        '이름DataGridViewTextBoxColumn
        '
        Me.이름DataGridViewTextBoxColumn.DataPropertyName = "이름"
        Me.이름DataGridViewTextBoxColumn.HeaderText = "이름"
        Me.이름DataGridViewTextBoxColumn.Name = "이름DataGridViewTextBoxColumn"
        '
        '주소DataGridViewTextBoxColumn
        '
        Me.주소DataGridViewTextBoxColumn.DataPropertyName = "주소"
        Me.주소DataGridViewTextBoxColumn.HeaderText = "주소"
        Me.주소DataGridViewTextBoxColumn.Name = "주소DataGridViewTextBoxColumn"
        '
        '나이DataGridViewTextBoxColumn
        '
        Me.나이DataGridViewTextBoxColumn.DataPropertyName = "나이"
        Me.나이DataGridViewTextBoxColumn.HeaderText = "나이"
        Me.나이DataGridViewTextBoxColumn.Name = "나이DataGridViewTextBoxColumn"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMain"
        Me.Text = "DataGridView 실습"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.회원DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.주소록BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents 회원DataSet As 실습9_6.회원DataSet
    Friend WithEvents 주소록BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 주소록TableAdapter As 실습9_6.회원DataSetTableAdapters.주소록TableAdapter
    Friend WithEvents 주민번호DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 이름DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 주소DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 나이DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
