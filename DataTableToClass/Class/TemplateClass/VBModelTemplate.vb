Public Class VBModelTemplate
    Private tableName As String
    Private listColumns As List(Of DbColumn)

    Private modelExt As String
    Private mapExt As String

    Private modelName As String
    Private mapName As String

    Public Sub New(ByVal _tableName As String,
                   ByVal _listColumns As List(Of DbColumn),
                   Optional ByVal _modelExt As String = "Model",
                   Optional ByVal _mapExt As String = "Map"
                   )
        tableName = _tableName
        listColumns = _listColumns

        modelExt = _modelExt
        mapExt = _mapExt

        modelName = String.Format("{0}{1}", tableName, modelExt)
        mapName = String.Format("{0}{1}", tableName, mapExt)
    End Sub

End Class
