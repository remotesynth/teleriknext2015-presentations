<%@ Page Language="C#" AutoEventWireup="true" CodeFile="finished-adaptive-rendering.aspx.cs" Inherits="adaptive_rendering" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width">
    <title>Adaptive Rendering Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>

        <telerik:RadGrid ID="ResponsiveRadGrid" runat="server" OnNeedDataSource="ResponsiveRadGrid_NeedDataSource"
            AllowPaging="true" PageSize="10" AllowFilteringByColumn="true">
        </telerik:RadGrid>

    </form>
</body>
</html>
