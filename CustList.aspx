<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustList.aspx.cs" Inherits="Account_Management.CustList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gv_CustList" runat="server" AutoGenerateColumns="False" DataKeyNames="Cust_ID">
            <Columns>
                <asp:BoundField HeaderText="Customer ID" DataField="Cust_ID" />
                <asp:BoundField HeaderText="First Name" DataField="First_Name" />
                <asp:BoundField HeaderText="Last Name" DataField="Last_Name" />
                <asp:BoundField HeaderText="DOB" DataField="DOB" />
                <asp:BoundField HeaderText="Profile Picture" DataField="Cust_Picture" />
                <asp:BoundField HeaderText="Email" DataField="Cust_Email" />
                <asp:BoundField HeaderText="Phone Number" DataField="Cust_HP" />
                <asp:BoundField HeaderText="Address" DataField="Cust_Address" />
                <asp:BoundField HeaderText="Postal Code" DataField="Cust_Postal" />
                <asp:BoundField HeaderText="Referred By" />
                <asp:CommandField EditText="Update" HeaderText="Update Details" ShowEditButton="True" />
                <asp:CommandField HeaderText="Delete Customer" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
