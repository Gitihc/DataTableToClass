
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectDeductionAccountModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 所属项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("所属项目ID")>
	Public Property PID As Integer?

	''' <summary>
	''' 所属合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("所属合同ID")>
	Public Property CID As Integer?

	''' <summary>
	''' 付款申请单ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("付款申请单ID")>
	Public Property AID As Integer?

	''' <summary>
	''' 合同类型ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同类型ID")>
	Public Property TypeID As Integer?

	''' <summary>
	''' 合同供应商ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同供应商ID")>
	Public Property SupplierID As Integer?

	''' <summary>
	''' 合同供应商名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("合同供应商名称")>
	Public Property SupplierName As String

	''' <summary>
	''' 扣款款项ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("扣款款项ID")>
	Public Property DeductionID As Integer?

	''' <summary>
	''' 扣款款项名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("扣款款项名称")>
	Public Property DeductionName As String

	''' <summary>
	''' 子扣款项ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("子扣款项ID")>
	Public Property SubItemID As Integer?

	''' <summary>
	''' 子扣款项名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("子扣款项名称")>
	Public Property SubItemName As String

	''' <summary>
	''' 扣款金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("扣款金额")>
	Public Property DeductionSum As Decimal?

	''' <summary>
	''' 扣款日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("扣款日期")>
	Public Property DeductionDate As DateTime?

	''' <summary>
	''' 扣款说明
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("扣款说明")>
	Public Property DeductionNote As String

	''' <summary>
	''' 税率 注：代管合同有用到
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("税率 注：代管合同有用到")>
	Public Property TaxRate As Decimal?

	''' <summary>
	''' 状态 注：0-新建；1-已确认；2-核销中；3-已核销
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("状态 注：0-新建；1-已确认；2-核销中；3-已核销")>
	Public Property State As Integer?

	''' <summary>
	''' 创建人（扣款人）ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建人（扣款人）ID")>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 创建时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("创建时间")>
	Public Property CreateDate As DateTime?

	Public Sub New()
		Me.TaxRate = 0
		Me.State = 0
	End Sub

End Class

Partial Public Class ProjectDeductionAccountMap
    Inherits EntityTypeConfiguration(Of ProjectDeductionAccountModel)
	Public Sub New()
		Me.ToTable("ProjectDeductionAccount")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.CID)
		Me.Property(Function(t) t.AID)
		Me.Property(Function(t) t.TypeID)
		Me.Property(Function(t) t.SupplierID)
		Me.Property(Function(t) t.SupplierName)
		Me.Property(Function(t) t.DeductionID)
		Me.Property(Function(t) t.DeductionName)
		Me.Property(Function(t) t.SubItemID)
		Me.Property(Function(t) t.SubItemName)
		Me.Property(Function(t) t.DeductionSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.DeductionDate)
		Me.Property(Function(t) t.DeductionNote)
		Me.Property(Function(t) t.TaxRate).HasPrecision(18, 4)
		Me.Property(Function(t) t.State)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.CreateDate)

	End Sub
End Class
