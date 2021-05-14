
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerforDetailMemberModel


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
	''' 关联绩效明细ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property DetailID As Integer?

	''' <summary>
	''' 人员ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UserID As Integer?

	''' <summary>
	''' 角色ID 注：0-编制人员；1-项目经理；2-二审；3-三审
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RoleID As Integer?

	''' <summary>
	''' 绩效工资基数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Base As Decimal?

	''' <summary>
	''' 绩效系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Ratio As Decimal?

	''' <summary>
	''' 绩效工资
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PerTotal As Decimal?

	Public Sub New()
	End Sub

End Class

Partial Public Class ProjectPerforDetailMemberMap
    Inherits EntityTypeConfiguration(Of ProjectPerforDetailMemberModel)
	Public Sub New()
		Me.ToTable("ProjectPerforDetailMember")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.PerforID)
		Me.Property(Function(t) t.DetailID)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.RoleID)
		Me.Property(Function(t) t.Base)
		Me.Property(Function(t) t.Ratio)
		Me.Property(Function(t) t.PerTotal)

	End Sub
End Class
