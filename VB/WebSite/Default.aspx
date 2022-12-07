<%-- BeginRegion Page setup --%>
<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="ASPxperience_NavBar_ClientAccessToControlsInTemplate" %>

<%@ Register Src="WebUserControl.ascx" TagName="WebUserControl" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxnb" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxe" %>
<%-- EndRegion --%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>How to access and manipulate controls, contained within an ItemTemplate, on the client side</title>
</head>
<body>
	<form id="form1" runat="server">


<script type="text/javascript">
var cbItems = new Array();

function OnButtonClick(s, e, checked, groupIndex){
	for (var i = 0; i < cbItems.length; i++){
		if(cbItems[i][0] == groupIndex){
			var checkBox = cbItems[i][1];
			checkBox.SetChecked(checked);
		}
	}
}
</script>

	<div>
		<dxnb:ASPxNavBar ID="ASPxNavBar1" runat="server" ClientInstanceName="navBar" EnableClientSideAPI="True">
			<Groups>

				<dxnb:NavBarGroup Text="Group1">
					<Items>
						<dxnb:NavBarItem Text="Item1">
						</dxnb:NavBarItem>
						<dxnb:NavBarItem Text="Item2">
						</dxnb:NavBarItem>
						<dxnb:NavBarItem Text="Item3">
						</dxnb:NavBarItem>                        
						<dxnb:NavBarItem Text="Item4">
						<Template>
							<uc1:WebUserControl id="WebUserControl1" runat="server" GroupIndex="<%#GetGroupIndex(Container)%>">
							</uc1:WebUserControl>
						</Template>
						</dxnb:NavBarItem>
					</Items>
					<ItemTemplate>
						<dxe:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ClientInstanceName="<%#GetItemClientName(Container)%>" Text="<%#Container.Item.Text%>">
						</dxe:ASPxCheckBox>
						<%#"<script type='text/javascript'>cbItems.push(new Array(" & GetGroupIndex(Container) & ", " & GetItemClientName(Container) & "));</script>"%>
					</ItemTemplate>
				</dxnb:NavBarGroup>

				<dxnb:NavBarGroup Text="Group2">
					<Items>
						<dxnb:NavBarItem Text="Item1">
						</dxnb:NavBarItem>
						<dxnb:NavBarItem Text="Item2">
						</dxnb:NavBarItem>
						<dxnb:NavBarItem Text="Item3">
						</dxnb:NavBarItem>                        
						<dxnb:NavBarItem Text="Item4">
						<Template>
							<uc1:WebUserControl id="WebUserControl1" runat="server" GroupIndex="<%#GetGroupIndex(Container)%>">
							</uc1:WebUserControl>
						</Template>
						</dxnb:NavBarItem>
					</Items>
					<ItemTemplate>
						<dxe:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ClientInstanceName="<%#GetItemClientName(Container)%>" Text="<%#Container.Item.Text%>">
						</dxe:ASPxCheckBox>
						<%#"<script type='text/javascript'>cbItems.push(new Array(" & GetGroupIndex(Container) & ", " & GetItemClientName(Container) & "));</script>"%>
					</ItemTemplate>
				</dxnb:NavBarGroup>                

			</Groups>
		</dxnb:ASPxNavBar>
	</div>
	</form>
</body>
</html>
