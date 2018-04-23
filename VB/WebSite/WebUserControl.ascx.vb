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
Imports DevExpress.Web.ASPxNavBar
Imports DevExpress.Web.ASPxEditors

Partial Public Class WebUserControl
	Inherits System.Web.UI.UserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Private fGroupIndex As String

	Public Property GroupIndex() As String
		Get
			Return fGroupIndex
		End Get
		Set(ByVal value As String)
			fGroupIndex = value
		End Set
	End Property

	Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		ASPxButton1.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, true, " & GroupIndex & ")}"
		ASPxButton2.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, false, " & GroupIndex & ")}"
	End Sub
End Class
