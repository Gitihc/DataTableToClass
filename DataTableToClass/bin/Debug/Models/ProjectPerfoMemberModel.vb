
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerfoMemberModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 关联绩效台账表ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PerforID As Integer?

	''' <summary>
	''' 成员ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UserID As Integer?

	''' <summary>
	''' 是否选择
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsSelected As Integer?

	Public Sub New()
	End Sub

End Class

Partial Public Class ProjectPerfoMemberMap
    Inherits EntityTypeConfiguration(Of ProjectPerfoMemberModel)
	Public Sub New()
		Me.ToTable("ProjectPerfoMember")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.PerforID)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.IsSelected)

	End Sub
End Class
