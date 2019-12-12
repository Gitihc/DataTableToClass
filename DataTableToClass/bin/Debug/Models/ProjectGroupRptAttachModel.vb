
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProjectGroupRptAttachModel


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
	Public Property GID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RID As Integer?

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
	Public Property FileBody As Byte()

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
	Public Property FileSize As Integer?

	''' <summary>
	''' 上传者ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UserID As Integer?

	''' <summary>
	''' 上传时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property UpLoadDate As DateTime?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Note As String

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
	''' Nas存储设备路径
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property NasPath As String

End Class

Partial Public Class ProjectGroupRptAttachMap
    Inherits EntityTypeConfiguration(Of ProjectGroupRptAttachModel)
	Public Sub New()
		Me.ToTable("ProjectGroupRptAttach")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.GID)
		Me.Property(Function(t) t.RID)
		Me.Property(Function(t) t.FileName)
		Me.Property(Function(t) t.FileBody)
		Me.Property(Function(t) t.FileType)
		Me.Property(Function(t) t.FileSize)
		Me.Property(Function(t) t.UserID)
		Me.Property(Function(t) t.UpLoadDate)
		Me.Property(Function(t) t.Note)
		Me.Property(Function(t) t.FileURL)
		Me.Property(Function(t) t.FileState)
		Me.Property(Function(t) t.NasHost)
		Me.Property(Function(t) t.NasUser)
		Me.Property(Function(t) t.NasPasw)
		Me.Property(Function(t) t.NasPath)

	End Sub
End Class
