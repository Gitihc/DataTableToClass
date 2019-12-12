
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectCollContractPaymentModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 协作合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CID As Integer?

	''' <summary>
	''' 付款单编号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Code As String

	''' <summary>
	''' 协作合同编号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollCode As String

	''' <summary>
	''' 协作合同名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollName As String

	''' <summary>
	''' 协作单位名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollUnitName As String

	''' <summary>
	''' 协作单位联系人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Contacts As String

	''' <summary>
	''' 协作单位联系电话
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Telephone As String

	''' <summary>
	''' 协作合同负责人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollAssignName As String

	''' <summary>
	''' 协作合同部门
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollBranchName As String

	''' <summary>
	''' 协作工作内容
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollContent As String

	''' <summary>
	''' 协作合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollTotal As Decimal?

	''' <summary>
	''' 累计已支付金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollPaySum As Decimal?

	''' <summary>
	''' 我委托合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusID As Integer?

	''' <summary>
	''' 委托合同编号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusCode As String

	''' <summary>
	''' 委托合同名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusName As String

	''' <summary>
	''' 委托合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusTotal As Decimal?

	''' <summary>
	''' 委托合同收款金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusRecSum As Decimal?

	''' <summary>
	''' 本次申请支付金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ApplySum As Decimal?

	''' <summary>
	''' 支付年份
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayYear As String

	''' <summary>
	''' 支付日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayDate As DateTime?

	''' <summary>
	''' 质量要求：选择 0-准确；1-合同；2大概准确
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Quality As Integer?

	''' <summary>
	''' 项目进度：选择 0-优；1-良；2-中；3-差
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Progress As Integer?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

	''' <summary>
	''' 所属部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BranchID As Integer?

	''' <summary>
	''' 创建人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 创建日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 状态：０－新建；１－审批中；２－已审结；３－已驳回
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Status As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EID As Integer?

	''' <summary>
	''' 审批提交人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Submitter As Integer?

	''' <summary>
	''' 审批提交时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property SubmitDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsDeleted As Integer?

	''' <summary>
	''' 工期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Period As String

	''' <summary>
	''' 此项任务预计收入
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EstimateSum As Decimal?

	''' <summary>
	''' 项目总造价
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectTotal As Decimal?

	''' <summary>
	''' 项目性质
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjNature As String

	''' <summary>
	''' 任务类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TaskType As String

	''' <summary>
	''' 结构类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property StrucType As String

	''' <summary>
	''' 核对要求
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CheckRequi As String

	''' <summary>
	''' 项目难度
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectDiffic As String

	''' <summary>
	''' 其他要求
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OtherRequi As String

End Class

Partial Public Class ProjectCollContractPaymentMap
    Inherits EntityTypeConfiguration(Of ProjectCollContractPaymentModel)
	Public Sub New()
		Me.ToTable("ProjectCollContractPayment")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.CID)
		Me.Property(Function(t) t.Code)
		Me.Property(Function(t) t.CollCode)
		Me.Property(Function(t) t.CollName)
		Me.Property(Function(t) t.CollUnitName)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.CollAssignName)
		Me.Property(Function(t) t.CollBranchName)
		Me.Property(Function(t) t.CollContent)
		Me.Property(Function(t) t.CollTotal)
		Me.Property(Function(t) t.CollPaySum)
		Me.Property(Function(t) t.EntrusID)
		Me.Property(Function(t) t.EntrusCode)
		Me.Property(Function(t) t.EntrusName)
		Me.Property(Function(t) t.EntrusTotal)
		Me.Property(Function(t) t.EntrusRecSum)
		Me.Property(Function(t) t.ApplySum)
		Me.Property(Function(t) t.PayYear)
		Me.Property(Function(t) t.PayDate)
		Me.Property(Function(t) t.Quality)
		Me.Property(Function(t) t.Progress)
		Me.Property(Function(t) t.Note)
		Me.Property(Function(t) t.BranchID)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.Status)
		Me.Property(Function(t) t.EID)
		Me.Property(Function(t) t.Submitter)
		Me.Property(Function(t) t.SubmitDate)
		Me.Property(Function(t) t.IsDeleted)
		Me.Property(Function(t) t.Period)
		Me.Property(Function(t) t.EstimateSum)
		Me.Property(Function(t) t.ProjectTotal)
		Me.Property(Function(t) t.ProjNature)
		Me.Property(Function(t) t.TaskType)
		Me.Property(Function(t) t.StrucType)
		Me.Property(Function(t) t.CheckRequi)
		Me.Property(Function(t) t.ProjectDiffic)
		Me.Property(Function(t) t.OtherRequi)

	End Sub
End Class
