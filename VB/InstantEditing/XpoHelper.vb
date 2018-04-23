Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata

Namespace InstantEditing
	''' <summary>
	''' Summary description for XpoHelper
	''' </summary>
	Public NotInheritable Class XpoHelper
		Private Sub New()
		End Sub
		Shared Sub New()
			CreateDefaultObjects()
		End Sub

		Public Shared Function GetNewSession() As Session
			Return New Session(DataLayer)
		End Function

		Public Shared Function GetNewUnitOfWork() As UnitOfWork
			Return New UnitOfWork(DataLayer)
		End Function

		Private ReadOnly Shared lockObject As Object = New Object()

		Private Shared fDataLayer As IDataLayer
		Private Shared ReadOnly Property DataLayer() As IDataLayer
			Get
				If fDataLayer Is Nothing Then
					SyncLock lockObject
						fDataLayer = GetDataLayer()
					End SyncLock
				End If
				Return fDataLayer
			End Get
		End Property

		Private Shared Function GetDataLayer() As IDataLayer
			XpoDefault.Session = Nothing

			Dim provider As New InMemoryDataStore()
			Dim dl As IDataLayer = New SimpleDataLayer(provider)

			Return dl
		End Function

		Private Shared Sub CreateDefaultObjects()
			Using uow As UnitOfWork = GetNewUnitOfWork()
				Dim model As New Model(uow)
				model.Name = "SD970 IS"
				model.Price = 379.99D
				model.Discontinued = False
				model.Announced = New DateTime(2009, 2, 18)

				model = New Model(uow)
				model.Name = "G10"
				model.Price = 419.99D
				model.Discontinued = False
				model.Announced = New DateTime(2008, 9, 17)

				model = New Model(uow)
				model.Name = "A580"
				model.Price = 118.00D
				model.Discontinued = False
				model.Announced = New DateTime(2008, 1, 24)

				model = New Model(uow)
				model.Name = "EOS D30"
				model.Price = 275.00D
				model.Discontinued = True
				model.Announced = New DateTime(2000, 5, 17)

				uow.CommitChanges()
			End Using
		End Sub
	End Class
End Namespace