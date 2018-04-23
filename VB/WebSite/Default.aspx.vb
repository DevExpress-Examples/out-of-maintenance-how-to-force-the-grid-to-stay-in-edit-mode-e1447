Imports Microsoft.VisualBasic
Imports System

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		xds.Session = XpoHelper.GetNewSession()
	End Sub
End Class