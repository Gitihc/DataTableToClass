
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class UserFilesModel


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
	Public Property FolderID As Integer?

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
	Public Property FileSize As Decimal?

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
	Public Property EditDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UploadDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property FileBody As Byte()

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

Partial Public Class UserFilesMap
    Inherits EntityTypeConfiguration(Of UserFilesModel)
	Public Sub New()
		Me.ToTable("UserFiles")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.TypeID)
		Me.Property(Function(t) t.FolderID)
		Me.Property(Function(t) t.FileName)
		Me.Property(Function(t) t.FileSize)
		Me.Property(Function(t) t.FileType)
		Me.Property(Function(t) t.EditDate)
		Me.Property(Function(t) t.UploadDate)
		Me.Property(Function(t) t.FileBody)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.FileURL)
		Me.Property(Function(t) t.FileState)
		Me.Property(Function(t) t.NasHost)
		Me.Property(Function(t) t.NasUser)
		Me.Property(Function(t) t.NasPasw)
		Me.Property(Function(t) t.NasPath)

	End Sub
End Class
