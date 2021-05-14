
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectTaskModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property TaskName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property Description As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property RowVersion As Byte()

	Public Sub New()
		Me.CreateDate = Now
	End Sub

End Class

Partial Public Class ProjectTaskMap
    Inherits EntityTypeConfiguration(Of ProjectTaskModel)
	Public Sub New()
		Me.ToTable("ProjectTask")
		Me.HasKey(Function(s) s.ID)
				Me.Property(Function(t) t.TaskName)
				Me.Property(Function(t) t.CreateDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.Description)
				Me.Property(Function(t) t.RowVersion).IsRowVersion()
	End Sub
End Class
