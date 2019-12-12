
Imports System.Data.Entity.ModelConfiguration

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
	Public Property ID As Integer

	''' <summary>
	''' 关联项目ＩＤ
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 父合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Code As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ContractName As String

	''' <summary>
	''' 合同类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ContractType As Integer?

	''' <summary>
	''' 合同金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property SumMoney As Decimal?

	''' <summary>
	''' 累计收款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayMoney As Decimal?

	''' <summary>
	''' 应收款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property receivables As Decimal?

	''' <summary>
	''' 签定时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property SignDate As DateTime?

	''' <summary>
	''' 开始日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property StartDate As DateTime?

	''' <summary>
	''' 截止日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FinishDate As DateTime?

	''' <summary>
	''' 委托单位ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ClientID As Integer?

	''' <summary>
	''' 所属部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AffiliateID As Integer?

	''' <summary>
	''' 履约部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PerformanceID As String

	''' <summary>
	''' 经办人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AgencyID As Integer?

	''' <summary>
	''' 参与人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ParticipantID As String

	''' <summary>
	''' 是否已备案
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsRecord As Integer?

	''' <summary>
	''' 状态：０－新建；１－履约；２－中止；３－关闭
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Status As Integer?

	''' <summary>
	''' 合同主要条款
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Clause As String

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Remark As String

	''' <summary>
	''' 工程名称[默认合同名称]
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectName As String

	''' <summary>
	''' 工程类别
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectType As Integer?

	''' <summary>
	''' 项目所在地
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectSite As String

	''' <summary>
	''' 项目地址
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectAddr As String

	''' <summary>
	''' 总投资（万元）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Investment As Decimal?

	''' <summary>
	''' 借阅标志：0-归还；1-借出
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BorrowStatus As Integer?

	''' <summary>
	''' 生成日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsDeleted As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Submitter As Integer?

	''' <summary>
	''' 
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
	Public Property EntrusID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntrusProject As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectScale As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ConLocation As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Contacts As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Telephone As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsCooperate As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AmountType As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BusinessType As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AccessMode As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property InveMoney As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ReceMoney As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property InvoMoney As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ReceRate As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ClientName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TextAndCause As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ChangeClause As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ServiceCont As String

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
		Me.AmountType = 0
		Me.BusinessType = 0
		Me.AccessMode = 0
		Me.InveMoney = 0
		Me.ReceMoney = 0
		Me.InvoMoney = 0
		Me.ReceRate = 0
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
		Me.Property(Function(t) t.SumMoney)
		Me.Property(Function(t) t.PayMoney)
		Me.Property(Function(t) t.receivables)
		Me.Property(Function(t) t.SignDate)
		Me.Property(Function(t) t.StartDate)
		Me.Property(Function(t) t.FinishDate)
		Me.Property(Function(t) t.ClientID)
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
		Me.Property(Function(t) t.Investment)
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
		Me.Property(Function(t) t.AmountType)
		Me.Property(Function(t) t.BusinessType)
		Me.Property(Function(t) t.AccessMode)
		Me.Property(Function(t) t.InveMoney)
		Me.Property(Function(t) t.ReceMoney)
		Me.Property(Function(t) t.InvoMoney)
		Me.Property(Function(t) t.ReceRate)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.TextAndCause)
		Me.Property(Function(t) t.ChangeClause)
		Me.Property(Function(t) t.ServiceCont)

	End Sub
End Class
