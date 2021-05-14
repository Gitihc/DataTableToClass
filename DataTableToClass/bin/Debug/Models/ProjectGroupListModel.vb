
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectGroupListModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property GroupCode As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property GroupName As String

	''' <summary>
	''' 项目简称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目简称")>
	Public Property Abbreviation As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property TypeID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ClassID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property BranchID As Integer?

	''' <summary>
	''' 申请科室
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("申请科室")>
	Public Property Department As String

	''' <summary>
	''' 项目负责人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目负责人")>
	Public Property Assign As Integer?

	''' <summary>
	''' 办公室主任
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("办公室主任")>
	Public Property Director As Integer?

	''' <summary>
	''' 项目内容
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目内容")>
	Public Property Contents As String

	''' <summary>
	''' 项目所在地:省、 市选择+ 详细地址输入
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目所在地:省、 市选择+ 详细地址输入")>
	Public Property Location As String

	''' <summary>
	''' 项目状态：0-立项；1-计划；2-实施；3-完成；4-终止；5-暂停
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目状态：0-立项；1-计划；2-实施；3-完成；4-终止；5-暂停")>
	Public Property Status As Integer?

	''' <summary>
	''' 创建人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建人ID")>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 创建时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建时间")>
	Public Property CreatDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property IsDeleted As Integer?

	''' <summary>
	''' 删除日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("删除日期")>
	Public Property DeleteDate As DateTime?

	''' <summary>
	''' 删除人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("删除人")>
	Public Property DeleteByUserID As Integer?

	''' <summary>
	''' 节点ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("节点ID")>
	Public Property ElementID As Integer?

	''' <summary>
	''' 委托方ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托方ID")>
	Public Property ClientID As Integer?

	''' <summary>
	''' 关联合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("关联合同ID")>
	Public Property ContractID As Integer?

	''' <summary>
	''' Nas设备ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("Nas设备ID")>
	Public Property NasDeviceID As Integer?

	''' <summary>
	''' 在Nas设备上的文件保存目录
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("在Nas设备上的文件保存目录")>
	Public Property NasFolder As String

	''' <summary>
	''' 估算金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("估算金额")>
	Public Property EstimatSum As Decimal?

	''' <summary>
	''' 概算金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("概算金额")>
	Public Property ApproxSum As Decimal?

	''' <summary>
	''' 合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同金额")>
	Public Property ContracSum As Decimal?

	''' <summary>
	''' 变更金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("变更金额")>
	Public Property ChangeSum As Decimal?

	''' <summary>
	''' 完成金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("完成金额")>
	Public Property CompleSum As Decimal?

	''' <summary>
	''' 支付金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("支付金额")>
	Public Property PaymenSum As Decimal?

	''' <summary>
	''' 结算金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("结算金额")>
	Public Property SettlemSum As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property FundsType As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ExamiWays As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ConstCycle As String

	Public Sub New()
		Me.TypeID = 0
		Me.Status = 0
		Me.CreatDate = Now
		Me.IsDeleted = 0
		Me.ContractID = 0
		Me.EstimatSum = 0
		Me.ApproxSum = 0
		Me.ContracSum = 0
		Me.ChangeSum = 0
		Me.CompleSum = 0
		Me.PaymenSum = 0
		Me.SettlemSum = 0
	End Sub

End Class

Partial Public Class ProjectGroupListMap
    Inherits EntityTypeConfiguration(Of ProjectGroupListModel)
	Public Sub New()
		Me.ToTable("ProjectGroupList")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.GroupCode)
		Me.Property(Function(t) t.GroupName)
		Me.Property(Function(t) t.Abbreviation)
		Me.Property(Function(t) t.TypeID)
		Me.Property(Function(t) t.ClassID)
		Me.Property(Function(t) t.BranchID)
		Me.Property(Function(t) t.Department)
		Me.Property(Function(t) t.Assign)
		Me.Property(Function(t) t.Director)
		Me.Property(Function(t) t.Contents)
		Me.Property(Function(t) t.Location)
		Me.Property(Function(t) t.Status)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.CreatDate)
		Me.Property(Function(t) t.IsDeleted)
		Me.Property(Function(t) t.DeleteDate)
		Me.Property(Function(t) t.DeleteByUserID)
		Me.Property(Function(t) t.ElementID)
		Me.Property(Function(t) t.ClientID)
		Me.Property(Function(t) t.ContractID)
		Me.Property(Function(t) t.NasDeviceID)
		Me.Property(Function(t) t.NasFolder)
		Me.Property(Function(t) t.EstimatSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.ApproxSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.ContracSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.ChangeSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.CompleSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.PaymenSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.SettlemSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.FundsType)
		Me.Property(Function(t) t.ExamiWays)
		Me.Property(Function(t) t.ConstCycle)

	End Sub
End Class
