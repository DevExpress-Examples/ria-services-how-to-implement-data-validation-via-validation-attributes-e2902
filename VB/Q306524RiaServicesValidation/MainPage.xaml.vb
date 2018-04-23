Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports Q306524RiaServicesValidation.Web
Imports System.ServiceModel.DomainServices.Client
Imports DevExpress.Xpf.Grid

Namespace Q306524RiaServicesValidation
	Partial Public Class MainPage
		Inherits UserControl
		Private domainContext As New TestDomainContext()

		Public Sub New()
			InitializeComponent()

			Dim loadOp As LoadOperation(Of TestTable) = domainContext.Load(domainContext.GetTestTableQuery())
			gridControl.DataSource = loadOp.Entities
		End Sub

		Private Sub TableView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.GridRowValidationEventArgs)
			Dim row As TestTable = TryCast(e.Row, TestTable)
			If row.HasValidationErrors Then
				e.IsValid = False
				e.ErrorContent = "Row cannot be commited."
			End If
		End Sub

		Private Sub TableView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.InvalidRowExceptionEventArgs)
			e.ExceptionMode = ExceptionMode.NoAction
		End Sub
	End Class
End Namespace
