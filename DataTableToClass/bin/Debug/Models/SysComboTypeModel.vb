
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SysComboTypeModel


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
	Public Property TypeName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

End Class

Partial Public Class SysComboTypeMap
    Inherits EntityTypeConfiguration(Of SysComboTypeModel)
	Public Sub New()
		Me.ToTable("SysComboType")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.TypeName)
		Me.Property(Function(t) t.Note)

	End Sub
End Class
