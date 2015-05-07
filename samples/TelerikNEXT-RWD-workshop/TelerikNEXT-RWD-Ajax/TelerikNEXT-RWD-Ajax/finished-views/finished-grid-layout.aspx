<%@ Page Language="C#" AutoEventWireup="true" CodeFile="finished-grid-layout.aspx.cs" Inherits="ultimate_grid_layout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width">
    <link href="../styles/base.css" rel="stylesheet" />
    <style type="text/css">

        .headerClass {
            height: 200px;
            background-color: #f5f5f5;
            padding-left: 20px;
            font-size: 2em;
            line-height: 200px;
        }

        .contentRowClass {
            margin-top: 10px;
            margin-bottom: 10px;
        }

        .contentRightClass {
            background-color: #f5f5f5;
            margin-top: 10px;
            margin-top: 10px;
            padding: 10px;
        }

        .footerClass {
            background-color: #f5f5f5;
            margin-top: 10px;
            padding: 10px;
        }

        .borderClass div {
            border: 1px solid red;
        }
    </style>
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

        <telerik:RadPageLayout ID="RadPageLayout1" runat="server" GridType="Fluid" HtmlTag="Div">
            <Rows>
                <telerik:LayoutRow>
                    <Content>
                        <div class="headerClass">
                            <h1>TelerikNext</h1>
                        </div>
                    </Content>
                </telerik:LayoutRow>
                <telerik:LayoutRow CssClass="contentRowClass">
                    <Columns>
                        <telerik:LayoutColumn Span="7">
                            <div class="contentLeftClass">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer risus justo, gravida a magna malesuada, viverra egestas elit. Vivamus pretium et sapien vitae accumsan. Maecenas ornare fermentum odio, vel ullamcorper ex maximus sed. Morbi pretium lorem et condimentum dignissim. Proin consequat et mauris sit amet imperdiet. Integer nec consequat mauris. In hac habitasse platea dictumst. Ut dapibus urna sit amet urna accumsan ultrices. Nulla elementum pulvinar molestie. Etiam magna felis, mattis ultricies porta et, pharetra id quam. Etiam vitae velit a eros finibus facilisis nec quis mi. Aliquam erat volutpat.
                                </p>
                                <p>
                                    Vivamus eget nisi in lectus dictum lacinia. Nulla rhoncus mauris leo, quis lobortis ante pretium id. Morbi commodo mollis sagittis. Quisque suscipit ultrices ante ac viverra. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed non eros nec urna dignissim venenatis. Nulla ullamcorper congue magna. Nunc et ipsum purus. Donec tincidunt tellus sed euismod scelerisque. Integer nec ornare metus. Maecenas interdum orci nec leo consectetur vehicula. Integer dapibus massa sit amet turpis ultricies semper. Etiam in dolor ligula. Morbi in magna quis elit accumsan cursus sed at felis. Morbi feugiat, risus sed tempor feugiat, ex urna sagittis tellus, sit amet semper lacus lectus non odio. Donec sollicitudin augue nulla.
                                </p>
                            </div>
                        </telerik:LayoutColumn>
                        <telerik:CompositeLayoutColumn Span="5" HiddenXs="true">
                            <Rows>
                                <telerik:LayoutRow>
                                    <Content>
                                       <div class="contentRightClass">
                                           <h3>Upcoming Sessions</h3>
                                           <p>Sample Session</p>
                                       </div>
                                    </Content>
                                </telerik:LayoutRow>
                                <telerik:LayoutRow HiddenSm="true">
                                    <Content>
                                        <div class="contentRightClass">
                                            <h3>Twitter Feed</h3>
                                            <p>Tweet tweeet</p>
                                        </div>
                                    </Content>
                                </telerik:LayoutRow>
                            </Rows>
                        </telerik:CompositeLayoutColumn>
                    </Columns>
                </telerik:LayoutRow>
                <telerik:LayoutRow>
                    <Content>
                        <div class="footerClass">
                            Copyright TelerikNext Workshop Session
                        </div>
                    </Content>
                </telerik:LayoutRow>
            </Rows>
        </telerik:RadPageLayout>
    </form>
</body>
</html>
