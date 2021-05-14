
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerforDetailsModel


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
	''' 人员ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UserID As Integer?

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
	''' 人员绩效
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PerformSum As Decimal?

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
	''' 项目经理ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AssigName As String

	''' <summary>
	''' 项目经理业绩计算基数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property AssigSum As Decimal?

	''' <summary>
	''' 二审人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Exam2Name As String

	''' <summary>
	''' 二审业绩计算基数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Exam2Sum As Decimal?

	''' <summary>
	''' 三审人ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Exam3Name As String

	''' <summary>
	''' 三审绩效计算基数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Exam3Sum As Decimal?

	''' <summary>
	''' 备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

	''' <summary>
	''' 项目状态：0-待确认；1-已确认
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Status As Integer?

	Public Sub New()
		Me.PerformSum = 0
		Me.RankRatio = 0
		Me.Status = 0
	End Sub

End Class

Partial Public Class ProjectPerforDetailsMap
    Inherits EntityTypeConfiguration(Of ProjectPerforDetailsModel)
	Public Sub New()
		Me.ToTable("ProjectPerforDetails")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.PerforID)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.UnitName)
		Me.Property(Function(t) t.UnitType)
		Me.Property(Function(t) t.PrepSum)
		Me.Property(Function(t) t.ExamSum)
		Me.Property(Function(t) t.OffsetSum)
		Me.Property(Function(t) t.OffsetRate)
		Me.Property(Function(t) t.OffsetRatio)
		Me.Property(Function(t) t.PerformSum)
		Me.Property(Function(t) t.PerformBase)
		Me.Property(Function(t) t.RankRatio)
		Me.Property(Function(t) t.StandRatio)
		Me.Property(Function(t) t.TypeRatio)
		Me.Property(Function(t) t.ScaleRatio)
		Me.Property(Function(t) t.AdjusRatio)
		Me.Property(Function(t) t.AssigName)
		Me.Property(Function(t) t.AssigSum)
		Me.Property(Function(t) t.Exam2Name)
		Me.Property(Function(t) t.Exam2Sum)
		Me.Property(Function(t) t.Exam3Name)
		Me.Property(Function(t) t.Exam3Sum)
		Me.Property(Function(t) t.Note)
		Me.Property(Function(t) t.Status)

	End Sub
End Class
