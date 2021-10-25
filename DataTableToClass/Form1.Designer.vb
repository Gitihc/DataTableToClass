<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_psd = New System.Windows.Forms.TextBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.rtb_JS = New System.Windows.Forms.RichTextBox()
        Me.btnEasyUI_JSTableColumn = New System.Windows.Forms.Button()
        Me.chk_selectAll = New System.Windows.Forms.CheckBox()
        Me.btn_Build = New System.Windows.Forms.Button()
        Me.cmb_listDatabaseName = New System.Windows.Forms.ComboBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.gb_ListTable = New System.Windows.Forms.GroupBox()
        Me.dgv_listTableName = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmb_TemplateList = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gb_ListTable.SuspendLayout()
        CType(Me.dgv_listTableName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(33, 44)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 21)
        Me.txt_name.TabIndex = 0
        Me.txt_name.Text = "sa"
        '
        'txt_psd
        '
        Me.txt_psd.Location = New System.Drawing.Point(33, 74)
        Me.txt_psd.Name = "txt_psd"
        Me.txt_psd.Size = New System.Drawing.Size(175, 21)
        Me.txt_psd.TabIndex = 1
        Me.txt_psd.Text = "hlcost168"
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(111, 107)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(97, 24)
        Me.btn_connect.TabIndex = 2
        Me.btn_connect.Text = "connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 616)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.listBox1)
        Me.TabPage1.Controls.Add(Me.rtb_JS)
        Me.TabPage1.Controls.Add(Me.btnEasyUI_JSTableColumn)
        Me.TabPage1.Controls.Add(Me.chk_selectAll)
        Me.TabPage1.Controls.Add(Me.btn_Build)
        Me.TabPage1.Controls.Add(Me.cmb_listDatabaseName)
        Me.TabPage1.Controls.Add(Me.txt_server)
        Me.TabPage1.Controls.Add(Me.gb_ListTable)
        Me.TabPage1.Controls.Add(Me.txt_name)
        Me.TabPage1.Controls.Add(Me.btn_connect)
        Me.TabPage1.Controls.Add(Me.txt_psd)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 590)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 12
        Me.listBox1.Location = New System.Drawing.Point(281, 16)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(171, 100)
        Me.listBox1.TabIndex = 14
        '
        'rtb_JS
        '
        Me.rtb_JS.Location = New System.Drawing.Point(760, 20)
        Me.rtb_JS.Name = "rtb_JS"
        Me.rtb_JS.Size = New System.Drawing.Size(781, 540)
        Me.rtb_JS.TabIndex = 13
        Me.rtb_JS.Text = ""
        '
        'btnEasyUI_JSTableColumn
        '
        Me.btnEasyUI_JSTableColumn.Location = New System.Drawing.Point(563, 177)
        Me.btnEasyUI_JSTableColumn.Name = "btnEasyUI_JSTableColumn"
        Me.btnEasyUI_JSTableColumn.Size = New System.Drawing.Size(148, 24)
        Me.btnEasyUI_JSTableColumn.TabIndex = 12
        Me.btnEasyUI_JSTableColumn.Text = "EasyUI_JSTableColumn"
        Me.btnEasyUI_JSTableColumn.UseVisualStyleBackColor = True
        '
        'chk_selectAll
        '
        Me.chk_selectAll.AutoSize = True
        Me.chk_selectAll.Location = New System.Drawing.Point(33, 177)
        Me.chk_selectAll.Name = "chk_selectAll"
        Me.chk_selectAll.Size = New System.Drawing.Size(78, 16)
        Me.chk_selectAll.TabIndex = 11
        Me.chk_selectAll.Text = "SelectAll"
        Me.chk_selectAll.UseVisualStyleBackColor = True
        '
        'btn_Build
        '
        Me.btn_Build.Location = New System.Drawing.Point(460, 177)
        Me.btn_Build.Name = "btn_Build"
        Me.btn_Build.Size = New System.Drawing.Size(97, 24)
        Me.btn_Build.TabIndex = 9
        Me.btn_Build.Text = "Build"
        Me.btn_Build.UseVisualStyleBackColor = True
        '
        'cmb_listDatabaseName
        '
        Me.cmb_listDatabaseName.FormattingEnabled = True
        Me.cmb_listDatabaseName.Location = New System.Drawing.Point(30, 143)
        Me.cmb_listDatabaseName.Name = "cmb_listDatabaseName"
        Me.cmb_listDatabaseName.Size = New System.Drawing.Size(632, 20)
        Me.cmb_listDatabaseName.TabIndex = 6
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(33, 16)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(175, 21)
        Me.txt_server.TabIndex = 5
        Me.txt_server.Text = "192.168.2.131"
        '
        'gb_ListTable
        '
        Me.gb_ListTable.Controls.Add(Me.dgv_listTableName)
        Me.gb_ListTable.Location = New System.Drawing.Point(30, 198)
        Me.gb_ListTable.Name = "gb_ListTable"
        Me.gb_ListTable.Size = New System.Drawing.Size(680, 366)
        Me.gb_ListTable.TabIndex = 4
        Me.gb_ListTable.TabStop = False
        Me.gb_ListTable.Text = "ListTable"
        '
        'dgv_listTableName
        '
        Me.dgv_listTableName.AllowUserToAddRows = False
        Me.dgv_listTableName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listTableName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.TableName})
        Me.dgv_listTableName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listTableName.Location = New System.Drawing.Point(3, 17)
        Me.dgv_listTableName.Name = "dgv_listTableName"
        Me.dgv_listTableName.RowTemplate.Height = 23
        Me.dgv_listTableName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listTableName.Size = New System.Drawing.Size(674, 346)
        Me.dgv_listTableName.TabIndex = 3
        '
        'chk
        '
        Me.chk.HeaderText = "All"
        Me.chk.Name = "chk"
        Me.chk.Width = 50
        '
        'TableName
        '
        Me.TableName.DataPropertyName = "TableName"
        Me.TableName.HeaderText = "TableName"
        Me.TableName.Name = "TableName"
        Me.TableName.Width = 400
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 590)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_TemplateList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 584)
        Me.SplitContainer1.SplitterDistance = 62
        Me.SplitContainer1.TabIndex = 1
        '
        'cmb_TemplateList
        '
        Me.cmb_TemplateList.FormattingEnabled = True
        Me.cmb_TemplateList.Location = New System.Drawing.Point(18, 20)
        Me.cmb_TemplateList.Name = "cmb_TemplateList"
        Me.cmb_TemplateList.Size = New System.Drawing.Size(703, 20)
        Me.cmb_TemplateList.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(736, 518)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 616)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "DatatableToClass"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gb_ListTable.ResumeLayout(False)
        CType(Me.dgv_listTableName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_psd As System.Windows.Forms.TextBox
    Friend WithEvents btn_connect As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmb_listDatabaseName As System.Windows.Forms.ComboBox
    Friend WithEvents txt_server As System.Windows.Forms.TextBox
    Friend WithEvents gb_ListTable As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listTableName As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TableName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Build As System.Windows.Forms.Button
    Friend WithEvents chk_selectAll As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_TemplateList As System.Windows.Forms.ComboBox
    Friend WithEvents btnEasyUI_JSTableColumn As System.Windows.Forms.Button
    Friend WithEvents rtb_JS As System.Windows.Forms.RichTextBox
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox

End Class
