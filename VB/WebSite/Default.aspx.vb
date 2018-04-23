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
Imports DevExpress.Web.ASPxNavBar
Imports DevExpress.Web.ASPxEditors

Partial Public Class ASPxperience_NavBar_ClientAccessToControlsInTemplate
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Function GetItemClientName(ByVal container As NavBarItemTemplateContainer) As String
		Dim name As String = "Item_" & container.Item.Group.Index.ToString() & "_" & container.Item.Index.ToString()
		Return name
	End Function

	Protected Function GetGroupIndex(ByVal container As NavBarItemTemplateContainer) As String
		Dim index As String = container.Item.Group.Index.ToString()
		Return index
	End Function
End Class

