
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectFileModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TypeID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UploaderID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UploadTime As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileBody As Byte()

	''' <summary>
	''' 文件位置（文件为外链时使用）
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileURL As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProjectID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property TaskID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileType As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileSize As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property HasFile As Integer?

	''' <summary>
	''' 文件原始名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property OriginalName As String

	''' <summary>
	''' 已读标记：0-未读；1-已读
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property IsViewed As Integer?

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

Partial Public Class ProjectFileMap
    Inherits EntityTypeConfiguration(Of ProjectFileModel)
	Public Sub New()
		Me.ToTable("ProjectFile")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.TypeID)
		Me.Property(Function(t) t.FileName)
		Me.Property(Function(t) t.UploaderID)
		Me.Property(Function(t) t.UploadTime)
		Me.Property(Function(t) t.FileBody)
		Me.Property(Function(t) t.FileURL)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.TaskID)
		Me.Property(Function(t) t.FileType)
		Me.Property(Function(t) t.FileSize)
		Me.Property(Function(t) t.HasFile)
		Me.Property(Function(t) t.OriginalName)
		Me.Property(Function(t) t.IsViewed)
		Me.Property(Function(t) t.FileState)
		Me.Property(Function(t) t.NasHost)
		Me.Property(Function(t) t.NasUser)
		Me.Property(Function(t) t.NasPasw)
		Me.Property(Function(t) t.NasPath)

	End Sub
End Class
