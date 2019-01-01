<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program.aspx.cs" Inherits="NYP.program" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
    <div>
        <h2>Program List</h2>
    <asp:GridView ID="GV_Exchange_List" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" />
                <asp:BoundField DataField="Accommodation_Type" HeaderText="Accommodation Type" />
                <asp:BoundField DataField="Quota" HeaderText="Quota" />
                <asp:BoundField DataField="No_Of_Registered" HeaderText="No Registered " />
                <asp:BoundField DataField="Fees" HeaderText="Fees" />
                
                <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:Button ID="regiser" runat="server" onclick="regiser_Click" Text="Register" />
                </ItemTemplate>
            </asp:TemplateField>
                
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
