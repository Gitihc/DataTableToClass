﻿Imports System

'------------------------------------------------------------------------------
'<auto-generated>
'    此代码由工具生成。
'    运行时版本: 10.0.0.0
' 
'    对此文件的更改可能会导致不正确的行为。此外，如果
'    重新生成代码，这些更改将会丢失。
'</auto-generated>
'------------------------------------------------------------------------------
<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")>  _
Partial Public Class VBModelTemplate
    Inherits VBModelTemplateBase
    Public Overridable Function TransformText() As String
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Imports System.Data.Entity.ModelConfiguration"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Imports System.ComponentModel"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"''' <summary>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"''' "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"''' </summary>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"''' <remarks></remarks>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Public Class ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",10)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(modelName))
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",12)
 For Each column in listColumns 
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' <summary>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",15)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.Remark))
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' </summary>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' <value></value>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' <returns></returns>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"''' <remarks>"& _ 
                "</remarks>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"<Description(""")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",20)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.Remark))
        
        #End ExternalSource
        Me.Write(""")>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"Public Property ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",21)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.ColumnName))
        
        #End ExternalSource
        Me.Write(" As ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",21)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.CSharpType))
        
        #End ExternalSource
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",21)
 if(column.CommonType.IsValueType andalso column.IsNullable)
        
        #End ExternalSource
        Me.Write("?")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",21)
End If
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",23)
 Next 
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"Public Sub New()"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",26)
 For Each column in listColumns 
        
        #End ExternalSource
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",27)
 if(column.DefaultValue.length > 0) 
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(9)&"Me.")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",28)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.ColumnName))
        
        #End ExternalSource
        Me.Write(" = ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",28)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.DefaultValue))
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",29)
End If
        
        #End ExternalSource
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",30)
 Next 
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&"End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"End Class"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Partial Public Class ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",35)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(mapName))
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"    Inherits EntityTypeConfiguration(Of ")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",36)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(modelName))
        
        #End ExternalSource
        Me.Write(")"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"Public Sub New()"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(9)&"Me.ToTable(""")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",38)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(tableName))
        
        #End ExternalSource
        Me.Write(""")"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",39)
For Each column in listColumns 
If column.IsPrimaryKey then
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(9)&"Me.HasKey(Function(s) s.")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",41)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.ColumnName))
        
        #End ExternalSource
        Me.Write(")"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",42)
Else
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(9))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",43)

        Dim suffixStr = ""
        If column.CommonType = GetType(Decimal) OrElse column.CommonType = GetType(Double) Then
            suffixStr += ".HasPrecision(18, " + column.Scale.toString() + ")"
        End If

		If column.DefaultValue =  "Now" Then
			suffixStr += ".HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)"
		End If

		If column.ColumnType.ToString() =  "timestamp" Then
			suffixStr += ".IsRowVersion()"
		End If

		If column.ColumnType.ToString() =  "varchar" AndAlso column.CharLength >0 Then
			suffixStr += ".HasMaxLength("& column.CharLength &")"
		End If
		
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(9)&"Me.Property(Function(t) t.")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",61)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(column.ColumnName))
        
        #End ExternalSource
        Me.Write(")")
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",61)
        Me.Write(Me.ToStringHelper.ToStringWithCulture(suffixStr))
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        
        #ExternalSource("E:\Visual Studio 2010\Projects\DataTableToClass\DataTableToClass\Templates\VBModelTemplate.tt",62)
End If
Next
        
        #End ExternalSource
        Me.Write(""&Global.Microsoft.VisualBasic.ChrW(9)&"End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"End Class"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
        Return Me.GenerationEnvironment.ToString
    End Function
End Class
#Region "Base class"
'''<summary>
'''Base class for this transformation
'''</summary>
<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")>  _
Public Class VBModelTemplateBase
    #Region "Fields"
    Private generationEnvironmentField As Global.System.Text.StringBuilder
    Private errorsField As Global.System.CodeDom.Compiler.CompilerErrorCollection
    Private indentLengthsField As Global.System.Collections.Generic.List(Of Integer)
    Private currentIndentField As String = ""
    Private endsWithNewline As Boolean
    Private sessionField As Global.System.Collections.Generic.IDictionary(Of String, Object)
    #End Region
    #Region "Properties"
    '''<summary>
    '''The string builder that generation-time code is using to assemble generated output
    '''</summary>
    Protected Property GenerationEnvironment() As System.Text.StringBuilder
        Get
            If (Me.generationEnvironmentField Is Nothing) Then
                Me.generationEnvironmentField = New Global.System.Text.StringBuilder()
            End If
            Return Me.generationEnvironmentField
        End Get
        Set
            Me.generationEnvironmentField = value
        End Set
    End Property
    '''<summary>
    '''The error collection for the generation process
    '''</summary>
    Public ReadOnly Property Errors() As System.CodeDom.Compiler.CompilerErrorCollection
        Get
            If (Me.errorsField Is Nothing) Then
                Me.errorsField = New Global.System.CodeDom.Compiler.CompilerErrorCollection()
            End If
            Return Me.errorsField
        End Get
    End Property
    '''<summary>
    '''A list of the lengths of each indent that was added with PushIndent
    '''</summary>
    Private ReadOnly Property indentLengths() As System.Collections.Generic.List(Of Integer)
        Get
            If (Me.indentLengthsField Is Nothing) Then
                Me.indentLengthsField = New Global.System.Collections.Generic.List(Of Integer)()
            End If
            Return Me.indentLengthsField
        End Get
    End Property
    '''<summary>
    '''Gets the current indent we use when adding lines to the output
    '''</summary>
    Public ReadOnly Property CurrentIndent() As String
        Get
            Return Me.currentIndentField
        End Get
    End Property
    '''<summary>
    '''Current transformation session
    '''</summary>
    Public Overridable Property Session() As Global.System.Collections.Generic.IDictionary(Of String, Object)
        Get
            Return Me.sessionField
        End Get
        Set
            Me.sessionField = value
        End Set
    End Property
    #End Region
    #Region "Transform-time helpers"
    '''<summary>
    '''Write text directly into the generated output
    '''</summary>
    Public Overloads Sub Write(ByVal textToAppend As String)
        If String.IsNullOrEmpty(textToAppend) Then
            Return
        End If
        'If we're starting off, or if the previous text ended with a newline,
        'we have to append the current indent first.
        If ((Me.GenerationEnvironment.Length = 0)  _
                    OrElse Me.endsWithNewline) Then
            Me.GenerationEnvironment.Append(Me.currentIndentField)
            Me.endsWithNewline = false
        End If
        'Check if the current text ends with a newline
        If textToAppend.EndsWith(Global.System.Environment.NewLine, Global.System.StringComparison.CurrentCulture) Then
            Me.endsWithNewline = true
        End If
        'This is an optimization. If the current indent is "", then we don't have to do any
        'of the more complex stuff further down.
        If (Me.currentIndentField.Length = 0) Then
            Me.GenerationEnvironment.Append(textToAppend)
            Return
        End If
        'Everywhere there is a newline in the text, add an indent after it
        textToAppend = textToAppend.Replace(Global.System.Environment.NewLine, (Global.System.Environment.NewLine + Me.currentIndentField))
        'If the text ends with a newline, then we should strip off the indent added at the very end
        'because the appropriate indent will be added when the next time Write() is called
        If Me.endsWithNewline Then
            Me.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - Me.currentIndentField.Length))
        Else
            Me.GenerationEnvironment.Append(textToAppend)
        End If
    End Sub
    '''<summary>
    '''Write text directly into the generated output
    '''</summary>
    Public Overloads Sub WriteLine(ByVal textToAppend As String)
        Me.Write(textToAppend)
        Me.GenerationEnvironment.AppendLine
        Me.endsWithNewline = true
    End Sub
    '''<summary>
    '''Write formatted text directly into the generated output
    '''</summary>
    Public Overloads Sub Write(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
        Me.Write(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
    End Sub
    '''<summary>
    '''Write formatted text directly into the generated output
    '''</summary>
    Public Overloads Sub WriteLine(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
        Me.WriteLine(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
    End Sub
    '''<summary>
    '''Raise an error
    '''</summary>
    Public Sub [Error](ByVal message As String)
        Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
        [error].ErrorText = message
        Me.Errors.Add([error])
    End Sub
    '''<summary>
    '''Raise a warning
    '''</summary>
    Public Sub Warning(ByVal message As String)
        Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
        [error].ErrorText = message
        [error].IsWarning = true
        Me.Errors.Add([error])
    End Sub
    '''<summary>
    '''Increase the indent
    '''</summary>
    Public Sub PushIndent(ByVal indent As String)
        If (indent = Nothing) Then
            Throw New Global.System.ArgumentNullException("indent")
        End If
        Me.currentIndentField = (Me.currentIndentField + indent)
        Me.indentLengths.Add(indent.Length)
    End Sub
    '''<summary>
    '''Remove the last indent that was added with PushIndent
    '''</summary>
    Public Function PopIndent() As String
        Dim returnValue As String = ""
        If (Me.indentLengths.Count > 0) Then
            Dim indentLength As Integer = Me.indentLengths((Me.indentLengths.Count - 1))
            Me.indentLengths.RemoveAt((Me.indentLengths.Count - 1))
            If (indentLength > 0) Then
                returnValue = Me.currentIndentField.Substring((Me.currentIndentField.Length - indentLength))
                Me.currentIndentField = Me.currentIndentField.Remove((Me.currentIndentField.Length - indentLength))
            End If
        End If
        Return returnValue
    End Function
    '''<summary>
    '''Remove any indentation
    '''</summary>
    Public Sub ClearIndent()
        Me.indentLengths.Clear
        Me.currentIndentField = ""
    End Sub
    #End Region
    #Region "ToString Helpers"
    '''<summary>
    '''Utility class to produce culture-oriented representation of an object as a string.
    '''</summary>
    Public Class ToStringInstanceHelper
        Private formatProviderField  As System.IFormatProvider = Global.System.Globalization.CultureInfo.InvariantCulture
        '''<summary>
        '''Gets or sets format provider to be used by ToStringWithCulture method.
        '''</summary>
        Public Property FormatProvider() As System.IFormatProvider
            Get
                Return Me.formatProviderField 
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    Me.formatProviderField  = value
                End If
            End Set
        End Property
        '''<summary>
        '''This is called from the compile/run appdomain to convert objects within an expression block to a string
        '''</summary>
        Public Function ToStringWithCulture(ByVal objectToConvert As Object) As String
            If (objectToConvert Is Nothing) Then
                Throw New Global.System.ArgumentNullException("objectToConvert")
            End If
            Dim t As System.Type = objectToConvert.GetType
            Dim method As System.Reflection.MethodInfo = t.GetMethod("ToString", New System.Type() {GetType(System.IFormatProvider)})
            If (method Is Nothing) Then
                Return objectToConvert.ToString
            Else
                Return CType(method.Invoke(objectToConvert, New Object() {Me.formatProviderField }),String)
            End If
        End Function
    End Class
    Private toStringHelperField As ToStringInstanceHelper = New ToStringInstanceHelper()
    Public ReadOnly Property ToStringHelper() As ToStringInstanceHelper
        Get
            Return Me.toStringHelperField
        End Get
    End Property
    #End Region
End Class
#End Region
