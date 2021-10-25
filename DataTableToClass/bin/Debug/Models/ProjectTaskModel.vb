
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectTaskModel


	''' <summary>
	''' 任务ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务ID")>
	Public Property ID As Integer

	''' <summary>
	''' 顺序号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("顺序号")>
	Public Property IDX As Integer?

	''' <summary>
	''' 上级ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("上级ID")>
	Public Property PID As Integer?

	''' <summary>
	''' 任务名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务名称")>
	Public Property Name As String

	''' <summary>
	''' 负责人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("负责人")>
	Public Property Assign As String

	''' <summary>
	''' 工期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工期")>
	Public Property Persons As Decimal?

	''' <summary>
	''' 工作量
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("工作量")>
	Public Property TaskTime As Decimal?

	''' <summary>
	''' 最早开始时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("最早开始时间")>
	Public Property ESDate As DateTime?

	''' <summary>
	''' 最早结束时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("最早结束时间")>
	Public Property EFDate As DateTime?

	''' <summary>
	''' 预计开始时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("预计开始时间")>
	Public Property YSDate As DateTime?

	''' <summary>
	''' 预计结束时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("预计结束时间")>
	Public Property YFDate As DateTime?

	''' <summary>
	''' 计划开始日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("计划开始日期")>
	Public Property PSDate As DateTime?

	''' <summary>
	''' 计划结束时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("计划结束时间")>
	Public Property PFDate As DateTime?

	''' <summary>
	''' 最晚开始时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("最晚开始时间")>
	Public Property LSDate As DateTime?

	''' <summary>
	''' 最晚结束时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("最晚结束时间")>
	Public Property LFDate As DateTime?

	''' <summary>
	''' 实际开始时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("实际开始时间")>
	Public Property FSDate As DateTime?

	''' <summary>
	''' 实际完成时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("实际完成时间")>
	Public Property FFDate As DateTime?

	''' <summary>
	''' 延误天数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("延误天数")>
	Public Property Delay As Integer?

	''' <summary>
	''' 延时天数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("延时天数")>
	Public Property Defer As Integer?

	''' <summary>
	''' 总时差
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("总时差")>
	Public Property TFDays As Integer?

	''' <summary>
	''' 自由时差
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("自由时差")>
	Public Property FFDays As Integer?

	''' <summary>
	''' 完成进度
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("完成进度")>
	Public Property Progress As Decimal?

	''' <summary>
	''' 前置任务ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("前置任务ID")>
	Public Property BeforeID As String

	''' <summary>
	''' 里程碑
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("里程碑")>
	Public Property Milepost As Bool?

	''' <summary>
	''' 里程碑节点ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("里程碑节点ID")>
	Public Property MilestItemID As Integer?

	''' <summary>
	''' 项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("项目ID")>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 审批发起标记：0-未发起；1-已发起；2-已审结；3-已驳回
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("审批发起标记：0-未发起；1-已发起；2-已审结；3-已驳回")>
	Public Property ExAction As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ExAcDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property CreatDate As DateTime?

	''' <summary>
	''' 任务状态：0-未开始；1-进行中；2-已完成
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务状态：0-未开始；1-进行中；2-已完成")>
	Public Property Status As Integer?

	''' <summary>
	''' 任务描述
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("任务描述")>
	Public Property Description As String

	''' <summary>
	''' 审批模板ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("审批模板ID")>
	Public Property EID As Integer?

	Public Sub New()
		Me.PID = 0
		Me.Name = String.Empty
		Me.Assign = String.Empty
		Me.Persons = 0
		Me.TaskTime = 0
		Me.YSDate = Now
		Me.YFDate = Now
		Me.PSDate = Now
		Me.PFDate = Now
		Me.Delay = 0
		Me.Defer = 0
		Me.Progress = 0
		Me.BeforeID = String.Empty
		Me.Milepost = 0
		Me.MilestItemID = 0
		Me.ExAction = -1
		Me.CreatDate = Now
		Me.Status = 0
		Me.EID = 0
	End Sub

End Class

Partial Public Class ProjectTaskMap
    Inherits EntityTypeConfiguration(Of ProjectTaskModel)
	Public Sub New()
		Me.ToTable("ProjectTask")
		Me.HasKey(Function(s) s.ID)
				Me.Property(Function(t) t.IDX)
				Me.Property(Function(t) t.PID)
				Me.Property(Function(t) t.Name)
				Me.Property(Function(t) t.Assign)
				Me.Property(Function(t) t.Persons).HasPrecision(18, 0)
				Me.Property(Function(t) t.TaskTime).HasPrecision(18, 0)
				Me.Property(Function(t) t.ESDate)
				Me.Property(Function(t) t.EFDate)
				Me.Property(Function(t) t.YSDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.YFDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.PSDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.PFDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.LSDate)
				Me.Property(Function(t) t.LFDate)
				Me.Property(Function(t) t.FSDate)
				Me.Property(Function(t) t.FFDate)
				Me.Property(Function(t) t.Delay)
				Me.Property(Function(t) t.Defer)
				Me.Property(Function(t) t.TFDays)
				Me.Property(Function(t) t.FFDays)
				Me.Property(Function(t) t.Progress).HasPrecision(18, 0)
				Me.Property(Function(t) t.BeforeID)
				Me.Property(Function(t) t.Milepost)
				Me.Property(Function(t) t.MilestItemID)
				Me.Property(Function(t) t.ProjectID)
				Me.Property(Function(t) t.ExAction)
				Me.Property(Function(t) t.ExAcDate)
				Me.Property(Function(t) t.CreatDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
				Me.Property(Function(t) t.Status)
				Me.Property(Function(t) t.Description)
				Me.Property(Function(t) t.EID)
	End Sub
End Class
