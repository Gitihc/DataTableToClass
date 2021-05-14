
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerforWagesModel


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
	Public Property PayYear As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WagesSum As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NetpaySum As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property SurplusSum As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreatorID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Status As Integer?

	Public Sub New()
	End Sub

End Class

Partial Public Class ProjectPerforWagesMap
    Inherits EntityTypeConfiguration(Of ProjectPerforWagesModel)
	Public Sub New()
		Me.ToTable("ProjectPerforWages")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PayYear)
		Me.Property(Function(t) t.PayDate)
		Me.Property(Function(t) t.PayName)
		Me.Property(Function(t) t.WagesSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.NetpaySum).HasPrecision(18, 2)
		Me.Property(Function(t) t.SurplusSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.CreatorID)
		Me.Property(Function(t) t.Status)

	End Sub
End Class
