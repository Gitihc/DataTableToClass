
Imports System.Data.Entity.ModelConfiguration

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class HLShortUrlMapModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ID As Integer

	''' <summary>
	''' 短地址计算值
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property RandKey As Long?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ShortURL As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property LongURL As String

	''' <summary>
	''' 创建时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateDate As DateTime?

	''' <summary>
	''' 过期时间
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property ExpireDate As DateTime?

	''' <summary>
	''' 0 系统: “system” ; 1 自定义: “custom”
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property Type As Integer?

End Class

Partial Public Class HLShortUrlMapMap
    Inherits EntityTypeConfiguration(Of HLShortUrlMapModel)
	Public Sub New()
		Me.ToTable("HLShortUrlMap")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.RandKey)
		Me.Property(Function(t) t.ShortURL)
		Me.Property(Function(t) t.LongURL)
		Me.Property(Function(t) t.CreateDate)
		Me.Property(Function(t) t.ExpireDate)
		Me.Property(Function(t) t.Type)

	End Sub
End Class
