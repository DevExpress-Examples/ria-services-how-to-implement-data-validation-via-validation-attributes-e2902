Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace Q306524RiaServicesValidation.Web
    Partial Public Class TestTable
        Implements IDataErrorInfo
#Region "IDataErrorInfo Members"
        Private ReadOnly Property IDataErrorInfo_Error() As String Implements IDataErrorInfo.Error
            Get
                Return String.Empty
            End Get
        End Property

        Public ReadOnly Property IDataErrorInfo_Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                If (Not HasValidationErrors) Then
                    Return String.Empty
                End If
                Dim sb As New StringBuilder()
                For Each validationResult As ValidationResult In ValidationErrors
                    If validationResult.MemberNames.Contains(columnName) Then
                        sb.Append(validationResult.ErrorMessage)
                    End If
                Next validationResult
                Return sb.ToString()
            End Get
        End Property
#End Region
    End Class
End Namespace
