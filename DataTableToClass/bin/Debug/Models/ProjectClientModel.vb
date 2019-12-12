
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
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Region As Integer?

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
	Public Property Address As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Postcode As String

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
	Public Property EMail As String

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Remark As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property GroupID As Integer?

End Class

Partial Public Class ProjectClientMap
    Inherits EntityTypeConfiguration(Of ProjectClientModel)
	Public Sub New()
		Me.ToTable("ProjectClient")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.Region)
		Me.Property(Function(t) t.Contacts)
		Me.Property(Function(t) t.Address)
		Me.Property(Function(t) t.Postcode)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.EMail)
		Me.Property(Function(t) t.Remark)
		Me.Property(Function(t) t.GroupID)

	End Sub
End Class
