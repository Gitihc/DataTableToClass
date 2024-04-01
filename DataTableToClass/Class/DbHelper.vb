Imports System.Data.SqlClient

Public Class DbHelper
    Public Shared Function GetDbTables(ByVal connectionString As String, ByVal database As String, Optional ByVal tables As String = Nothing) As List(Of DbTable)
        If Not String.IsNullOrEmpty(tables) Then
            tables = String.Format(" and obj.name in ('{0}')", tables.Replace(",", "','"))
        End If

        Dim sql As String = String.Format(" SELECT " +
                                         " obj.name tablename," +
                                         " schem.name schemname," +
                                         " idx.rows," +
                                         " CAST" +
                                         " (" +
                                          " CASE " +
                                           " WHEN (SELECT COUNT(1) FROM sys.indexes WHERE object_id= obj.OBJECT_ID AND is_primary_key=1) >=1 THEN 1" +
                                           " ELSE 0" +
                                         " End" +
                                         " AS BIT) HasPrimaryKey " +
                                         " from {0}.sys.objects obj " +
                                         " inner join {0}.dbo.sysindexes idx on obj.object_id=idx.id and idx.indid<=1" +
                                         " INNER JOIN {0}.sys.schemas schem ON obj.schema_id=schem.schema_id" +
                                         " where type='U' {1}" +
                                         " order by obj.name", database, tables)
        Dim dt As DataTable = GetDataTable(connectionString, sql)
        Return dt.Rows.Cast(Of DataRow)().[Select](Function(row) New DbTable With {
            .TableName = row.Field(Of String)("tablename"),
            .SchemaName = row.Field(Of String)("schemname"),
            .Rows = row.Field(Of Integer)("rows"),
            .HasPrimaryKey = row.Field(Of Boolean)("HasPrimaryKey")
        }).ToList()
    End Function

    Public Shared Function GetDbColumns(ByVal connectionString As String, ByVal database As String, ByVal tableName As String, Optional ByVal schema As String = "dbo") As List(Of DbColumn)
        Dim sql As String = String.Format("" +
                                   " WITH indexCTE AS" +
                                   " (" +
                                "    SELECT " +
                                   "    ic.column_id," +
                                   "    ic.index_column_id," +
                                   "    ic.object_id    " +
                                   "    FROM [{0}].sys.indexes idx" +
                                   "    INNER JOIN [{0}].sys.index_columns ic ON idx.index_id = ic.index_id AND idx.object_id = ic.object_id" +
                                   "    WHERE  idx.object_id =OBJECT_ID(@tableName) AND idx.is_primary_key=1" +
                                   " )" +
                                   " select" +
                                    " colm.column_id ColumnID," +
                                   " CAST(CASE WHEN indexCTE.column_id IS NULL THEN 0 ELSE 1 END AS BIT) IsPrimaryKey," +
                                   " colm.name ColumnName," +
                                   " systype.name ColumnType," +
                                   " colm.is_identity IsIdentity," +
                                   " colm.is_nullable IsNullable," +
                                   " cast(colm.max_length as int) ByteLength," +
                                   " (" +
                                   "    case " +
                                   "        when systype.name='nvarchar' and colm.max_length>0 then colm.max_length/2 " +
                                   "        when systype.name='nchar' and colm.max_length>0 then colm.max_length/2" +
                                   "        when systype.name='ntext' and colm.max_length>0 then colm.max_length/2 " +
                                   "        else colm.max_length" +
                                    " End" +
                                    " ) CharLength," +
                                    " cast(colm.precision as int) Precision," +
                                    " cast(colm.scale as int) Scale," +
                                    " isnull(comments.text,'') DefaultValue," +
                                    " prop.value Remark" +
                                    " from [{0}].sys.columns colm" +
                                    " inner join [{0}].sys.types systype on colm.system_type_id=systype.system_type_id and colm.user_type_id=systype.user_type_id" +
                                    " left join [{0}].sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id" +
                                    " left join [{0}].sys.syscomments comments on colm.default_object_id=comments.id" +
                                    " LEFT JOIN indexCTE ON colm.column_id=indexCTE.column_id AND colm.object_id=indexCTE.object_id " +
                                    " where colm.object_id=OBJECT_ID(@tableName)" +
                                    " order by colm.column_id", database)
        Dim param As SqlParameter = New SqlParameter("@tableName", SqlDbType.NVarChar, 100) With {
            .Value = String.Format("{0}.{1}.{2}", database, schema, tableName)
        }
        Dim dt As DataTable = Nothing
        If DBUtil.dbType = DbTypeCommon.MySql Then
            dt = DBUtil.ExecuteHasQuery(MySqlUtils.getFieldInfo(tableName))
        ElseIf DBUtil.dbType = DbTypeCommon.SqlServer Then
            dt = GetDataTable(connectionString, sql, param)
        End If
        'Dim dt As DataTable = GetDataTable(connectionString, sql, param)
        If DBUtil.dbType = DbTypeCommon.MySql Then
            Return dt.Rows.Cast(Of DataRow)().[Select](Function(row) New DbColumn() With {
              .ColumnID = row.Field(Of Long)("ColumnID"),
              .IsPrimaryKey = row.Field(Of Long)("IsPrimaryKey"),
              .ColumnName = row.Field(Of String)("ColumnName"),
              .ColumnType = row.Field(Of String)("ColumnType"),
              .IsIdentity = row.Field(Of Long)("IsIdentity"),
              .IsNullable = row.Field(Of Long)("IsNullable"),
              .ByteLength = row.Field(Of Long)("ByteLength"),
              .CharLength = row.Field(Of Long)("CharLength"),
              .Scale = row.Field(Of Long)("Scale"),
              .DefaultValue = row.Field(Of String)("DefaultValue").Replace("(", "").Replace(")", ""),
              .Remark = row("Remark").ToString()
          }).ToList()
        ElseIf DBUtil.dbType = DbTypeCommon.SqlServer Then
            Return dt.Rows.Cast(Of DataRow)().[Select](Function(row) New DbColumn() With {
               .ColumnID = row.Field(Of Integer)("ColumnID"),
               .IsPrimaryKey = row.Field(Of Boolean)("IsPrimaryKey"),
               .ColumnName = row.Field(Of String)("ColumnName"),
               .ColumnType = row.Field(Of String)("ColumnType"),
               .IsIdentity = row.Field(Of Boolean)("IsIdentity"),
               .IsNullable = row.Field(Of Boolean)("IsNullable"),
               .ByteLength = row.Field(Of Integer)("ByteLength"),
               .CharLength = row.Field(Of Integer)("CharLength"),
               .Scale = row.Field(Of Integer)("Scale"),
               .DefaultValue = row.Field(Of String)("DefaultValue").Replace("(", "").Replace(")", ""),
               .Remark = row("Remark").ToString()
           }).ToList()
        End If
        Return New List(Of DbColumn)()
    End Function

    Public Shared Function GetDataTable(ByVal connectionString As String, ByVal commandText As String, ByVal ParamArray parms As SqlParameter()) As DataTable
        Using connection As SqlConnection = New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = commandText
            command.Parameters.AddRange(parms)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dt As DataTable = New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function
End Class

