''' <summary>
''' 表字段结构
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class DbColumn
    ''' <summary>
    ''' 字段ID
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ColumnID As Integer
    ''' <summary>
    ''' 是否主键
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsPrimaryKey As Boolean
    ''' <summary>
    ''' 字段名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ColumnName As String
    ''' <summary>
    ''' 字段类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ColumnType As String
    ''' <summary>
    ''' 数据库类型对应的C#类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CSharpType As String
        Get
            Return SqlServerDbTypeMap.MapVbType(ColumnType)
        End Get
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CommonType As Type
        Get
            Return SqlServerDbTypeMap.MapCommonType(ColumnType)
        End Get
    End Property
    ''' <summary>
    ''' 字节长度
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ByteLength As Integer
    ''' <summary>
    ''' 字符长度
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CharLength As Integer
    ''' <summary>
    ''' 小数位
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Scale As Integer
    ''' <summary>
    ''' 是否自增列
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsIdentity As Boolean
    ''' <summary>
    ''' 是否允许空
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsNullable As Boolean
    Private _defaultValue As String
    ''' <summary>
    ''' 默认值
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DefaultValue As String
        Set(value As String)
            Select Case value.ToLower
                Case "getdate"
                    _defaultValue = "Now"
                Case "''"
                    _defaultValue = "String.Empty"
                Case Else
                    _defaultValue = value
            End Select
        End Set
        Get
            Return _defaultValue
        End Get
    End Property
    ''' <summary>
    ''' 描述
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Remark As String
End Class


