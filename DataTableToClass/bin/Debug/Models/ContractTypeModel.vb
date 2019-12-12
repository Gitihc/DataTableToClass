
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ContractTypeModel


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
	Public Property Name As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

End Class

Partial Public Class ContractTypeMap
    Inherits EntityTypeConfiguration(Of ContractTypeModel)
	Public Sub New()
		Me.ToTable("ContractType")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.Code)
		Me.Property(Function(t) t.Name)
		Me.Property(Function(t) t.Note)

	End Sub
End Class
