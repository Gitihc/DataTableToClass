
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectContractModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 关联项目ＩＤ
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("关联项目ＩＤ")>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 父合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("父合同ID")>
	Public Property PID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property Code As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ContractName As String

	''' <summary>
	''' 合同类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同类型")>
	Public Property ContractType As String

	''' <summary>
	''' 合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同金额")>
	Public Property SumMoney As Decimal?

	''' <summary>
	''' 累计收款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("累计收款")>
	Public Property PayMoney As Decimal?

	''' <summary>
	''' 应收款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("应收款")>
	Public Property Receivables As Decimal?

	''' <summary>
	''' 签定时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("签定时间")>
	Public Property SignDate As DateTime?

	''' <summary>
	''' 开始日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("开始日期")>
	Public Property StartDate As DateTime?

	''' <summary>
	''' 截止日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("截止日期")>
	Public Property FinishDate As DateTime?

	''' <summary>
	''' 委托单位ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位ID")>
	Public Property ClientID As Integer?

	''' <summary>
	''' 委托单位名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位名称")>
	Public Property ClientName As String

	''' <summary>
	''' 所属部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("所属部门ID")>
	Public Property AffiliateID As Integer?

	''' <summary>
	''' 履约部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("履约部门ID")>
	Public Property PerformanceID As String

	''' <summary>
	''' 经办人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("经办人")>
	Public Property AgencyID As Integer?

	''' <summary>
	''' 参与人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("参与人ID")>
	Public Property ParticipantID As String

	''' <summary>
	''' 是否已备案
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("是否已备案")>
	Public Property IsRecord As Integer?

	''' <summary>
	''' 状态： ０－新建；１－审批中；２－已审结(履约)；３－已驳回；4－中止；5－关闭
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("状态： ０－新建；１－审批中；２－已审结(履约)；３－已驳回；4－中止；5－关闭")>
	Public Property Status As Integer?

	''' <summary>
	''' 合同主要条款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同主要条款")>
	Public Property Clause As String

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("备注")>
	Public Property Remark As String

	''' <summary>
	''' 工程名称[默认合同名称]
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工程名称[默认合同名称]")>
	Public Property ProjectName As String

	''' <summary>
	''' 工程类别
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工程类别")>
	Public Property ProjectType As String

	''' <summary>
	''' 项目所在地
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目所在地")>
	Public Property ProjectSite As String

	''' <summary>
	''' 项目地址
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目地址")>
	Public Property ProjectAddr As String

	''' <summary>
	''' 总投资（万元）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("总投资（万元）")>
	Public Property Investment As Decimal?

	''' <summary>
	''' 借阅标志：0-归还；1-借出
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("借阅标志：0-归还；1-借出")>
	Public Property BorrowStatus As Integer?

	''' <summary>
	''' 生成日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("生成日期")>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
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
	''' 委托项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托项目ID")>
	Public Property EntrusID As Integer?

	''' <summary>
	''' 委托项目名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托项目名称")>
	Public Property EntrusProject As String

	''' <summary>
	''' 工程规模
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工程规模")>
	Public Property ProjectScale As String

	''' <summary>
	''' 建设地点
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("建设地点")>
	Public Property ConLocation As String

	''' <summary>
	''' 委托单位联系人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位联系人")>
	Public Property Contacts As String

	''' <summary>
	''' 委托单位联系电话
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("委托单位联系电话")>
	Public Property Telephone As String

	''' <summary>
	''' 是否合作
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("是否合作")>
	Public Property IsCooperate As Integer?

	''' <summary>
	''' 合作合同ID 注：如果该委托合同是合作的（合作选项为真），在委托合同基本信息中需要选择对应的合作合同，建立合作的委托合同与合作合同的关联。
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合作合同ID 注：如果该委托合同是合作的（合作选项为真），在委托合同基本信息中需要选择对应的合作合同，建立合作的委托合同与合作合同的关联。")>
	Public Property CollContractID As Integer?

	''' <summary>
	''' 金额类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("金额类型")>
	Public Property AmountType As Integer?

	''' <summary>
	''' 业务类型：造价/招标/其他
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("业务类型：造价/招标/其他")>
	Public Property BusinessType As Integer?

	''' <summary>
	''' 获取方式 ：公开/邀请/直委
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("获取方式 ：公开/邀请/直委")>
	Public Property AccessMode As Integer?

	''' <summary>
	''' 投资金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("投资金额")>
	Public Property InveMoney As Decimal?

	''' <summary>
	''' 收款金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("收款金额")>
	Public Property ReceMoney As Decimal?

	''' <summary>
	''' 开票金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("开票金额")>
	Public Property InvoMoney As Decimal?

	''' <summary>
	''' 收款率
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("收款率")>
	Public Property ReceRate As Decimal?

	''' <summary>
	''' 合同采用文本及原因
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同采用文本及原因")>
	Public Property TextAndCause As String

	''' <summary>
	''' 修改条款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("修改条款")>
	Public Property ChangeClause As String

	''' <summary>
	''' 工作内容（服务内容）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工作内容（服务内容）")>
	Public Property ServiceCont As String

	''' <summary>
	''' 合同性质 注：0-单项委托；1-全过程；2-框架合同
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同性质 注：0-单项委托；1-全过程；2-框架合同")>
	Public Property ConNature As Integer?

	''' <summary>
	''' 业绩标识 注：0-否；1-是
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("业绩标识 注：0-否；1-是")>
	Public Property IsPerforma As Integer?

	''' <summary>
	''' 合同份数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同份数")>
	Public Property ConCount As Integer?

	''' <summary>
	''' 合同文件上传标记 注：0-未上传；1-已上传
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同文件上传标记 注：0-未上传；1-已上传")>
	Public Property ConFiles As Integer?

	''' <summary>
	''' 中标通知书上传标记 注：0-未上传；1-已上传
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("中标通知书上传标记 注：0-未上传；1-已上传")>
	Public Property WinNotice As Integer?

	Public Sub New()
		Me.ProjectID = -1
		Me.IsRecord = 0
		Me.Status = 0
		Me.ProjectName = String.Empty
		Me.ProjectSite = String.Empty
		Me.ProjectAddr = String.Empty
		Me.Investment = 0
		Me.BorrowStatus = 0
		Me.CreateDate = Now
		Me.IsDeleted = 0
		Me.EID = 0
		Me.IsCooperate = 0
		Me.CollContractID = 0
		Me.AmountType = 0
		Me.AccessMode = 0
		Me.InveMoney = 0
		Me.ReceMoney = 0
		Me.InvoMoney = 0
		Me.ReceRate = 0
		Me.ConNature = 0
		Me.IsPerforma = 0
		Me.ConCount = 0
		Me.ConFiles = 0
		Me.WinNotice = 0
	End Sub

End Class

Partial Public Class ProjectContractMap
    Inherits EntityTypeConfiguration(Of ProjectContractModel)
	Public Sub New()
		Me.ToTable("ProjectContract")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.Code)
		Me.Property(Function(t) t.ContractName)
		Me.Property(Function(t) t.ContractType)
		Me.Property(Function(t) t.SumMoney).HasPrecision(18, 2)
		Me.Property(Function(t) t.PayMoney).HasPrecision(18, 2)
		Me.Property(Function(t) t.Receivables).HasPrecision(18, 2)
		Me.Property(Function(t) t.SignDate)
		Me.Property(Function(t) t.StartDate)
		Me.Property(Function(t) t.FinishDate)
		Me.Property(Function(t) t.ClientID)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.AffiliateID)
		Me.Property(Function(t) t.PerformanceID)
		Me.Property(Function(t) t.AgencyID)
		Me.Property(Function(t) t.ParticipantID)
		Me.Property(Function(t) t.IsRecord)
		Me.Property(Function(t) t.Status)
		Me.Property(Function(t) t.Clause)
		Me.Property(Function(t) t.Remark)
		Me.Property(Function(t) t.ProjectName)
		Me.Property(Function(t) t.ProjectType)
		Me.Property(Function(t) t.ProjectSite)
		Me.Property(Function(t) t.ProjectAddr)
		Me.Property(Function(t) t.Investment).HasPrecision(18, 6)
		Me.Property(Function(t) t.BorrowStatus)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.IsDeleted)
		Me.Property(Function(t) t.EID)
		Me.Property(Function(t) t.Submitter)
		Me.Property(Function(t) t.SubmitDate)
		Me.Property(Function(t) t.EntrusID)
		Me.Property(Function(t) t.EntrusProject)
		Me.Property(Function(t) t.ProjectScale)
		Me.Property(Function(t) t.ConLocation)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.IsCooperate)
		Me.Property(Function(t) t.CollContractID)
		Me.Property(Function(t) t.AmountType)
		Me.Property(Function(t) t.BusinessType)
		Me.Property(Function(t) t.AccessMode)
		Me.Property(Function(t) t.InveMoney).HasPrecision(18, 6)
		Me.Property(Function(t) t.ReceMoney).HasPrecision(18, 3)
		Me.Property(Function(t) t.InvoMoney).HasPrecision(18, 6)
		Me.Property(Function(t) t.ReceRate).HasPrecision(18, 6)
		Me.Property(Function(t) t.TextAndCause)
		Me.Property(Function(t) t.ChangeClause)
		Me.Property(Function(t) t.ServiceCont)
		Me.Property(Function(t) t.ConNature)
		Me.Property(Function(t) t.IsPerforma)
		Me.Property(Function(t) t.ConCount)
		Me.Property(Function(t) t.ConFiles)
		Me.Property(Function(t) t.WinNotice)

	End Sub
End Class
