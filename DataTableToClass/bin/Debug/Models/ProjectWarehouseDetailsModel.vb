
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectWarehouseDetailsModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 所属项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PID As Integer?

	''' <summary>
	''' 所属合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CID As Integer?

	''' <summary>
	''' 关联单据材料ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RID As Integer?

	''' <summary>
	''' 入库单ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WID As Integer?

	''' <summary>
	''' 引用材料ID 注：是指从总控计划中引的材料ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property QID As Integer?

	''' <summary>
	''' 材料分类ID  对应 ProjectMaterialClassify 表
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Classify As Integer?

	''' <summary>
	''' 是否变更材料 注：0-否；1-是
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsChanged As Integer?

	''' <summary>
	''' 材料编码
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property materialCode As String

	''' <summary>
	''' 材料名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property materialName As String

	''' <summary>
	''' 型号规格
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property materialModel As String

	''' <summary>
	''' 品牌
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property materialBrand As String

	''' <summary>
	''' 单位
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Unit As String

	''' <summary>
	''' 入库单价
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Price As Decimal?

	''' <summary>
	''' 采购单价
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property cgPrice As Decimal?

	''' <summary>
	''' 税率
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Rate As Decimal?

	''' <summary>
	''' 税前价 注：税前价=单价÷（1+税率÷100）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PrePrice As Decimal?

	''' <summary>
	''' 采购数量
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property cgAmount As Decimal?

	''' <summary>
	''' 已入库数量
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ykAmount As Decimal?

	''' <summary>
	''' 本次进/出库数量
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property bcAmount As Decimal?

	''' <summary>
	''' 原始领用数量（仅出库单使用）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property obcAmount As Decimal?

	''' <summary>
	''' 库区ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PartitionID As Integer?

	''' <summary>
	''' 处理类别 注：0-正常出入库;1-退货；2-折价；3-报废
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property HTypeID As Integer?

	''' <summary>
	''' 供应商ID 注：余料处理单使用，退货时要选择供应商
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property SupplierID As Integer?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

	Public Sub New()
		Me.CID = 0
		Me.IsChanged = 0
		Me.Price = 0
		Me.cgPrice = 0
		Me.Rate = 0
		Me.PrePrice = 0
		Me.cgAmount = 0
		Me.ykAmount = 0
		Me.bcAmount = 0
		Me.obcAmount = 0
		Me.HTypeID = 0
	End Sub

End Class

Partial Public Class ProjectWarehouseDetailsMap
    Inherits EntityTypeConfiguration(Of ProjectWarehouseDetailsModel)
	Public Sub New()
		Me.ToTable("ProjectWarehouseDetails")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.CID)
		Me.Property(Function(t) t.RID)
		Me.Property(Function(t) t.WID)
		Me.Property(Function(t) t.QID)
		Me.Property(Function(t) t.Classify)
		Me.Property(Function(t) t.IsChanged)
		Me.Property(Function(t) t.materialCode)
		Me.Property(Function(t) t.materialName)
		Me.Property(Function(t) t.materialModel)
		Me.Property(Function(t) t.materialBrand)
		Me.Property(Function(t) t.Unit)
		Me.Property(Function(t) t.Price).HasPrecision(18, 6)
		Me.Property(Function(t) t.cgPrice).HasPrecision(18, 6)
		Me.Property(Function(t) t.Rate).HasPrecision(18, 6)
		Me.Property(Function(t) t.PrePrice).HasPrecision(18, 7)
		Me.Property(Function(t) t.cgAmount).HasPrecision(18, 6)
		Me.Property(Function(t) t.ykAmount).HasPrecision(18, 6)
		Me.Property(Function(t) t.bcAmount).HasPrecision(18, 6)
		Me.Property(Function(t) t.obcAmount).HasPrecision(18, 6)
		Me.Property(Function(t) t.PartitionID)
		Me.Property(Function(t) t.HTypeID)
		Me.Property(Function(t) t.SupplierID)
		Me.Property(Function(t) t.Note)

	End Sub
End Class
