
Public Class ProjectGroupListService
    Inherits BaseServices(Of ProjectGroupListModel)

#Region "删除"
    Public Overloads Shared Function Delete(id As Integer) As Boolean
        Return Delete(New List(Of Integer) From {id})
    End Function

    Public Overloads Shared Function Delete(listId As List(Of Integer)) As Boolean
        Return EntityHelper.DeleteMul(Of ProjectGroupListModel)(Function(x) listId.Contains(x.ID))
    End Function
#End Region
End Class