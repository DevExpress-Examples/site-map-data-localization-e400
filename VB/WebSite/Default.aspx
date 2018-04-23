<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v8.2" Namespace="DevExpress.Web.ASPxSiteMapControl"
	TagPrefix="dxsm" %>
<%@ Register Assembly="DevExpress.Web.v8.2" Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dxm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<dxsm:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server"
			SiteMapFileName="~/web.sitemap" />
		<asp:Label ID="Label1" runat="server" Text="Select culture:"></asp:Label>
		<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
			<asp:ListItem Text="English" Value="en-US" Selected="True"></asp:ListItem>
			<asp:ListItem Text="Deutsch" Value="de-DE"></asp:ListItem>
		</asp:DropDownList>
		<br />
		<br />
		<dxm:ASPxMenu ID="ASPxMenu1" runat="server" DataSourceID="ASPxSiteMapDataSource1">
		</dxm:ASPxMenu>
	</form>
</body>
</html>
