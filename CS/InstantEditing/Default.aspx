<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InstantEditing._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.3, Version=9.3.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Xpo.v9.3, Version=9.3.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dxxpo" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.3, Version=9.3.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to force the grid to stay in Edit mode</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" ClientInstanceName="grid" 
        DataSourceID="XpoDataSource1" KeyFieldName="Oid" OnFocusedRowChanged="ASPxGridView1_FocusedRowChanged" Width="564px">
            <SettingsBehavior AllowFocusedRow="True" ProcessFocusedRowChangedOnServer="True" />
            <SettingsEditing Mode="Inline" />
            <Columns>
                <dxwgv:GridViewDataTextColumn FieldName="Oid" ReadOnly="True" Visible="False" VisibleIndex="1" SortOrder="Ascending" SortIndex="0">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Name" VisibleIndex="0">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Price" VisibleIndex="1">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataDateColumn FieldName="Announced" VisibleIndex="2">
                </dxwgv:GridViewDataDateColumn>
                <dxwgv:GridViewDataCheckColumn FieldName="Discontinued" VisibleIndex="3">
                </dxwgv:GridViewDataCheckColumn>
            </Columns>
        </dxwgv:ASPxGridView>
        <dxxpo:XpoDataSource ID="XpoDataSource1" runat="server" TypeName="InstantEditing.Model">
        </dxxpo:XpoDataSource>
    </div>
    </form>
</body>
</html>
