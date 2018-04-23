Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace InstantEditing
	Public Class Model
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property
		Private _Price As Decimal
		Public Property Price() As Decimal
			Get
				Return _Price
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue("Price", _Price, value)
			End Set
		End Property
		Private _Announced As DateTime
		Public Property Announced() As DateTime
			Get
				Return _Announced
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("Announced", _Announced, value)
			End Set
		End Property
		Private _Discontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return _Discontinued
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue("Discontinued", _Discontinued, value)
			End Set
		End Property
	End Class
End Namespace