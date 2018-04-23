Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace InstantEditing
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			XpoDataSource1.Session = XpoHelper.GetNewSession()
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				ASPxGridView1.DataBind() ' prepares the grid for the first StartEdit method call from FocusedRowChanged
			End If
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub ASPxGridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.UpdateEdit()
			ASPxGridView1.StartEdit(ASPxGridView1.FocusedRowIndex)
			ASPxGridView1.DataBind()
		End Sub
	End Class
End Namespace