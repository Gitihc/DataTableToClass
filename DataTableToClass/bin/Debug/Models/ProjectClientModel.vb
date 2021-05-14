
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectClientModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ClientName As String

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
	''' 入库日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EntryDate As DateTime?

	''' <summary>
	''' 所属集团ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property GroupID As Integer?

	''' <summary>
	''' 所在地区ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Region As String

	''' <summary>
	''' 联系人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Contacts As String

	''' <summary>
	''' 联系人岗位
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ContactPost As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Address As String

	''' <summary>
	''' 
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
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property EMail As String

	''' <summary>
	''' 纳税识别号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TaxNumber As String

	''' <summary>
	''' 开户行
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BankName As String

	''' <summary>
	''' 开户行帐号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BankAccount As String

	''' <summary>
	''' 所属部门ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property BranchID As Integer?

	''' <summary>
	''' 跟进人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FollowID As Integer?

	''' <summary>
	''' 创建人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Remark As String

	Public Sub New()
		Me.Contacts = String.Empty
		Me.Address = String.Empty
		Me.Postcode = String.Empty
		Me.Telephone = String.Empty
		Me.EMail = String.Empty
		Me.CreateDate = Now
	End Sub

End Class

Partial Public Class ProjectClientMap
    Inherits EntityTypeConfiguration(Of ProjectClientModel)
	Public Sub New()
		Me.ToTable("ProjectClient")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.LicNumber)
		Me.Property(Function(t) t.BusiRange)
		Me.Property(Function(t) t.EntryDate)
		Me.Property(Function(t) t.GroupID)
		Me.Property(Function(t) t.Region)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.ContactPost)
		Me.Property(Function(t) t.Address)
		Me.Property(Function(t) t.Postcode)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.EMail)
		Me.Property(Function(t) t.TaxNumber)
		Me.Property(Function(t) t.BankName)
		Me.Property(Function(t) t.BankAccount)
		Me.Property(Function(t) t.BranchID)
		Me.Property(Function(t) t.FollowID)
		Me.Property(Function(t) t.CreateID)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.Remark)

	End Sub
End Class
