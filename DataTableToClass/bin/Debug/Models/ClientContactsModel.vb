
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ClientContactsModel


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
	Public Property CID As Integer?

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
	Public Property Contact As String

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
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Enable As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsMain As Integer?

End Class

Partial Public Class ClientContactsMap
    Inherits EntityTypeConfiguration(Of ClientContactsModel)
	Public Sub New()
		Me.ToTable("ClientContacts")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.CID)
		Me.Property(Function(t) t.Code)
		Me.Property(Function(t) t.Contact)
		Me.Property(Function(t) t.Telephone)
		Me.Property(Function(t) t.EMail)
		Me.Property(Function(t) t.Enable)
		Me.Property(Function(t) t.IsMain)

	End Sub
End Class
