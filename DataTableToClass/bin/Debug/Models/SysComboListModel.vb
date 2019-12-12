
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SysComboListModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' ComboTypeID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TID As Integer?

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
	Public Property Value As Integer?

End Class

Partial Public Class SysComboListMap
    Inherits EntityTypeConfiguration(Of SysComboListModel)
	Public Sub New()
		Me.ToTable("SysComboList")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.TID)
		Me.Property(Function(t) t.Name)
		Me.Property(Function(t) t.Value)

	End Sub
End Class
