
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectCollContractsModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 协作合同编号 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("协作合同编号 ")>
	Public Property CollCode As String

	''' <summary>
	''' 协作合同名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("协作合同名称")>
	Public Property CollName As String

	''' <summary>
	''' 委托类型：0-分包；1-协作
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托类型：0-分包；1-协作")>
	Public Property CollType As Integer?

	''' <summary>
	''' 协作单位ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("协作单位ID")>
	Public Property CollUnitID As Integer?

	''' <summary>
	''' 协作单位名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("协作单位名称")>
	Public Property CollUnitName As String

	''' <summary>
	''' 委托合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同ID")>
	Public Property EntrustID As Integer?

	''' <summary>
	''' 委托合同编号 注：新建时根据所选的委托合同ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同编号 注：新建时根据所选的委托合同ID读取过来")>
	Public Property EntrustCode As String

	''' <summary>
	''' 委托合同名称 注：新建时根据所选的委托合同ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同名称 注：新建时根据所选的委托合同ID读取过来")>
	Public Property EntrustName As String

	''' <summary>
	''' 委托合同金额 注：新建时根据所选的委托合同ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同金额 注：新建时根据所选的委托合同ID读取过来")>
	Public Property EntrustedSum As Decimal?

	''' <summary>
	''' 委托合同负责人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同负责人ID")>
	Public Property EntrustAssignID As Integer?

	''' <summary>
	''' 委托合同负责人姓名
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同负责人姓名")>
	Public Property EntrustAssignName As String

	''' <summary>
	''' 委托合同所属部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同所属部门ID")>
	Public Property EntrustBranchID As String

	''' <summary>
	''' 委托合同所属部门名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托合同所属部门名称")>
	Public Property EntrustBranchName As String

	''' <summary>
	''' 合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同金额")>
	Public Property ContractSum As Decimal?

	''' <summary>
	''' 累计支付金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("累计支付金额")>
	Public Property PaymentSum As Decimal?

	''' <summary>
	''' 此项任务预计收入
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("此项任务预计收入")>
	Public Property EstimateSum As Decimal?

	''' <summary>
	''' 委托单位ID 注：新建时根据所选的委托合同ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位ID 注：新建时根据所选的委托合同ID读取过来")>
	Public Property ClientID As Integer?

	''' <summary>
	''' 委托单位（业主）名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位（业主）名称")>
	Public Property ClientName As String

	''' <summary>
	''' 联系人（协作方）注：新建时根据所选的协作方ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("联系人（协作方）注：新建时根据所选的协作方ID读取过来")>
	Public Property Contacts As String

	''' <summary>
	''' 联系电话（协作方）注：新建时根据所选的协作方ID读取过来
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("联系电话（协作方）注：新建时根据所选的协作方ID读取过来")>
	Public Property Telephone As String

	''' <summary>
	''' 工期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工期")>
	Public Property Period As DateTime?

	''' <summary>
	''' 申请部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("申请部门ID")>
	Public Property BranchID As Integer?

	''' <summary>
	''' 申请部门名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("申请部门名称")>
	Public Property BranchName As String

	''' <summary>
	''' 创建人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建人ID")>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 创建日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建日期")>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 合同状态：０－新建；１－审批中；２－已审结；３－已驳回
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同状态：０－新建；１－审批中；２－已审结；３－已驳回")>
	Public Property Status As Integer?

	''' <summary>
	''' 删除标记
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("删除标记")>
	Public Property IsDeleted As Integer?

	''' <summary>
	''' 审批模板ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("审批模板ID")>
	Public Property EID As Integer?

	''' <summary>
	''' 审批提交人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("审批提交人")>
	Public Property Submitter As Integer?

	''' <summary>
	''' 审批提交时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("审批提交时间")>
	Public Property SubmitDate As DateTime?

	''' <summary>
	''' 主合同工作内容 注：从委托合同列表中取工作内容（服务内容）数据
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("主合同工作内容 注：从委托合同列表中取工作内容（服务内容）数据")>
	Public Property WorkCont As String

	''' <summary>
	''' 项目性质
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目性质")>
	Public Property ProjNature As String

	''' <summary>
	''' 任务类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务类型")>
	Public Property TaskType As String

	''' <summary>
	''' 结构类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("结构类型")>
	Public Property StrucType As String

	''' <summary>
	''' 分包/协作 工作内容
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("分包/协作 工作内容")>
	Public Property CollCont As String

	''' <summary>
	''' 合同取费类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同取费类型")>
	Public Property FeeType As Integer?

	''' <summary>
	''' 合作业务类型（可多选）：注：0-造价咨询；1-招标代理;3-其他
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合作业务类型（可多选）：注：0-造价咨询；1-招标代理;3-其他")>
	Public Property BusType As String

	''' <summary>
	''' 签定时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("签定时间")>
	Public Property SignDate As DateTime?

	''' <summary>
	''' 有效期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("有效期")>
	Public Property ExpiryDate As DateTime?

	''' <summary>
	''' 约定付款比例
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("约定付款比例")>
	Public Property AgreedRatio As String

	''' <summary>
	''' 累计收款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("累计收款")>
	Public Property ReceiptSum As Decimal?

	Public Sub New()
		Me.CollType = 0
		Me.ContractSum = 0
		Me.PaymentSum = 0
		Me.EstimateSum = 0
		Me.Status = 0
		Me.IsDeleted = 0
		Me.EID = 0
		Me.BusType = 0
		Me.ReceiptSum = 0
	End Sub

End Class

Partial Public Class ProjectCollContractsMap
    Inherits EntityTypeConfiguration(Of ProjectCollContractsModel)
	Public Sub New()
		Me.ToTable("ProjectCollContracts")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.CollCode)
		Me.Property(Function(t) t.CollName)
		Me.Property(Function(t) t.CollType)
		Me.Property(Function(t) t.CollUnitID)
		Me.Property(Function(t) t.CollUnitName)
		Me.Property(Function(t) t.EntrustID)
		Me.Property(Function(t) t.EntrustCode)
		Me.Property(Function(t) t.EntrustName)
		Me.Property(Function(t) t.EntrustedSum).HasPrecision(18, 6)
		Me.Property(Function(t) t.EntrustAssignID)
		Me.Property(Function(t) t.EntrustAssignName)
		Me.Property(Function(t) t.EntrustBranchID)
		Me.Property(Function(t) t.EntrustBranchName)
		Me.Property(Function(t) t.ContractSum).HasPrecision(18, 6)
		Me.Property(Function(t) t.PaymentSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.EstimateSum).HasPrecision(18, 3)
		Me.Property(Function(t) t.ClientID)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.Period)
		Me.Property(Function(t) t.BranchID)
		Me.Property(Function(t) t.BranchName)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.Status)
		Me.Property(Function(t) t.IsDeleted)
		Me.Property(Function(t) t.EID)
		Me.Property(Function(t) t.Submitter)
		Me.Property(Function(t) t.SubmitDate)
		Me.Property(Function(t) t.WorkCont)
		Me.Property(Function(t) t.ProjNature)
		Me.Property(Function(t) t.TaskType)
		Me.Property(Function(t) t.StrucType)
		Me.Property(Function(t) t.CollCont)
		Me.Property(Function(t) t.FeeType)
		Me.Property(Function(t) t.BusType)
		Me.Property(Function(t) t.SignDate)
		Me.Property(Function(t) t.ExpiryDate)
		Me.Property(Function(t) t.AgreedRatio)
		Me.Property(Function(t) t.ReceiptSum).HasPrecision(18, 3)

	End Sub
End Class
