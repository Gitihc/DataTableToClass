
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectMemberWorkHoursModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目ID")>
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
	''' 填报人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("填报人ID")>
	Public Property UserID As Integer?

	''' <summary>
	''' 填报日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("填报日期")>
	Public Property WordDate As DateTime?

	''' <summary>
	''' 工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工时")>
	Public Property WorkHours As Decimal?

	''' <summary>
	''' 当周的结束时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("当周的结束时间")>
	Public Property StartDate As DateTime?

	''' <summary>
	''' 当周的开始时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("当周的开始时间")>
	Public Property ExpirDate As DateTime?

	''' <summary>
	''' 周日工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周日工时")>
	Public Property SunHours As Decimal?

	''' <summary>
	''' 周一工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周一工时")>
	Public Property MonHours As Decimal?

	''' <summary>
	''' 周二工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周二工时")>
	Public Property TueHours As Decimal?

	''' <summary>
	''' 周三工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周三工时")>
	Public Property WedHours As Decimal?

	''' <summary>
	''' 周四工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周四工时")>
	Public Property ThuHours As Decimal?

	''' <summary>
	''' 周五工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周五工时")>
	Public Property FriHours As Decimal?

	''' <summary>
	''' 周六工时
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("周六工时")>
	Public Property SatHours As Decimal?

	''' <summary>
	''' 备注 注：以JSON格式保存当周的备注信息
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("备注 注：以JSON格式保存当周的备注信息")>
	Public Property WorkNote As String

	''' <summary>
	''' 批准人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("批准人ID")>
	Public Property ApprovalID As Integer?

	Public Sub New()
	End Sub

End Class

Partial Public Class ProjectMemberWorkHoursMap
    Inherits EntityTypeConfiguration(Of ProjectMemberWorkHoursModel)
	Public Sub New()
		Me.ToTable("ProjectMemberWorkHours")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.TID)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.WordDate)
		Me.Property(Function(t) t.WorkHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.StartDate)
		Me.Property(Function(t) t.ExpirDate)
		Me.Property(Function(t) t.SunHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.MonHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.TueHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.WedHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.ThuHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.FriHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.SatHours).HasPrecision(18, 1)
		Me.Property(Function(t) t.WorkNote)
		Me.Property(Function(t) t.ApprovalID)

	End Sub
End Class
