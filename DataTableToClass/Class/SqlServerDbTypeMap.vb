Public Class SqlServerDbTypeMap
    Public Shared Function MapVbType(ByVal dbtype As String) As String
        If String.IsNullOrEmpty(dbtype) Then Return dbtype
        dbtype = dbtype.ToLower()
        Dim vbType As String = "object"

        Select Case dbtype
            Case "bigint"
                vbType = "Long"
            Case "binary"
                vbType = "Byte()" '"Byte[]"
            Case "bit"
                vbType = "Bool"
            Case "char"
                vbType = "String"
            Case "date"
                vbType = "DateTime"
            Case "datetime"
                vbType = "DateTime"
            Case "datetime2"
                vbType = "DateTime"
            Case "datetimeoffset"
                vbType = "DateTimeOffset"
            Case "decimal"
                vbType = "Decimal"
            Case "float"
                vbType = "Double"
            Case "image"
                vbType = "Byte()" '"Byte[]"
            Case "int"
                vbType = "Integer"
            Case "money"
                vbType = "Decimal"
            Case "nchar"
                vbType = "String"
            Case "ntext"
                vbType = "String"
            Case "numeric"
                vbType = "Decimal"
            Case "nvarchar"
                vbType = "String"
            Case "real"
                vbType = "Single"
            Case "smalldatetime"
                vbType = "DateTime"
            Case "smallint"
                vbType = "Short"
            Case "smallmoney"
                vbType = "Decimal"
            Case "sql_variant"
                vbType = "Object"
            Case "sysname"
                vbType = "Object"
            Case "text"
                vbType = "String"
            Case "time"
                vbType = "TimeSpan"
            Case "timestamp"
                vbType = "Byte()" '"Byte[]"
            Case "tinyint"
                vbType = "Byte"
            Case "uniqueidentifier"
                vbType = "Guid"
            Case "varbinary"
                vbType = "Byte()" '"Byte[]"
            Case "varchar"
                vbType = "String"
            Case "xml"
                vbType = "String"
            Case Else
                vbType = "Object"
        End Select

        Return vbType
    End Function

    Public Shared Function MapCSharpType(ByVal dbtype As String) As String
        If String.IsNullOrEmpty(dbtype) Then Return dbtype
        dbtype = dbtype.ToLower()
        Dim vbType As String = "object"

        Select Case dbtype
            Case "bigint"
                vbType = "Long"
            Case "binary"
                vbType = "Byte[]"
            Case "bit"
                vbType = "Bool"
            Case "char"
                vbType = "String"
            Case "date"
                vbType = "DateTime"
            Case "datetime"
                vbType = "DateTime"
            Case "datetime2"
                vbType = "DateTime"
            Case "datetimeoffset"
                vbType = "DateTimeOffset"
            Case "decimal"
                vbType = "Decimal"
            Case "float"
                vbType = "Double"
            Case "image"
                vbType = "Byte[]"
            Case "int"
                vbType = "int"
            Case "money"
                vbType = "Decimal"
            Case "nchar"
                vbType = "String"
            Case "ntext"
                vbType = "String"
            Case "numeric"
                vbType = "Decimal"
            Case "nvarchar"
                vbType = "String"
            Case "real"
                vbType = "Single"
            Case "smalldatetime"
                vbType = "DateTime"
            Case "smallint"
                vbType = "Short"
            Case "smallmoney"
                vbType = "Decimal"
            Case "sql_variant"
                vbType = "Object"
            Case "sysname"
                vbType = "Object"
            Case "text"
                vbType = "String"
            Case "time"
                vbType = "TimeSpan"
            Case "timestamp"
                vbType = "Byte[]"
            Case "tinyint"
                vbType = "Byte"
            Case "uniqueidentifier"
                vbType = "Guid"
            Case "varbinary"
                vbType = "Byte[]"
            Case "varchar"
                vbType = "String"
            Case "xml"
                vbType = "String"
            Case Else
                vbType = "Object"
        End Select

        Return vbType
    End Function

    Public Shared Function MapCommonType(ByVal dbtype As String) As Type
        If String.IsNullOrEmpty(dbtype) Then Return Type.Missing.[GetType]()
        dbtype = dbtype.ToLower()
        Dim commonType As Type = GetType(Object)

        Select Case dbtype
            Case "bigint"
                commonType = GetType(Long)
            Case "binary"
                commonType = GetType(Byte())
            Case "bit"
                commonType = GetType(Boolean)
            Case "char"
                commonType = GetType(String)
            Case "date"
                commonType = GetType(DateTime)
            Case "datetime"
                commonType = GetType(DateTime)
            Case "datetime2"
                commonType = GetType(DateTime)
            Case "datetimeoffset"
                commonType = GetType(DateTimeOffset)
            Case "decimal"
                commonType = GetType(Decimal)
            Case "float"
                commonType = GetType(Double)
            Case "image"
                commonType = GetType(Byte())
            Case "int"
                commonType = GetType(Integer)
            Case "money"
                commonType = GetType(Decimal)
            Case "nchar"
                commonType = GetType(String)
            Case "ntext"
                commonType = GetType(String)
            Case "numeric"
                commonType = GetType(Decimal)
            Case "nvarchar"
                commonType = GetType(String)
            Case "real"
                commonType = GetType(Single)
            Case "smalldatetime"
                commonType = GetType(DateTime)
            Case "smallint"
                commonType = GetType(Short)
            Case "smallmoney"
                commonType = GetType(Decimal)
            Case "sql_variant"
                commonType = GetType(Object)
            Case "sysname"
                commonType = GetType(Object)
            Case "text"
                commonType = GetType(String)
            Case "time"
                commonType = GetType(TimeSpan)
            Case "timestamp"
                commonType = GetType(Byte())
            Case "tinyint"
                commonType = GetType(Byte)
            Case "uniqueidentifier"
                commonType = GetType(Guid)
            Case "varbinary"
                commonType = GetType(Byte())
            Case "varchar"
                commonType = GetType(String)
            Case "xml"
                commonType = GetType(String)
            Case Else
                commonType = GetType(Object)
        End Select

        Return commonType
    End Function
End Class
