
Public Class ProjectDeductionAttachService
    Inherits BaseServices(Of ProjectDeductionAttachModel)

#Region "删除"
    Public Overloads Shared Function Delete(id As Integer) As Boolean
        Return Delete(New List(Of Integer) From {id})
    End Function

    Public Overloads Shared Function Delete(listId As List(Of Integer)) As Boolean
        Return EntityHelper.DeleteMul(Of ProjectDeductionAttachModel)(Function(x) listId.Contains(x.ID))
    End Function
#End Region
End Class