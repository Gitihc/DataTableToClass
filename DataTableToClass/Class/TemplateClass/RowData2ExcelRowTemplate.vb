Public Class RowData2ExcelRowTemplate
    Private listColumns As List(Of DbColumn)

    Public Sub New(ByVal _listColumns As List(Of DbColumn))
        listColumns = _listColumns
    End Sub
End Class
