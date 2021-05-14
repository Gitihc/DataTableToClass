Public Class ProjectCollContractPayApprovalFlowHandler
    Implements IFlowHandler

#Region "FlowStep相关"
    Public Function GetOriginator(lid As Integer) As String Implements IFlowHandler.GetOriginator
        Return FlowHandlerCommon.GetOriginator(Of ProjectCollContractPayApprovalModel)(lid)
    End Function

    Public Function GetFlowInfo(lid As Integer) As String Implements IFlowHandler.GetFlowInfo
        Dim listModel = EntityHelper.GetSelect(Of ProjectCollContractPayApprovalModel)(Function(x) x.LID = lid)
        For Each model In listModel
            With model
                If String.IsNullOrEmpty(.ApproverIds) Then
                    .ApproverIds = ""
                End If
            End With
        Next

        Dim result = AutoMapperHelper.MapToList(Of FlowView)(listModel)
        For Each itm In result
            itm.StateName = FlowHandlerCommon.GetFlowStateName(itm.State)
            itm.ApproveName = itm.ApproverNames
        Next

        Dim rztStr = ObjectToJSON(result)
        rztStr = RegexDate(rztStr)
        Return rztStr
    End Function

    ''' <summary>
    ''' 通过id获取审批步骤
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFlowStepByID(Id As Integer) As ApprovalBase Implements IFlowHandler.GetFlowStepByID
        Return EntityHelper.GetFristDefault(Of ProjectCollContractPayApprovalModel)(Function(x) x.ID = Id)
    End Function
    ''' <summary>
    ''' 获取审批第一步
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFirstFlowStep(lid As Integer) As ApprovalBase Implements IFlowHandler.GetFirstFlowStep
        Return FlowHandlerCommon.GetFirstFlowStep(Of ProjectCollContractPayApprovalModel)(lid)
    End Function
    ''' <summary>
    ''' 是否需要设置下一步审批人
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="curUserId"></param>
    ''' <param name="approvalResult"></param>
    ''' <param name="curStepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsNeedSetFlowUser(applyType As ApprovalTypeEnum, projectId As Integer, lid As Integer, curUserId As Integer, approvalResult As Integer, curStepId As Integer) As Boolean Implements IFlowHandler.IsNeedSetFlowUser
        Dim projObj = ProjectListServices.Get(projectId)
        Dim curFlowStep = FlowHandlerCommon.GetCurrentFlowStep(Of ProjectCollContractPayApprovalModel)(lid)
        Return FlowHandlerCommon.IsNeedSetFlowUser(applyType, projectId, projObj.BranchID, lid, projObj.ProjectCode, projObj.ProjectName, curUserId, approvalResult, curFlowStep, Me)
    End Function
    ''' <summary>
    ''' 获取当前审批步骤
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCurrentFlowStep(lid As Integer) As ApprovalBase Implements IFlowHandler.GetCurrentFlowStep
        Return FlowHandlerCommon.GetCurrentFlowStep(Of ProjectCollContractPayApprovalModel)(lid)
    End Function
    ''' <summary>
    ''' 获取审批集合
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFlowlist(lid As Integer) As System.Collections.Generic.List(Of ApprovalBase) Implements IFlowHandler.GetFlowlist
        Return FlowHandlerCommon.GetFlowlist(Of ProjectCollContractPayApprovalModel)(lid).ToList
    End Function
    ''' <summary>
    ''' 获取下一步审批
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNextStepByID(lid As Integer, stepId As Integer) As ApprovalBase Implements IFlowHandler.GetNextStepByID
        Dim listEntity = FlowHandlerCommon.GetFlowlist(Of ProjectCollContractPayApprovalModel)(lid)
        Return (From p In listEntity Where p.ID > stepId).FirstOrDefault
    End Function
    ''' <summary>
    ''' 更新方法
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Update(model As ApprovalBase) As Boolean Implements IFlowHandler.Update
        Return EntityHelper.Update(Of ProjectCollContractPayApprovalModel)(model)
    End Function
#End Region

#Region "flowRecord"
    Public Sub UpdateFlowRecord(applType As ApprovalTypeEnum, lid As Integer) Implements IFlowHandler.UpdateFlowRecord
        Call ProjectCollContractPayApprovalService.UpdateFlowRecord(applType, lid)
    End Sub
#End Region

#Region "审批处理相关"
    ''' <summary>
    ''' 设置步骤审批人
    ''' </summary>
    ''' <param name="projectId"></param>
    ''' <param name="stepId"></param>
    ''' <param name="approver"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetFlowStepUser(projectId As Integer, stepId As Integer, userIds As String) As Boolean Implements IFlowHandler.SetFlowStepUser
        Return FlowHandlerCommon.SetFlowStepUser(Of ProjectCollContractPayApprovalModel)(projectId, stepId, userIds)
    End Function

    ''' <summary>
    ''' 是否为最后一步
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsLastStepFlowStep(lid As Integer, stepId As Integer) As Boolean Implements IFlowHandler.IsLastStepFlowStep
        Return FlowHandlerCommon.IsLastStepFlowStep(Of ProjectCollContractPayApprovalModel)(lid, stepId)
    End Function
    ''' <summary>
    ''' 提交审批
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="curUserId"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <param name="opinion"></param>
    ''' <param name="approvalResult"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SubmitFlow(applyType As ApprovalTypeEnum, curUserId As Integer, projectId As Integer, lid As Integer, stepId As Integer, opinion As String, approvalResult As Integer) As Boolean Implements IFlowHandler.SubmitFlow

        Dim curFlowStep = GetCurrentFlowStep(lid)
        Dim result = FlowHandlerCommon.SubmitFlow(applyType, curUserId, projectId, lid, stepId, opinion, approvalResult,
                                                  AddressOf ProjectCollContractPayApprovalService.FinishFunc,
                                                  AddressOf ProjectCollContractPayApprovalService.RejectFunc,
                                                  curFlowStep, Me)
        Try '操作成功，记录日志
            Dim eventNote As String = String.Format("将审批【{0}】设置为【{1}】。", curFlowStep.StepName, IIf(approvalResult = 1, "通过", IIf(approvalResult = 2, "免审", "不通过")))
            SysEventsLog(LogType.Log_Approval, EventType.Exa_Start, curUserId, projectId, lid, GetTaskNameByTaskID(lid), eventNote)
        Catch ex As Exception
            ErrorHandle("SetExamItem-记录审批不通过", ex)
        End Try
        Return result
    End Function
    ''' <summary>
    ''' 审批完成后执行的方法
    ''' </summary>
    ''' <param name="aplType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="curApprovalStepModel"></param>
    ''' <remarks></remarks>
    Public Sub DoFuncAfterFinishFlow(aplType As Integer, projectId As Integer, curUserId As Integer, curApprovalStepModel As ApprovalBase) Implements IFlowHandler.DoFuncAfterFinishFlow
        Call ProjectCollContractPayApprovalService.FinishFunc(aplType, projectId, curApprovalStepModel, curUserId)
    End Sub
    ''' <summary>
    ''' 全部重审
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <remarks></remarks>
    Public Sub ReDoAllFlowStep(lid As Integer) Implements IFlowHandler.ReDoAllFlowStep
        Call FlowHandlerCommon.ReDoAllFlowStep(Of ProjectCollContractPayApprovalModel)(lid)
    End Sub
    ''' <summary>
    ''' 保存审批意见
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <param name="opinion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SaveFlowStepAdvice(userName As String, lid As Integer, stepId As Integer, opinion As String) As Boolean Implements IFlowHandler.SaveFlowStepAdvice
        Return FlowHandlerCommon.SaveFlowStepAdvice(Of ProjectCollContractPayApprovalModel)(userName, lid, stepId, opinion, Me)
    End Function
#End Region

#Region "单据相关"
    Public Function GetLidInfo(lid As Integer) As LidInfo Implements IFlowHandler.GetLidInfo
        Dim model = ProjectCollContractPayApprovalLidService.Get(Function(x) x.ID = lid)
        Dim projObj = ProjectListServices.Get(model.ProjectID)
        Dim info = New LidInfo
        With info
            If Not IsNothing(projObj) Then
                .BranchId = projObj.BranchID
                .ProjectName = projObj.ProjectName
            End If
            .lidAplState = model.ExAction
            .lidState = model.Status
            .lidName = model.Name
        End With
        Return info
    End Function
#End Region

#Region "传阅相关"
    ''' <summary>
    ''' 设置传阅人
    ''' </summary>
    ''' <param name="projectId"></param>
    ''' <param name="stepId"></param>
    ''' <param name="CirculatedUserIds"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetCirculatedUser(projectId As Integer, stepId As Integer, CirculatedUserIds As String) As Boolean Implements IFlowHandler.SetCirculatedUser
        Return FlowHandlerCommon.SetCirculatedUser(Of ProjectCollContractPayApprovalModel)(projectId, stepId, CirculatedUserIds)
    End Function

    ''' <summary>
    ''' 检查是否存在审批流程
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="curUserId"></param>
    ''' <param name="approvalResult"></param>
    ''' <param name="curFlowStep"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsNeedSetCirculatedUser(applyType As ApprovalTypeEnum, projectId As Integer, branchId As String, lid As Integer, curUserId As Integer, approvalResult As Integer, curFlowStep As ApprovalBase) As Boolean Implements IFlowHandler.IsNeedSetCirculatedUser
        Return FlowHandlerCommon.IsNeedSetCirculatedUser(applyType, projectId, branchId, lid, curUserId, approvalResult, curFlowStep, Me)
    End Function

    ''' <summary>
    ''' 更新已阅人
    ''' </summary>
    ''' <param name="userId"></param>
    ''' <param name="lid"></param>
    ''' <remarks></remarks>
    Public Sub UpdateIsView(userId As Integer, lid As Integer) Implements IFlowHandler.UpdateIsView
        Call FlowHandlerCommon.UpdateIsView(Of ProjectCollContractPayApprovalModel)(userId, lid)
    End Sub
#End Region

#Region "企业微信相关"
    Public Sub WebChatBuildMSG(applType As Integer, projectId As Integer, lid As Integer, stepId As Integer, stepName As String, isFinishedOrReject As Integer, ByRef title As String, ByRef description As String, Optional prefixStr As String = "") Implements IFlowHandler.WebChatBuildMSG
        Call ProjectCollContractPayApprovalLidService.WebChatBuildMSG(applType, projectId, lid, stepId, stepName, isFinishedOrReject, title, description, prefixStr)
    End Sub

    ''' <summary>
    ''' 审批列表展示--用于微信审批列表
    ''' </summary>
    ''' <param name="dataType"></param>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function WebChatBuildListApprovalInfo(dataType As Integer, lid As Integer) As String Implements IFlowHandler.WebChatBuildListApprovalInfo
        Return ProjectCollContractPayApprovalLidService.WebChatBuildListApprovalInfo(dataType, lid)
    End Function
    ''' <summary>
    ''' 返回展示信息列表-用于审批页面、查看审批页面
    ''' </summary>
    ''' <param name="dataType"></param>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function WebChatBuildListInfo(dataType As Integer, lid As Integer) As String Implements IFlowHandler.WebChatBuildListInfo
        Return ProjectCollContractPayApprovalLidService.WebChatBuildListInfo(dataType, lid)
    End Function
#End Region

#Region "流程督办"
    Public Function ChangeCurStep(applyType As Integer, projectId As Integer, taskId As Integer, stepId As Integer, userId As Integer) As Boolean Implements IFlowHandler.ChangeCurStep
        Return FlowHandlerCommon.ChangeCurStep(Of ProjectCollContractPayApprovalModel)(applyType, projectId, taskId, stepId, userId, Me)
    End Function

    Public Function EndApproval(applyType As Integer, projectId As Integer, lid As Integer, lidCode As String, curUserId As Integer) As Boolean Implements IFlowHandler.EndApproval
        Return FlowHandlerCommon.EndApproval(Of ProjectCollContractPayApprovalModel)(applyType, projectId, lid, curUserId, Me)
    End Function

    Public Function RemindApprover(applType As Integer, projectId As Integer, lid As Integer, lidCode As String, stepId As Integer, stepName As String) As Boolean Implements IFlowHandler.RemindApprover
        Return FlowHandlerCommon.RemindApprover(Of ProjectCollContractPayApprovalModel)(applType, projectId, lid, lidCode, stepId, stepName, Me)
    End Function
#End Region

End Class
