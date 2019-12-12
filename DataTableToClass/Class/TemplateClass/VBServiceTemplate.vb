Public Class VBServiceTemplate
    Private tableName As String
    Private serviceExt As String
    Private modelExt As String

    Private serviceName As String
    Private modelName As String

    Public Sub New(ByVal _tableName As String,
                   Optional ByVal _modelExt As String = "Model",
                   Optional ByVal _serviceExt As String = "Service")
        tableName = _tableName
        serviceExt = _serviceExt
        modelExt = _modelExt

        serviceName = String.Format("{0}{1}", tableName, serviceExt)
        modelName = String.Format("{0}{1}", tableName, modelExt)
    End Sub
End Class
