Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.EntityFramework
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace Q306524RiaServicesValidation.Web


	' Implements application logic using the TestEntities context.
	' TODO: Add your application logic to these methods or in additional methods.
	' TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
	' Also consider adding roles to restrict access as appropriate.
	' [RequiresAuthentication]
	<EnableClientAccess()> _
	Public Class TestDomainService
		Inherits LinqToEntitiesDomainService(Of TestEntities)

		' TODO:
		' Consider constraining the results of your query method.  If you need additional input you can
		' add parameters to this method or create additional query methods with different names.
		' To support paging you will need to add ordering to the 'TestTable' query.
		Public Function GetTestTable() As IQueryable(Of TestTable)
			Return Me.ObjectContext.TestTable
		End Function

		Public Sub InsertTestTable(ByVal testTable As TestTable)
			If (testTable.EntityState <> EntityState.Detached) Then
				Me.ObjectContext.ObjectStateManager.ChangeObjectState(testTable, EntityState.Added)
			Else
				Me.ObjectContext.TestTable.AddObject(testTable)
			End If
		End Sub

		Public Sub UpdateTestTable(ByVal currentTestTable As TestTable)
			Me.ObjectContext.TestTable.AttachAsModified(currentTestTable, Me.ChangeSet.GetOriginal(currentTestTable))
		End Sub

		Public Sub DeleteTestTable(ByVal testTable As TestTable)
			If (testTable.EntityState = EntityState.Detached) Then
				Me.ObjectContext.TestTable.Attach(testTable)
			End If
			Me.ObjectContext.TestTable.DeleteObject(testTable)
		End Sub
	End Class
End Namespace


