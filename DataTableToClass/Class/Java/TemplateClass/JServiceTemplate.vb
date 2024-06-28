Public Class JServiceTemplate
    Public Property MyBaseMapper As String = ""
    Public Property MyBaseService As String = ""
    Public Property MyBaseServiceImpl As String = ""
    Public Property MyBaseController As String = ""

    Public Property EntityPackage As String = ""
    Public Property MapperPackage As String = ""
    Public Property ServicePackage As String = ""
    Public Property ServiceImplPackage As String = ""
    Public Property ControllerPackage As String = ""

    Public Property EntityName As String = ""

    Sub New()

    End Sub

    Sub New(baseInfo As BaseInfo)
        Me.EntityName = baseInfo.EntityName
        Me.MyBaseMapper = baseInfo.MyBaseMapper
        Me.MyBaseController = baseInfo.MyBaseController
        Me.MyBaseService = baseInfo.MyBaseService
        Me.MyBaseServiceImpl = baseInfo.MyBaseServiceImpl

        Me.EntityPackage = baseInfo.EntityPackage
        Me.MapperPackage = baseInfo.MapperPackage
        Me.ServicePackage = baseInfo.ServicePackage
        Me.ServiceImplPackage = baseInfo.ServiceImplPackage
        Me.ControllerPackage = baseInfo.ControllerPackage
    End Sub
End Class
