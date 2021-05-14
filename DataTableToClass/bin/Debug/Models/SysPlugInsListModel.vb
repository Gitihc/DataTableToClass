
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SysPlugInsListModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 插件名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("插件名称")>
	Public Property Name As String

	''' <summary>
	''' 插件分类 注：0-项目汇总分析插件；1-合同汇总分析插件；2-客户汇总分析插件；3-问题汇总分析插件；4-其他插件
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("插件分类 注：0-项目汇总分析插件；1-合同汇总分析插件；2-客户汇总分析插件；3-问题汇总分析插件；4-其他插件")>
	Public Property Type As Integer?

	''' <summary>
	''' 插件图标
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("插件图标")>
	Public Property Icon As String

	''' <summary>
	''' 插件地址
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("插件地址")>
	Public Property LinkURL As String

	''' <summary>
	''' 插件描述
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("插件描述")>
	Public Property Desc As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property Roles As String

	Public Sub New()
		Me.Type = 0
	End Sub

End Class

Partial Public Class SysPlugInsListMap
    Inherits EntityTypeConfiguration(Of SysPlugInsListModel)
	Public Sub New()
		Me.ToTable("SysPlugInsList")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.Name)
		Me.Property(Function(t) t.Type)
		Me.Property(Function(t) t.Icon)
		Me.Property(Function(t) t.LinkURL)
		Me.Property(Function(t) t.Desc)
		Me.Property(Function(t) t.Roles)

	End Sub
End Class
