Public Class BaseInfo
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

    Sub New(entityName As String,
        myBaseMapper As String,
        myBaseService As String,
        myBaseServiceImpl As String,
        myBaseController As String,
        entityPackage As String,
        mapperPackage As String,
        servicePackage As String,
        serviceImplPackage As String,
        controllerPackage As String)

        Me.EntityName = entityName
        Me.MyBaseController = myBaseController
        Me.MyBaseService = MyBaseService
        Me.MyBaseServiceImpl = myBaseServiceImpl

        Me.MyBaseMapper = myBaseMapper
        Me.EntityPackage = entityPackage
        Me.MapperPackage = mapperPackage
        Me.ServicePackage = servicePackage
        Me.ServiceImplPackage = serviceImplPackage
        Me.ControllerPackage = controllerPackage
    End Sub
End Class
