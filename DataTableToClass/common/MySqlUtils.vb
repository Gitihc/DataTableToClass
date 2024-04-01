Imports System.Text

Public Class MySqlUtils

    Public Shared Function getAllDatabase() As String
        Return "SELECT SCHEMA_NAME name FROM information_schema.SCHEMATA;"
    End Function

    Public Shared Function getAllTable(table_schema As String) As String
        Return String.Format("SELECT  TABLE_Name TableName FROM information_schema.TABLES WHERE TABLE_SCHEMA = '{0}';", table_schema)
    End Function

    Public Shared Function getFieldInfo(table_schema As String) As String
        Dim strSb = New StringBuilder()
        strSb.Append(" SELECT ")
        strSb.Append("    CAST(ORDINAL_POSITION AS SIGNED) ColumnID,")
        strSb.Append("    CAST(if(COLUMN_KEY='PRI',1,0) As SIGNED) IsPrimaryKey,")
        strSb.Append("    COLUMN_NAME ColumnName,")
        strSb.Append("    DATA_TYPE ColumnType,")
        strSb.Append("    0 IsIdentity,")
        strSb.Append("    if(IS_NULLABLE='YES',1,0) IsNullable,")
        strSb.Append("    if(ISNULL(CHARACTER_OCTET_LENGTH),0,CHARACTER_OCTET_LENGTH) ByteLength,")
        strSb.Append("    if(ISNULL(CHARACTER_MAXIMUM_LENGTH),0,CHARACTER_MAXIMUM_LENGTH) CharLength,")
        strSb.Append("    if(ISNULL(NUMERIC_SCALE),0,NUMERIC_SCALE) Scale,")
        strSb.Append("    if(ISNULL(COLUMN_DEFAULT),' ',COLUMN_DEFAULT) DefaultValue,")
        strSb.Append("    if(ISNULL(COLUMN_COMMENT),' ',COLUMN_COMMENT) Remark")
        strSb.Append(" FROM INFORMATION_SCHEMA.COLUMNS")
        strSb.AppendFormat(" WHERE TABLE_NAME='{0}';", table_schema)
        Return strSb.ToString()
    End Function

End Class
