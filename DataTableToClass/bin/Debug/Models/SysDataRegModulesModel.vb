
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SysDataRegModulesModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 模块ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("模块ID")>
	Public Property ModuleID As String

	''' <summary>
	''' 模块名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("模块名称")>
	Public Property ModuleName As String

	''' <summary>
	''' 模块类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("模块类型")>
	Public Property ModuleType As Integer?

	''' <summary>
	''' 下拉类型对应表
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("下拉类型对应表")>
	Public Property ComboTable As String

	Public Sub New()
	End Sub

End Class

Partial Public Class SysDataRegModulesMap
    Inherits EntityTypeConfiguration(Of SysDataRegModulesModel)
	Public Sub New()
		Me.ToTable("SysDataRegModules")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ModuleID)
		Me.Property(Function(t) t.ModuleName)
		Me.Property(Function(t) t.ModuleType)
		Me.Property(Function(t) t.ComboTable)

	End Sub
End Class
