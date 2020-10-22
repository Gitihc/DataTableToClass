Public Class VBFlowHandlerTemplate
    Private tableName As String

    Private modelExt As String
    Private modelName As String

    Private serviceExt As String
    Private serviceName As String

    Private flowHandlerExt As String
    Private flowHandlerName As String

    Private lidServiceName As String

    Public Sub New(ByVal _tableName As String,
                   Optional ByVal _modelExt As String = "Model",
                    Optional ByVal _serviceExt As String = "Service",
                    Optional ByVal _flowHandlerExt As String = "FlowHandler"
                   )
        tableName = _tableName

        modelExt = _modelExt
        modelName = String.Format("{0}{1}", tableName, modelExt)

        serviceExt = _serviceExt
        serviceName = String.Format("{0}{1}", tableName, serviceExt)

        flowHandlerExt = _flowHandlerExt
        flowHandlerName = String.Format("{0}{1}", tableName, flowHandlerExt)

        lidServiceName = String.Format("{0}Lid{1}", tableName, _serviceExt)
    End Sub
End Class
