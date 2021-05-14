
Public Class ProjectEntrusContractRecApprovalFlowHandler
    Implements IFlowHandler

#Region "FlowStep相关"
	''' <summary>
    ''' 设置第一步
    ''' </summary>
    ''' <param name="dType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="listId"></param>
    ''' <param name="listCode"></param>
    ''' <param name="userId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetFirstFlowStep(dType As ApprovalTypeEnum, projectId As Integer, listId As Integer, listCode As String, userId As String) As Boolean Implements IFlowHandler.SetFirstFlowStep
        Return FlowHandlerCommon.SetFirstFlowStep(Of ProjectEntrusContractRecApprovalModel)(dType, projectId, listId, listCode, userId, Me)
    End Function
    ''' <summary>
    ''' 通过id获取审批步骤
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFlowStepByID(id As Integer) As ApprovalBase Implements IFlowHandler.GetFlowStepByID
        Return EntityHelper.GetFristDefault(Of ProjectEntrusContractRecApprovalModel)(Function(x) x.ID = id)
    End Function

    ''' <summary>
    ''' 获取下一步审批
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNextFlowStep(lid As Integer) As ApprovalBase Implements IFlowHandler.GetNextFlowStep
        Return FlowHandlerCommon.GetNextStepApproval(Of ProjectEntrusContractRecApprovalModel)(lid)
    End Function

    ''' <summary>
    ''' 获取第一步审批
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFirstFlowStep(lid As Integer) As ApprovalBase Implements IFlowHandler.GetFirstFlowStep
        Return FlowHandlerCommon.GetFirstFlowStep(Of ProjectEntrusContractRecApprovalModel)(lid)
    End Function
    ''' <summary>
    ''' 获取当前审批
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCurrentFlowStep(lid As Integer) As ApprovalBase Implements IFlowHandler.GetCurrentFlowStep
        Return FlowHandlerCommon.GetCurrentFlowStep(Of ProjectEntrusContractRecApprovalModel)(lid)
    End Function

    Public Function GetFlowListInfo(projectId As Integer, lid As Integer) As String Implements IFlowHandler.GetFlowListInfo
        Dim listModel = EntityHelper.GetSelect(Of ProjectEntrusContractRecApprovalModel)(Function(x) x.PID = projectId AndAlso x.SID = lid)
        For Each model In listModel
            With model
                If String.IsNullOrEmpty(.ApproverIds) Then
                    .ApproverIds = ""
                End If
            End With
        Next

        Dim result = AutoMapperHelper.MapToList(Of FlowView)(listModel)
        For Each itm In result
            itm.StateName = DataMapServices.GetApproveStateName(itm.State)
            itm.RoleName = itm.RoleNames
            itm.ApproveName = itm.ApproverNames
            itm.ProjectName = ProjectServices.GetProjectName(projectId)
        Next

        Dim rztStr = ObjectToJSON(result)
        rztStr = RegexDate(rztStr)
        Return rztStr
    End Function
    ''' <summary>
    ''' 获取审批集合
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFlowlist(lid As Integer) As System.Collections.Generic.List(Of ApprovalBase) Implements IFlowHandler.GetFlowlist
        Return FlowHandlerCommon.GetFlowlist(Of ProjectEntrusContractRecApprovalModel)(lid).ToList
    End Function
    ''' <summary>
    ''' 获取下一步审批
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNextStepByID(lid As Integer, stepId As Integer) As ApprovalBase Implements IFlowHandler.GetNextStepByID
        Dim listEntity = FlowHandlerCommon.GetFlowlist(Of ProjectEntrusContractRecApprovalModel)(lid)
        Return (From p In listEntity Where p.ID > stepId).FirstOrDefault
    End Function
    ''' <summary>
    ''' 更新方法
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Update(model As ApprovalBase) As Boolean Implements IFlowHandler.Update
        Return EntityHelper.Update(Of ProjectEntrusContractRecApprovalModel)(model)
    End Function

#End Region

#Region "审批处理相关"
    ''' <summary>
    ''' 设置流程审批人
    ''' </summary>
    ''' <param name="projectId"></param>
    ''' <param name="stepId"></param>
    ''' <param name="approver"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetFlowStepUser(projectId As Integer, stepId As Integer, approver As String) As Boolean Implements IFlowHandler.SetFlowStepUser
        Return FlowHandlerCommon.SetFlowStepApprover(Of ProjectEntrusContractRecApprovalModel)(projectId, stepId, approver)
    End Function

    ''' <summary>
    ''' 检查审批人
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="curUserId"></param>
    ''' <param name="approvalResult"></param>
    ''' <param name="curStepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsNeedSetFlowUser(applyType As ApprovalTypeEnum,
                                  projectId As Integer,
                                  lid As Integer,
                                  curUserId As Integer,
                                  approvalResult As Integer,
                                  curStepId As Integer) As Integer Implements IFlowHandler.IsNeedSetFlowUser
        Dim obj = ProjectEntrusContractRecApprovalLidService.Get(lid)
        Dim curFlowStep = ProjectEntrusContractRecApprovalService.GetCurrentStepApproval(lid)

        Return FlowHandlerCommon.IsNeedSetFlowUser(applyType, projectId, lid, obj.Code, obj.Name, curUserId, approvalResult, curFlowStep, Me)
    End Function

    ''' <summary>
    ''' 是否为最后一步
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <param name="stepId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsLastStepFlowStep(lid As Integer, stepId As Integer) As Boolean Implements IFlowHandler.IsLastStepFlowStep
        Return FlowHandlerCommon.IsLastStepFlowStep(Of ProjectEntrusContractRecApprovalModel)(lid, stepId)
    End Function

    ''' <summary>
    ''' 判断是否存在审批流程
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsExistFlow(lid As Integer) As Boolean Implements IFlowHandler.IsExistFlow
        Return FlowHandlerCommon.IsExistFlow(Of ProjectEntrusContractRecApprovalModel)(lid)
    End Function

    ''' <summary>
    ''' 审批完成后执行的方法
    ''' </summary>
    ''' <param name="aplType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lastApprovalStepModel"></param>
    ''' <remarks></remarks>
    Public Sub DoFuncAfterFinishFlow(aplType As Integer, projectId As Integer, lastApprovalStepModel As ApprovalBase) Implements IFlowHandler.DoFuncAfterFinishFlow
        Call ProjectEntrusContractRecApprovalService.FinishFunc(aplType, projectId, lastApprovalStepModel)
    End Sub

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
        Dim obj = ProjectEntrusContractRecApprovalLidService.Get(lid)
        If IsNothing(obj) Then Return False
		Dim lidCode As String = ProjectEntrusContractRecApprovalLidService.GetCode(lid) 'obj.Code
        Dim curFlowStep = Me.GetCurrentFlowStep(lid)
        Return FlowHandlerCommon.SubmitApproval(applyType, curUserId, projectId, lid, lidCode, opinion, approvalResult,
                                               AddressOf ProjectEntrusContractRecApprovalService.FinishFunc,
                                               AddressOf ProjectEntrusContractRecApprovalService.RejectFunc,
                                               curFlowStep, Me)
    End Function

    ''' <summary>
    ''' 获取提交人
    ''' </summary>
    ''' <param name="lid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetOriginator(lid As Integer) As String Implements IFlowHandler.GetOriginator
        Return FlowHandlerCommon.GetOriginator(Of ProjectEntrusContractRecApprovalModel)(lid)
    End Function

#End Region

#Region "单据相关"
    ''' <summary>
    ''' 通过ID获取单据信息
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLidInfo(id As Integer) As LidInfo Implements IFlowHandler.GetLidInfo
        Dim model = ProjectEntrusContractRecApprovalLidService.Get(Function(x) x.ID = id)
        Dim info = New LidInfo
        With info
            .ID = model.ID
            .Name = model.Name
            .Code = model.Code
            .ProjectName = ProjectServices.GetProjectName(model.PID)
            .State = model.State
        End With
        Return info
    End Function
    ''' <summary>
    ''' 通过编号获取单据信息
    ''' </summary>
    ''' <param name="lidCode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLidInfo(lidCode As String) As LidInfo Implements IFlowHandler.GetLidInfo
        Dim model = ProjectEntrusContractRecApprovalLidService.Get(Function(x) x.Code = lidCode)
        Dim info = New LidInfo
        With info
            .ID = model.ID
            .Name = model.Name
            .Code = model.Code
            .ProjectName = ProjectServices.GetProjectName(model.PID)
            .State = model.State
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
        Return FlowHandlerCommon.SetCirculatedUser(Of ProjectEntrusContractRecApprovalModel)(projectId, stepId, CirculatedUserIds)
    End Function

    ''' <summary>
    ''' 更新已阅人
    ''' </summary>
    ''' <param name="userId"></param>
    ''' <param name="lid"></param>
    ''' <remarks></remarks>
    Public Sub UpdateIsView(userId As Integer, lid As Integer) Implements IFlowHandler.UpdateIsView
        Call FlowHandlerCommon.UpdateIsView(Of ProjectEntrusContractRecApprovalModel)(userId, lid)
    End Sub

    ''' <summary>
    ''' 是否设置传阅人
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="curUserId"></param>
    ''' <param name="approvalResult"></param>
    ''' <param name="curFlowStep"></param>
    ''' <param name="approvalHandler"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsNeedSetCirculatedUser(applyType As ApprovalTypeEnum, projectId As Integer, lid As Integer, curUserId As Integer, approvalResult As Integer, curFlowStep As ApprovalBase, approvalHandler As IFlowHandler) As Boolean Implements IFlowHandler.IsNeedSetCirculatedUser
        Return FlowHandlerCommon.IsNeedSetCirculatedUser(applyType, projectId, lid, curUserId, approvalResult, curFlowStep, approvalHandler)
    End Function

#End Region

#Region "FlowRecord相关"
    ''' <summary>
    ''' 更新FlowRecord
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="lid"></param>
    ''' <remarks></remarks>
    Public Sub UpdateFlowRecord(applyType As ApprovalTypeEnum, lid As Integer) Implements IFlowHandler.UpdateFlowRecord
        Call ProjectEntrusContractRecApprovalLidService.UpdateFlowRecord(applyType, lid)
    End Sub

#End Region

#Region "流程督办"
    ''' <summary>
    ''' 更改当前节点
    ''' </summary>
    ''' <param name="aplType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="lidCode"></param>
    ''' <param name="userId"></param>
    ''' <param name="flowStep"></param>
    ''' <param name="approvalHandler"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChangeCurStep(aplType As Integer, projectId As Integer, lid As Integer, lidCode As String, userId As Integer, flowStep As ApprovalBase, approvalHandler As IFlowHandler) As Boolean Implements IFlowHandler.ChangeCurStep
        Return FlowHandlerCommon.ChangeCurStep(Of ProjectEntrusContractRecApprovalModel)(aplType, projectId, lid, lidCode, userId, flowStep, Me)
    End Function
    ''' <summary>
    ''' 完成审批
    ''' </summary>
    ''' <param name="applyType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="lidCode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EndApproval(applyType As Integer, projectId As Integer, lid As Integer, lidCode As String) As Boolean Implements IFlowHandler.EndApproval
        Return FlowHandlerCommon.EndApproval(Of ProjectEntrusContractRecApprovalModel)(applyType, projectId, lid, lidCode, Me)
    End Function

    ''' <summary>
    ''' 催办
    ''' </summary>
    ''' <param name="aplType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="lidCode"></param>
    ''' <param name="flowStep"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RemindApprover(aplType As Integer, projectId As Integer, lid As Integer, lidCode As String, flowStep As ApprovalBase) As Boolean Implements IFlowHandler.RemindApprover
        Return FlowHandlerCommon.RemindApprover(Of ProjectEntrusContractRecApprovalModel)(aplType, projectId, lid, lidCode, flowStep, Me)
    End Function
#End Region

#Region "企业微信相关"
    ''' <summary>
    ''' 发送企业微信消息
    ''' </summary>
    ''' <param name="applType"></param>
    ''' <param name="projectId"></param>
    ''' <param name="lid"></param>
    ''' <param name="stepName"></param>
    ''' <param name="msgType"></param>
    ''' <param name="title"></param>
    ''' <param name="description"></param>
    ''' <param name="btnText"></param>
    ''' <remarks></remarks>
    Public Sub BuildWebChatMSG(applType As Integer, projectId As Integer, lid As Integer, stepName As String, msgType As Integer, ByRef title As String, ByRef description As String, ByRef btnText As String) Implements IFlowHandler.BuildWebChatMSG
        ProjectEntrusContractRecApprovalLidService.BuildWebChatMSG(applType, projectId, lid, stepName, msgType, title, description, btnText)
    End Sub

    ''' <summary>
    ''' 构建企业微信审批信息
    ''' </summary>
    ''' <param name="dataType">数据类型</param>
    ''' <param name="apprlType">审批类型</param>
    ''' <param name="lid">单据id</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function WebChatBuildListInfo(dataType As Integer, apprlType As Integer, lid As Integer) As String Implements IFlowHandler.WebChatBuildListInfo
        Return ProjectEntrusContractRecApprovalLidService.WebChatBuildListInfo(dataType, apprlType, lid)
    End Function
#End Region

End Class
