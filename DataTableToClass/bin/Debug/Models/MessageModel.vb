
Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class MessageModel


	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ID As Integer

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property FromUserID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property FromUserName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ToUserID As Integer?

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property ToUserName As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property Title As String

	''' <summary>
	''' 
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Description("")>
	Public Property MessageContent As String

	Public Sub New()
	End Sub

End Class

Partial Public Class MessageMap
    Inherits EntityTypeConfiguration(Of MessageModel)
	Public Sub New()
		Me.ToTable("Message")
		Me.HasKey(Function(s) s.ID)
		Me.Property(Function(t) t.FromUserID)
		Me.Property(Function(t) t.FromUserName)
		Me.Property(Function(t) t.ToUserID)
		Me.Property(Function(t) t.ToUserName)
		Me.Property(Function(t) t.Title)
		Me.Property(Function(t) t.MessageContent)

	End Sub
End Class
