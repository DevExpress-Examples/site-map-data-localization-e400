Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Threading
Imports System.Globalization

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Overrides Sub InitializeCulture()
		If Request.Form("DropDownList1") IsNot Nothing Then
			Dim selectedLanguage As String = Request.Form("DropDownList1")
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(selectedLanguage)
		End If
		MyBase.InitializeCulture()
	End Sub
	Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxMenu1.DataBind()
	End Sub
End Class
