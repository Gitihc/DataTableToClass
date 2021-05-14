
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectTaskPlanWorkHoursModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 项目
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目")>
	Public Property PID As Integer?

	''' <summary>
	''' 任务ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务ID")>
	Public Property TID As Integer?

	''' <summary>
	''' 成员ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("成员ID")>
	Public Property UserID As Integer?

	''' <summary>
	''' 预计工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("预计工时")>
	Public Property WorkHours As Decimal?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("备注")>
	Public Property WorkNote As String

	Public Sub New()
	End Sub

End Class

Partial Public Class ProjectTaskPlanWorkHoursMap
    Inherits EntityTypeConfiguration(Of ProjectTaskPlanWorkHoursModel)
	Public Sub New()
		Me.ToTable("ProjectTaskPlanWorkHours")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.TID)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.WorkHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.WorkNote)

	End Sub
End Class
