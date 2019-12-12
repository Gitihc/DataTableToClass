
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectCollAgenciesModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 协作机构名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollName As String

	''' <summary>
	''' 地区ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Region As Integer?

	''' <summary>
	''' 联系人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Contacts As String

	''' <summary>
	''' 联系地址
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Address As String

	''' <summary>
	''' 邮编
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Postcode As String

	''' <summary>
	''' 联系电话
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Telephone As String

	''' <summary>
	''' 电子邮箱
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EMail As String

	''' <summary>
	''' 创建人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 创建时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 协作类型: 0-合作;1-分包
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Type As Integer?

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
	''' 删除标记：1-已删除
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsDeleted As Integer?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Remark As String

	''' <summary>
	''' 执照编号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property LicNumber As String

	''' <summary>
	''' 营业范围
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BusiRange As String

	''' <summary>
	''' CollReason
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CollReason As String

End Class

Partial Public Class ProjectCollAgenciesMap
    Inherits EntityTypeConfiguration(Of ProjectCollAgenciesModel)
	Public Sub New()
		Me.ToTable("ProjectCollAgencies")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.CollName)
		Me.Property(Function(t) t.Region)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.Address)
		Me.Property(Function(t) t.Postcode)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.EMail)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.Type)
		Me.Property(Function(t) t.Status)
		Me.Property(Function(t) t.EID)
		Me.Property(Function(t) t.Submitter)
		Me.Property(Function(t) t.SubmitDate)
		Me.Property(Function(t) t.IsDeleted)
		Me.Property(Function(t) t.Remark)
		Me.Property(Function(t) t.LicNumber)
		Me.Property(Function(t) t.BusiRange)
		Me.Property(Function(t) t.CollReason)

	End Sub
End Class
