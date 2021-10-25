Imports Newtonsoft.Json

Public Module Util
#Region "数据-JSON 转换"
    'Json to object 
    Public Function JSONToObject(Of T)(ByVal Json As String) As T
        Dim obj As T = JsonConvert.DeserializeObject(Of T)(Json)
        Return obj
    End Function
    'obj to Json string
    Public Function ObjectToJSON(Of T)(ByVal obj As T) As String
        'Dim ser As JavaScriptSerializer = New JavaScriptSerializer()
        'Dim str As String = ser.Serialize(obj)
        'Return str
        Dim setting As JsonSerializerSettings = New JsonSerializerSettings() With {
                   .ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                   .DateFormatString = "yyyy-MM-dd HH:mm:ss"
               }

        Return JsonConvert.SerializeObject(obj, setting)
    End Function

#End Region
End Module
