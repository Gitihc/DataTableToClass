
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SysRoleModuleRightModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 角色ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("角色ID")>
	Public Property RoleID As Integer?

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

	''' <summary>
	''' 机构范围
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("机构范围")>
	Public Property BranchScope As Integer?

	''' <summary>
	''' 类型范围
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("类型范围")>
	Public Property TypeScope As String

	''' <summary>
	''' 是否生效 注：0-否；1-是
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("是否生效 注：0-否；1-是")>
	Public Property Enabled As Integer?

	Public Sub New()
		Me.Enabled = 0
	End Sub

End Class

Partial Public Class SysRoleModuleRightMap
    Inherits EntityTypeConfiguration(Of SysRoleModuleRightModel)
	Public Sub New()
		Me.ToTable("SysRoleModuleRight")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.RoleID)
		Me.Property(Function(t) t.ModuleID)
		Me.Property(Function(t) t.ModuleName)
		Me.Property(Function(t) t.ModuleType)
		Me.Property(Function(t) t.ComboTable)
		Me.Property(Function(t) t.BranchScope)
		Me.Property(Function(t) t.TypeScope)
		Me.Property(Function(t) t.Enabled)

	End Sub
End Class
