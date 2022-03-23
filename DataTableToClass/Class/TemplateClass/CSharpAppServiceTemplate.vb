
Public Class CSharpAppServiceTemplate
    Private tableName As String
    Private serviceExt As String

    Private serviceName As String

    Public Sub New(ByVal _tableName As String,
                   Optional ByVal _serviceExt As String = "AppService")
        tableName = _tableName
        serviceExt = _serviceExt
        serviceName = String.Format("{0}{1}", _tableName, _serviceExt)
    End Sub
End Class
