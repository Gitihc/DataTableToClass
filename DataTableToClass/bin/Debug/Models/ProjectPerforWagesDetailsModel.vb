
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerforWagesDetailsModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 关联项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 表ProjectPerformWages 关联ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WagesID As Integer?

	''' <summary>
	''' 项目名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectName As String

	''' <summary>
	''' 项目类型/咨询类型ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectType As Integer?

	''' <summary>
	''' 建设单位/委托方ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ClientID As Integer?

	''' <summary>
	''' 建设单位/委托方名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ClientName As String

	''' <summary>
	''' 报告编号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ReportNO As String

	''' <summary>
	''' 单位工程ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UnitID As Integer?

	''' <summary>
	''' 单位工程名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UnitName As String

	''' <summary>
	''' 单位工程类型
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UnitType As Integer?

	''' <summary>
	''' 编制/送审金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PrepSum As Decimal?

	''' <summary>
	''' 审定金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExamSum As Decimal?

	''' <summary>
	''' 核减金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OffsetSum As Decimal?

	''' <summary>
	''' 核减率
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OffsetRate As Decimal?

	''' <summary>
	''' 核减率系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OffsetRatio As Decimal?

	''' <summary>
	''' 绩效计算基数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PerformBase As Decimal?

	''' <summary>
	''' 职称等级系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RankRatio As Decimal?

	''' <summary>
	''' 标准系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property StandRatio As Decimal?

	''' <summary>
	''' 工程类别系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TypeRatio As Decimal?

	''' <summary>
	''' 项目规模系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ScaleRatio As Decimal?

	''' <summary>
	''' 调节系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AdjusRatio As Decimal?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UserID As Integer?

	''' <summary>
	''' 
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
	Public Property WagesBase As Decimal?

	''' <summary>
	''' 绩效系数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WagesRatio As Decimal?

	''' <summary>
	''' 绩效工资
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WagesTotal As Decimal?

	''' <summary>
	''' 剩余工资
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property WurpluTotal As Decimal?

	''' <summary>
	''' 发放比例
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayRatio As Decimal?

	''' <summary>
	''' 发放金额
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PayTotal As Decimal?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

	Public Sub New()
		Me.PrepSum = 0
		Me.ExamSum = 0
		Me.OffsetSum = 0
		Me.OffsetRate = 0
		Me.OffsetRatio = 0
		Me.PerformBase = 0
		Me.RankRatio = 0
		Me.StandRatio = 0
		Me.TypeRatio = 0
		Me.ScaleRatio = 0
		Me.AdjusRatio = 0
		Me.WagesBase = 0
		Me.WagesRatio = 0
		Me.WagesTotal = 0
		Me.WurpluTotal = 0
		Me.PayRatio = 0
		Me.PayTotal = 0
	End Sub

End Class

Partial Public Class ProjectPerforWagesDetailsMap
    Inherits EntityTypeConfiguration(Of ProjectPerforWagesDetailsModel)
	Public Sub New()
		Me.ToTable("ProjectPerforWagesDetails")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.WagesID)
		Me.Property(Function(t) t.ProjectName)
		Me.Property(Function(t) t.ProjectType)
		Me.Property(Function(t) t.ClientID)
		Me.Property(Function(t) t.ClientName)
		Me.Property(Function(t) t.ReportNO)
		Me.Property(Function(t) t.UnitID)
		Me.Property(Function(t) t.UnitName)
		Me.Property(Function(t) t.UnitType)
		Me.Property(Function(t) t.PrepSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.ExamSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.OffsetSum).HasPrecision(18, 2)
		Me.Property(Function(t) t.OffsetRate).HasPrecision(18, 4)
		Me.Property(Function(t) t.OffsetRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.PerformBase).HasPrecision(18, 2)
		Me.Property(Function(t) t.RankRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.StandRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.TypeRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.ScaleRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.AdjusRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.RoleID)
		Me.Property(Function(t) t.WagesBase).HasPrecision(18, 2)
		Me.Property(Function(t) t.WagesRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.WagesTotal).HasPrecision(18, 2)
		Me.Property(Function(t) t.WurpluTotal).HasPrecision(18, 2)
		Me.Property(Function(t) t.PayRatio).HasPrecision(18, 4)
		Me.Property(Function(t) t.PayTotal).HasPrecision(18, 2)
		Me.Property(Function(t) t.Note)

	End Sub
End Class
