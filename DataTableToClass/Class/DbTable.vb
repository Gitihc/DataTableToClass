''' <summary>
''' 表结构
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class DbTable
    ''' <summary>
    ''' 表名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TableName As String
    ''' <summary>
    ''' 表的架构
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SchemaName As String
    ''' <summary>
    ''' 表的记录数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Rows As Integer
    ''' <summary>
    ''' 是否含有主键
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HasPrimaryKey As Boolean
End Class

