
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class ProblemFilesModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 文件名称
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Name As String

	''' <summary>
	''' 文件内容
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Context As Byte()

	''' <summary>
	''' 文件大小
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Size As String

	''' <summary>
	''' 上传者
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Loader As Integer?

	''' <summary>
	''' 上传时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Time As DateTime?

	''' <summary>
	''' 问题ID
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ProblemID As Integer?

	''' <summary>
	''' 文件后缀
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Extension As String

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
	Public Property FileURL As String

End Class

Partial Public Class ProblemFilesMap
    Inherits EntityTypeConfiguration(Of ProblemFilesModel)
	Public Sub New()
		Me.ToTable("ProblemFiles")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.Name)
		Me.Property(Function(t) t.Context)
		Me.Property(Function(t) t.Size)
		Me.Property(Function(t) t.Loader)
		Me.Property(Function(t) t.Time)
		Me.Property(Function(t) t.ProblemID)
		Me.Property(Function(t) t.Extension)
		Me.Property(Function(t) t.ProjectID)
		Me.Property(Function(t) t.TaskID)
		Me.Property(Function(t) t.FileURL)

	End Sub
End Class
