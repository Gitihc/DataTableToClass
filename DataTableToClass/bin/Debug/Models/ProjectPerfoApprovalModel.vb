
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPerfoApprovalModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 项目绩效ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property PID As Integer

	''' <summary>
	''' 步骤顺序号
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IDX As Integer?

	''' <summary>
	''' 审批步骤名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExName As String

	''' <summary>
	''' 审批人类型：0-用户；1-角色
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExType As String

	''' <summary>
	''' 审批人ID表，用“，”分开
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExUserID As String

	''' <summary>
	''' 审批方式：1-只需任意一人（角色）审批；0-需所有人（角色）审批
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExMode As Integer?

	''' <summary>
	''' 审批日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExDate As DateTime?

	''' <summary>
	''' 审批状态：0-未审批；1-已审批
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExState As Integer?

	''' <summary>
	''' 审批说明
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExNote As String

	''' <summary>
	''' 需所有人审批时，记录已审批过的用户ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExChecked As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsChecked As Integer?

	''' <summary>
	''' 质量审批扣罚分值
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExScore As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExResult As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RetrialRule As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property StepCruces As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ApproverNames As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RoleNames As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CirculatedRoleIds As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CirculatedRoleNames As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CirculatedUserIds As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CirculatedUserNames As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ApproverType As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UnmannedMode As Integer?

	''' <summary>
	''' 记录已阅人
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsView As String

	Public Sub New()
		Me.ExType = 0
		Me.ExMode = 0
		Me.ExDate = Now
		Me.ExState = 0
		Me.IsChecked = 0
		Me.ExScore = 0
		Me.RetrialRule = 0
		Me.ApproverType = 1
		Me.UnmannedMode = 0
	End Sub

End Class

Partial Public Class ProjectPerfoApprovalMap
    Inherits EntityTypeConfiguration(Of ProjectPerfoApprovalModel)
	Public Sub New()
		Me.ToTable("ProjectPerfoApproval")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.IDX)
		Me.Property(Function(t) t.ExName)
		Me.Property(Function(t) t.ExType)
		Me.Property(Function(t) t.ExUserID)
		Me.Property(Function(t) t.ExMode)
		Me.Property(Function(t) t.ExDate)
		Me.Property(Function(t) t.ExState)
		Me.Property(Function(t) t.ExNote)
		Me.Property(Function(t) t.ExChecked)
		Me.Property(Function(t) t.IsChecked)
		Me.Property(Function(t) t.ExScore)
		Me.Property(Function(t) t.ExResult)
		Me.Property(Function(t) t.RetrialRule)
		Me.Property(Function(t) t.StepCruces)
		Me.Property(Function(t) t.ApproverNames)
		Me.Property(Function(t) t.RoleNames)
		Me.Property(Function(t) t.CirculatedRoleIds)
		Me.Property(Function(t) t.CirculatedRoleNames)
		Me.Property(Function(t) t.CirculatedUserIds)
		Me.Property(Function(t) t.CirculatedUserNames)
		Me.Property(Function(t) t.ApproverType)
		Me.Property(Function(t) t.UnmannedMode)
		Me.Property(Function(t) t.IsView)

	End Sub
End Class
