<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Xpo.v13.1.Web, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dxxpo" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to force the grid to stay in Edit mode</title>

    <script type="text/javascript">
        var index = -1;
    
        function grid_RowClick(s, e) {
            if (grid.IsEditing() == true){
                index = e.visibleIndex;
                                                
                s.UpdateEdit();                           
            }
            else{
                s.SetFocusedRowIndex(e.visibleIndex); // for better visual appearence                                
                s.StartEditRow(e.visibleIndex);  
            }
        }
        
        function grid_EndCallback(s, e) {
           if (index != -1) {
               var _index = index;
               index = -1;
               
               s.SetFocusedRowIndex(_index); // for better visual appearence

               s.StartEditRow(_index);
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" ClientInstanceName="grid"
                DataSourceID="xds" KeyFieldName="Oid" Width="564px">
                <SettingsBehavior AllowFocusedRow="True" />
                <SettingsEditing Mode="Inline" />
                <Columns>
                    <dxwgv:GridViewDataTextColumn FieldName="Oid" ReadOnly="True" Visible="False" VisibleIndex="1"
                        SortOrder="Ascending" SortIndex="0">
                    </dxwgv:GridViewDataTextColumn>
                    <dxwgv:GridViewDataTextColumn FieldName="Name" VisibleIndex="0" Width="200px">
                    </dxwgv:GridViewDataTextColumn>
                    <dxwgv:GridViewDataTextColumn FieldName="Price" VisibleIndex="1" Width="150px">
                    </dxwgv:GridViewDataTextColumn>
                    <dxwgv:GridViewDataDateColumn FieldName="Announced" VisibleIndex="2" Width="200px">
                    </dxwgv:GridViewDataDateColumn>
                    <dxwgv:GridViewDataCheckColumn FieldName="Discontinued" VisibleIndex="3" Width="100px">
                    </dxwgv:GridViewDataCheckColumn>
                </Columns>
                <ClientSideEvents RowClick="grid_RowClick" EndCallback="grid_EndCallback" />
            </dxwgv:ASPxGridView>
            <dxxpo:XpoDataSource ID="xds" runat="server" TypeName="Model">
            </dxxpo:XpoDataSource>
        </div>
    </form>
</body>
</html>
