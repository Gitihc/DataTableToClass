Public Class VBRepositoryTemplate
    Private tableName As String
    Private repositoryExt As String
    Private modelExt As String

    Private repositoryName As String
    Private modelName As String

    Public Sub New(ByVal _tableName As String,
                   Optional ByVal _modelExt As String = "Model",
                   Optional ByVal _repositoryExt As String = "Repository")
        tableName = _tableName
        repositoryExt = _repositoryExt
        modelExt = _modelExt

        repositoryName = String.Format("{0}{1}", tableName, repositoryExt)
        modelName = String.Format("{0}{1}", tableName, modelExt)
    End Sub
End Class
