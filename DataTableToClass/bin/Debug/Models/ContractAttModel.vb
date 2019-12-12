
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ContractAttModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 合同ＩＤ
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ContractID As Integer?

	''' <summary>
	''' 附件类别:1-合同文件；2-验收文档；3－交付成果；4-过程文档( 详细类型见表ContractAttType)
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Type As Integer?

	''' <summary>
	''' 附件标题
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Title As String

	''' <summary>
	''' 附件体
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Attachment As Byte()

	''' <summary>
	''' 附件备注
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

	''' <summary>
	''' 是否上传了文件（0：无文件，1：有文件）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property HasFile As Integer?

	''' <summary>
	''' 记录从项目引用的文件id
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OutFileID As Integer?

	''' <summary>
	''' 上传文件的名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OriginalName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileURL As String

	''' <summary>
	''' 文件状态： 0-正常；1-上传中；2-上传失败
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileState As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NasHost As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NasUser As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NasPasw As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NasPath As String

End Class

Partial Public Class ContractAttMap
    Inherits EntityTypeConfiguration(Of ContractAttModel)
	Public Sub New()
		Me.ToTable("ContractAtt")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.ContractID)
		Me.Property(Function(t) t.Type)
		Me.Property(Function(t) t.Title)
		Me.Property(Function(t) t.Attachment)
		Me.Property(Function(t) t.Note)
		Me.Property(Function(t) t.HasFile)
		Me.Property(Function(t) t.OutFileID)
		Me.Property(Function(t) t.OriginalName)
		Me.Property(Function(t) t.FileURL)
		Me.Property(Function(t) t.FileState)
		Me.Property(Function(t) t.NasHost)
		Me.Property(Function(t) t.NasUser)
		Me.Property(Function(t) t.NasPasw)
		Me.Property(Function(t) t.NasPath)

	End Sub
End Class
