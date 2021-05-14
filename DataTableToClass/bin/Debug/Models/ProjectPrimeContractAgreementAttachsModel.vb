
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectPrimeContractAgreementAttachsModel


	''' <summary>
	''' 关联协议单ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("关联协议单ID")>
	Public Property ID As Integer

	''' <summary>
	''' 所属项目ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("所属项目ID")>
	Public Property PID As Integer?

	''' <summary>
	''' 所属合同ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("所属合同ID")>
	Public Property CID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property EID As Integer?

	''' <summary>
	''' 附件名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("附件名称")>
	Public Property FileName As String

	''' <summary>
	''' 文件大小
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("文件大小")>
	Public Property FileSize As String

	''' <summary>
	''' 文件体
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("文件体")>
	Public Property FileBody As Byte()

	''' <summary>
	''' 上传日期
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("上传日期")>
	Public Property UlDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property NasHost As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property NasUser As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property NasPasw As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property NasPath As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property FileState As Integer?

	Public Sub New()
		Me.UlDate = Now
		Me.FileState = 0
	End Sub

End Class

Partial Public Class ProjectPrimeContractAgreementAttachsMap
    Inherits EntityTypeConfiguration(Of ProjectPrimeContractAgreementAttachsModel)
	Public Sub New()
		Me.ToTable("ProjectPrimeContractAgreementAttachs")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.PID)
		Me.Property(Function(t) t.CID)
		Me.Property(Function(t) t.EID)
		Me.Property(Function(t) t.FileName)
		Me.Property(Function(t) t.FileSize)
		Me.Property(Function(t) t.FileBody)
		Me.Property(Function(t) t.UlDate)
		Me.Property(Function(t) t.NasHost)
		Me.Property(Function(t) t.NasUser)
		Me.Property(Function(t) t.NasPasw)
		Me.Property(Function(t) t.NasPath)
		Me.Property(Function(t) t.FileState)

	End Sub
End Class
