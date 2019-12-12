Imports System.Threading
Imports System.Text

Public Class Form1
    Private _connectionString As String
    Private databaseName As String

    Private basePath As String = AppDomain.CurrentDomain.BaseDirectory
    Dim modelFilePath As String = IO.Path.Combine(basePath, "Models")
    Dim serviceFilePath As String = IO.Path.Combine(basePath, "Services")
    Dim repositoryFilePath As String = IO.Path.Combine(basePath, "Repositories")

    Private strModelExt As String = "Model"
    Private strMapExt As String = "Map"
    Private strServiceExt As String = "Service"
    Private strRepositoryExt As String = "Repository" '"Service"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


#Region "按钮事件"
    Private Sub btn_connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_connect.Click
        Dim txtServer = txt_server.Text.Trim
        Dim txtUser = txt_name.Text.Trim
        Dim txtPsd = txt_psd.Text.Trim
        DBUtil._connectionString = String.Format("Data Source={0}; uid={1}; Password={2}", txtServer, txtUser, txtPsd)
        _connectionString = DBUtil._connectionString
        Dim dt = getAllDatabase()

        cmb_listDatabaseName.DataSource = dt
        cmb_listDatabaseName.DisplayMember = "name"
        cmb_listDatabaseName.ValueMember = "name"

        cmb_listDatabaseName.SelectedIndex = 0
    End Sub

    Private Sub cmb_listDatabaseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_listDatabaseName.SelectedIndexChanged
        Dim dbName = cmb_listDatabaseName.Text
        If Not String.IsNullOrEmpty(dbName) AndAlso Not "System.Data.DataRowView".Equals(dbName) Then
            databaseName = dbName
            Dim dt = getAllDatatable(dbName)
            dgv_listTableName.DataSource = dt
        End If
    End Sub

    Private Sub btn_Build_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Build.Click
        Call SetBtnBuildStatus(False) '禁用按钮
        Dim selectRows = dgv_listTableName.SelectedRows
        Dim listTableName As New List(Of String)
        For Each r As DataGridViewRow In dgv_listTableName.Rows
            If Convert.ToBoolean(r.Cells(0).Value) Then
                listTableName.Add(r.Cells(1).Value)
            End If
        Next
        If listTableName.Count > 0 Then
            Threading.ThreadPool.QueueUserWorkItem(Sub()
                                                       Call T4Build(listTableName)
                                                   End Sub)
        Else
            Call SetBtnBuildStatus(True)    '设置build 按钮可用
        End If
    End Sub

    Private Sub chk_selectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_selectAll.CheckedChanged
        If chk_selectAll.CheckState Then
            SelectAll()
        Else
            CancelSelectAll()
        End If
    End Sub


#End Region

    '全选
    Sub SelectAll()
        For Each r As DataGridViewRow In dgv_listTableName.Rows
            If Convert.ToBoolean(r.Cells(0).Value) = False Then
                r.Cells(0).Value = True
            End If
        Next
    End Sub
    '取消全选
    Sub CancelSelectAll()
        For Each r As DataGridViewRow In dgv_listTableName.Rows
            If Convert.ToBoolean(r.Cells(0).Value) = True Then
                r.Cells(0).Value = False
            End If
        Next
    End Sub

    Sub SetBtnBuildStatus(ByVal flag As Boolean)
        Try
            Dim enabled = False
            Dim strTxt = "Build"
            If flag Then
                enabled = True
                strTxt = "Build"
            Else
                enabled = False
                strTxt = "努力生成中..."
            End If

            If Me.InvokeRequired Then
                Me.Invoke(Sub()
                              btn_Build.Enabled = enabled
                              btn_Build.Text = strTxt
                          End Sub)
            Else
                btn_Build.Enabled = enabled
                btn_Build.Text = strTxt
            End If
        Catch ex As Exception

        End Try
    End Sub

#Region "生成文件"
    Sub BuildFile(ByVal path As String, ByVal content As String)
        Try
            Dim dir = IO.Path.GetDirectoryName(path)
            If Not IO.Directory.Exists(dir) Then
                IO.Directory.CreateDirectory(dir)
            End If

            IO.File.WriteAllText(path, content)

        Catch ex As Exception
            Throw New Exception("生成文件出错！" + vbNewLine + ex.ToString)
        End Try
    End Sub
#End Region

#Region "数据库相关"

#Region "获取所有数据库"
    Function getAllDatabase() As DataTable
        Dim sqlstr = "SELECT name FROM  master..sysdatabases WHERE name NOT IN ( 'master', 'model', 'msdb', 'tempdb', 'northwind','pubs' )"

        Return DBUtil.ExecuteHasQuery(sqlstr)
    End Function
#End Region

#Region "获取数据库所有表"
    Function getAllDatatable(ByVal dbName As String) As DataTable
        Dim sqlstr = String.Format("SELECT name as TableName FROM {0}..sysobjects Where xtype='U' ORDER BY name", dbName)

        Return DBUtil.ExecuteHasQuery(sqlstr)
    End Function
#End Region
#End Region

#Region "T4 相关"
    Sub T4Build(ByVal listTableName As List(Of String))
        If Not String.IsNullOrEmpty(_connectionString) AndAlso Not String.IsNullOrEmpty(databaseName) AndAlso listTableName.Count > 0 Then
            Dim modelDictionary As New Dictionary(Of String, String)
            Dim repositoryDictionary As New Dictionary(Of String, String)
            Dim serviceDictionary As New Dictionary(Of String, String)
            For Each tbName In listTableName
                Dim listDbColumns = DbHelper.GetDbColumns(_connectionString, databaseName, tbName)
                '类、fluentapi Map
                Dim modelTp = New VBModelTemplate(tbName, listDbColumns, strModelExt, strMapExt)
                Dim modelContent = modelTp.TransformText()
                modelDictionary.Add(tbName, modelContent)
                'repository
                Dim repositoryTp = New VBRepositoryTemplate(tbName, strModelExt, strRepositoryExt)
                Dim repostoryContent = repositoryTp.TransformText
                repositoryDictionary.Add(tbName, repostoryContent)

                'service
                Dim serviceTp = New VBServiceTemplate(tbName, strModelExt, strServiceExt)
                Dim serviceContent = serviceTp.TransformText()
                serviceDictionary.Add(tbName, serviceContent)
            Next

            Dim arrManual = New List(Of ManualResetEvent)

            Dim manual = New ManualResetEvent(False)
            arrManual.Add(manual)
            Threading.ThreadPool.QueueUserWorkItem(New WaitCallback(
                                                   Sub()
                                                       Call T4BuildModel(modelDictionary, arrManual)  '生成类、fluentapi Map
                                                       Call T4BuildService(serviceDictionary, arrManual)  'service 
                                                       Call T4BuildRepository(repositoryDictionary, arrManual) 'repository
                                                       manual.Set()
                                                   End Sub))

            WaitHandle.WaitAll(arrManual.ToArray) '不能在按钮事件线程调用，需要另起一个线程

            Call SetBtnBuildStatus(True)    '设置build 按钮可用

            System.Diagnostics.Process.Start(basePath)
        End If
    End Sub
#Region "生成model、Map、Service、Repository"
    Sub T4BuildModel(ByVal modelDictionary As Dictionary(Of String, String), ByRef arrManual As List(Of ManualResetEvent))
        For Each key In modelDictionary.Keys
            Dim filePath As String = IO.Path.Combine(modelFilePath, String.Format("{0}{1}.vb", key, strModelExt))
            Dim content = modelDictionary.Item(key)
            Call BuildFile(filePath, content)
        Next
    End Sub

    Sub T4BuildRepository(ByVal serviceDictionary As Dictionary(Of String, String), ByRef arrManual As List(Of ManualResetEvent))
        For Each key In serviceDictionary.Keys
            Dim filePath As String = IO.Path.Combine(repositoryFilePath, String.Format("{0}{1}.vb", key, strRepositoryExt))
            Dim content = serviceDictionary.Item(key)
            Call BuildFile(filePath, content)
        Next
    End Sub

    Sub T4BuildService(ByVal repositoryDictionary As Dictionary(Of String, String), ByRef arrManual As List(Of ManualResetEvent))
        For Each key In repositoryDictionary.Keys
            Dim filePath As String = IO.Path.Combine(serviceFilePath, String.Format("{0}{1}.vb", key, strServiceExt))
            Dim content = repositoryDictionary.Item(key)
            Call BuildFile(filePath, content)
        Next
    End Sub

#End Region
#End Region

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim tab = TabControl1.SelectedTab
        If tab.Name = "TabPage2" Then
            Call InitTabPage2()
        End If
    End Sub

#Region "tabpage2"
    Sub InitTabPage2()
        getTemplateListCombo()
    End Sub

    Sub getTemplateListCombo()
        Dim s = System.IO.Path.GetFullPath("..\..\")
        Dim path As String = IO.Path.Combine(s, "Templates")
        Dim f = IO.Directory.GetFiles(path)
        Dim tp = (From p In f Where p.EndsWith(".tt") Select p).ToList
        cmb_TemplateList.DataSource = tp
    End Sub

#End Region

    Private Sub cmb_TemplateList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_TemplateList.SelectedIndexChanged
        Dim fp = cmb_TemplateList.SelectedValue
        ShowTemplate(fp)
    End Sub

    Sub ShowTemplate(path As String)
        Dim sr = New IO.StreamReader(path)
        Dim txt = sr.ReadToEnd()
        RichTextBox1.Text = txt
    End Sub


#Region "EasyUI_JSTableColumn"
    Private Sub btnEasyUI_JSTableColumn_Click(sender As System.Object, e As System.EventArgs) Handles btnEasyUI_JSTableColumn.Click
        'Me.Width = IIf(Me.Width = 772, 1305, 772)
        Me.Width = 1662

        Call SetBtnEasyUI_JSTableColumn(False) '禁用按钮
        Dim selectRows = dgv_listTableName.SelectedRows
        Dim listTableName As New List(Of String)
        For Each r As DataGridViewRow In dgv_listTableName.Rows
            If Convert.ToBoolean(r.Cells(0).Value) Then
                listTableName.Add(r.Cells(1).Value)
            End If
        Next
        If listTableName.Count > 0 Then
            Threading.ThreadPool.QueueUserWorkItem(Sub()
                                                       Call T4EasyUI_JSTableColumn(listTableName)
                                                   End Sub)
        Else
            Call SetBtnEasyUI_JSTableColumn(True)    '设置build 按钮可用
        End If

    End Sub

    Sub SetBtnEasyUI_JSTableColumn(ByVal flag As Boolean)
        Try
            Dim enabled = False
            Dim strTxt = "EasyUI_JSTableColumn"
            If flag Then
                enabled = True
                strTxt = "EasyUI_JSTableColumn"
            Else
                enabled = False
                strTxt = "努力生成中..."
            End If

            If Me.InvokeRequired Then
                Me.Invoke(Sub()
                              btnEasyUI_JSTableColumn.Enabled = enabled
                              btnEasyUI_JSTableColumn.Text = strTxt
                          End Sub)
            Else
                btnEasyUI_JSTableColumn.Enabled = enabled
                btnEasyUI_JSTableColumn.Text = strTxt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub T4EasyUI_JSTableColumn(ByVal listTableName As List(Of String))
        Dim jsDictionary As New Dictionary(Of String, String)
        For Each tbName In listTableName
            Dim listDbColumns = DbHelper.GetDbColumns(_connectionString, databaseName, tbName)

            Dim jsTp = New EasyUI_JSTableColumns(tbName, listDbColumns)
            Dim jsContent = jsTp.TransformText()
            jsDictionary.Add(tbName, jsContent)
        Next
        Dim sb As New StringBuilder
        With sb
            For Each itm In jsDictionary
                .Append(itm.Key).AppendLine()
                .Append(itm.Value).AppendLine().AppendLine()
            Next
        End With
        SetRTB_JSText(sb.ToString)
    End Sub

    Sub SetRTB_JSText(content)
        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          rtb_JS.Text = content
                      End Sub)
        Else
            rtb_JS.Text = content
        End If
    End Sub

#End Region

End Class


