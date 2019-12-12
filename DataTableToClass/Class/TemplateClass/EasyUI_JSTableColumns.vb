Public Class EasyUI_JSTableColumns
    Private tableName As String
    Private listColumns As List(Of DbColumn)

    Public Sub New(ByVal _tableName As String,
                   ByVal _listColumns As List(Of DbColumn)
                   )
        tableName = _tableName
        listColumns = _listColumns
    End Sub
End Class
