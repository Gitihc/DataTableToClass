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
        Me.cmb_dbtype = New System.Windows.Forms.ComboBox()
        Me.btn_flist = New System.Windows.Forms.Button()
        Me.btnRowData2ExcelRow = New System.Windows.Forms.Button()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_mybaseservice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_modulename = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_packagename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_mybasecontroller = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_mybaseserviceimpl = New System.Windows.Forms.TextBox()
        Me.txt_contollerpackage = New System.Windows.Forms.TextBox()
        Me.btn_java_create = New System.Windows.Forms.Button()
        Me.txt_serviceimplpackage = New System.Windows.Forms.TextBox()
        Me.txt_servicepackage = New System.Windows.Forms.TextBox()
        Me.txt_mapperpackage = New System.Windows.Forms.TextBox()
        Me.txt_entitypackage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_entityname = New System.Windows.Forms.TextBox()
        Me.txt_mybasemapper = New System.Windows.Forms.TextBox()
        Me.rtc_java_info = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gb_ListTable.SuspendLayout()
        CType(Me.dgv_listTableName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 616)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmb_dbtype)
        Me.TabPage1.Controls.Add(Me.btn_flist)
        Me.TabPage1.Controls.Add(Me.btnRowData2ExcelRow)
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
        'cmb_dbtype
        '
        Me.cmb_dbtype.FormattingEnabled = True
        Me.cmb_dbtype.Items.AddRange(New Object() {"SqlServer", "MySql"})
        Me.cmb_dbtype.Location = New System.Drawing.Point(30, 107)
        Me.cmb_dbtype.Name = "cmb_dbtype"
        Me.cmb_dbtype.Size = New System.Drawing.Size(75, 20)
        Me.cmb_dbtype.TabIndex = 17
        Me.cmb_dbtype.Text = "SqlServer"
        '
        'btn_flist
        '
        Me.btn_flist.Location = New System.Drawing.Point(559, 85)
        Me.btn_flist.Name = "btn_flist"
        Me.btn_flist.Size = New System.Drawing.Size(148, 24)
        Me.btn_flist.TabIndex = 16
        Me.btn_flist.Text = "flist"
        Me.btn_flist.UseVisualStyleBackColor = True
        '
        'btnRowData2ExcelRow
        '
        Me.btnRowData2ExcelRow.Location = New System.Drawing.Point(559, 16)
        Me.btnRowData2ExcelRow.Name = "btnRowData2ExcelRow"
        Me.btnRowData2ExcelRow.Size = New System.Drawing.Size(148, 24)
        Me.btnRowData2ExcelRow.TabIndex = 15
        Me.btnRowData2ExcelRow.Text = "RowData2ExcelRow"
        Me.btnRowData2ExcelRow.UseVisualStyleBackColor = True
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
        Me.btnEasyUI_JSTableColumn.Location = New System.Drawing.Point(559, 55)
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
        Me.btn_Build.Location = New System.Drawing.Point(565, 113)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.rtc_java_info)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 590)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_mybaseservice)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_modulename)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_packagename)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_mybasecontroller)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_mybaseserviceimpl)
        Me.GroupBox1.Controls.Add(Me.txt_contollerpackage)
        Me.GroupBox1.Controls.Add(Me.btn_java_create)
        Me.GroupBox1.Controls.Add(Me.txt_serviceimplpackage)
        Me.GroupBox1.Controls.Add(Me.txt_servicepackage)
        Me.GroupBox1.Controls.Add(Me.txt_mapperpackage)
        Me.GroupBox1.Controls.Add(Me.txt_entitypackage)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_entityname)
        Me.GroupBox1.Controls.Add(Me.txt_mybasemapper)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 414)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 12)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "MyBaseService"
        '
        'txt_mybaseservice
        '
        Me.txt_mybaseservice.Location = New System.Drawing.Point(161, 127)
        Me.txt_mybaseservice.Name = "txt_mybaseservice"
        Me.txt_mybaseservice.Size = New System.Drawing.Size(329, 21)
        Me.txt_mybaseservice.TabIndex = 24
        Me.txt_mybaseservice.Text = "com.cost168.wzcs.common.base.MyBaseService"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "ModuleName"
        '
        'txt_modulename
        '
        Me.txt_modulename.Location = New System.Drawing.Point(481, 62)
        Me.txt_modulename.Name = "txt_modulename"
        Me.txt_modulename.Size = New System.Drawing.Size(168, 21)
        Me.txt_modulename.TabIndex = 22
        Me.txt_modulename.Text = "project"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 12)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "PackageName"
        '
        'txt_packagename
        '
        Me.txt_packagename.Location = New System.Drawing.Point(161, 59)
        Me.txt_packagename.Name = "txt_packagename"
        Me.txt_packagename.Size = New System.Drawing.Size(168, 21)
        Me.txt_packagename.TabIndex = 20
        Me.txt_packagename.Text = "com.cost168.wzcs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 12)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "MyBaseController"
        '
        'txt_mybasecontroller
        '
        Me.txt_mybasecontroller.Location = New System.Drawing.Point(161, 191)
        Me.txt_mybasecontroller.Name = "txt_mybasecontroller"
        Me.txt_mybasecontroller.Size = New System.Drawing.Size(329, 21)
        Me.txt_mybasecontroller.TabIndex = 18
        Me.txt_mybasecontroller.Text = "com.cost168.wzcs.common.base.MyBaseController"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "MyBaseServiceImpl"
        '
        'txt_mybaseserviceimpl
        '
        Me.txt_mybaseserviceimpl.Location = New System.Drawing.Point(161, 159)
        Me.txt_mybaseserviceimpl.Name = "txt_mybaseserviceimpl"
        Me.txt_mybaseserviceimpl.Size = New System.Drawing.Size(329, 21)
        Me.txt_mybaseserviceimpl.TabIndex = 16
        Me.txt_mybaseserviceimpl.Text = "com.cost168.wzcs.common.base.MyBaseServiceImpl"
        '
        'txt_contollerpackage
        '
        Me.txt_contollerpackage.Location = New System.Drawing.Point(161, 377)
        Me.txt_contollerpackage.Name = "txt_contollerpackage"
        Me.txt_contollerpackage.Size = New System.Drawing.Size(329, 21)
        Me.txt_contollerpackage.TabIndex = 15
        Me.txt_contollerpackage.Text = "com.cost168.wzcs.project.controller"
        '
        'btn_java_create
        '
        Me.btn_java_create.Location = New System.Drawing.Point(587, 21)
        Me.btn_java_create.Name = "btn_java_create"
        Me.btn_java_create.Size = New System.Drawing.Size(101, 31)
        Me.btn_java_create.TabIndex = 2
        Me.btn_java_create.Text = "create"
        Me.btn_java_create.UseVisualStyleBackColor = True
        '
        'txt_serviceimplpackage
        '
        Me.txt_serviceimplpackage.Location = New System.Drawing.Point(161, 344)
        Me.txt_serviceimplpackage.Name = "txt_serviceimplpackage"
        Me.txt_serviceimplpackage.Size = New System.Drawing.Size(329, 21)
        Me.txt_serviceimplpackage.TabIndex = 14
        Me.txt_serviceimplpackage.Text = "com.cost168.wzcs.project.service.Impl"
        '
        'txt_servicepackage
        '
        Me.txt_servicepackage.Location = New System.Drawing.Point(161, 302)
        Me.txt_servicepackage.Name = "txt_servicepackage"
        Me.txt_servicepackage.Size = New System.Drawing.Size(329, 21)
        Me.txt_servicepackage.TabIndex = 13
        Me.txt_servicepackage.Text = "com.cost168.wzcs.project.service"
        '
        'txt_mapperpackage
        '
        Me.txt_mapperpackage.Location = New System.Drawing.Point(161, 269)
        Me.txt_mapperpackage.Name = "txt_mapperpackage"
        Me.txt_mapperpackage.Size = New System.Drawing.Size(329, 21)
        Me.txt_mapperpackage.TabIndex = 12
        Me.txt_mapperpackage.Text = "com.cost168.wzcs.project.mapper"
        '
        'txt_entitypackage
        '
        Me.txt_entitypackage.Location = New System.Drawing.Point(161, 234)
        Me.txt_entitypackage.Name = "txt_entitypackage"
        Me.txt_entitypackage.Size = New System.Drawing.Size(329, 21)
        Me.txt_entitypackage.TabIndex = 11
        Me.txt_entitypackage.Text = "com.cost168.wzcs.project.entity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ControllerPackage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ServiceImplPackage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ServicePackage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MapperPackage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "EntityPackage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MyBaseMapper"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "EntityName"
        '
        'txt_entityname
        '
        Me.txt_entityname.Location = New System.Drawing.Point(161, 27)
        Me.txt_entityname.Name = "txt_entityname"
        Me.txt_entityname.Size = New System.Drawing.Size(329, 21)
        Me.txt_entityname.TabIndex = 0
        Me.txt_entityname.Text = "BackupRecord"
        '
        'txt_mybasemapper
        '
        Me.txt_mybasemapper.Location = New System.Drawing.Point(161, 94)
        Me.txt_mybasemapper.Name = "txt_mybasemapper"
        Me.txt_mybasemapper.Size = New System.Drawing.Size(329, 21)
        Me.txt_mybasemapper.TabIndex = 3
        Me.txt_mybasemapper.Text = "com.cost168.wzcs.common.base.MyBaseMapper"
        '
        'rtc_java_info
        '
        Me.rtc_java_info.Location = New System.Drawing.Point(8, 426)
        Me.rtc_java_info.Name = "rtc_java_info"
        Me.rtc_java_info.Size = New System.Drawing.Size(700, 147)
        Me.rtc_java_info.TabIndex = 1
        Me.rtc_java_info.Text = ""
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
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents btnRowData2ExcelRow As System.Windows.Forms.Button
    Friend WithEvents btn_flist As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_mybasemapper As System.Windows.Forms.TextBox
    Friend WithEvents btn_java_create As System.Windows.Forms.Button
    Friend WithEvents rtc_java_info As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_entityname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_contollerpackage As System.Windows.Forms.TextBox
    Friend WithEvents txt_serviceimplpackage As System.Windows.Forms.TextBox
    Friend WithEvents txt_servicepackage As System.Windows.Forms.TextBox
    Friend WithEvents txt_mapperpackage As System.Windows.Forms.TextBox
    Friend WithEvents txt_entitypackage As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_mybasecontroller As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_mybaseserviceimpl As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_modulename As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_packagename As System.Windows.Forms.TextBox
    Friend WithEvents cmb_dbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_mybaseservice As System.Windows.Forms.TextBox

End Class
