<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign-Up Form.aspx.cs" Inherits="Account_Management.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sign Up<br />
            <br />
            First Name :
            <asp:TextBox ID="TextBox1" runat="server" Width="155px"></asp:TextBox>
            <br />
            Last Name :
            <asp:TextBox ID="TextBox2" runat="server" Width="155px"></asp:TextBox>
            <br />
            Date Of Birth :
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            Profile Picture : <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            Email :
            <asp:TextBox ID="TextBox4" runat="server" Width="155px"></asp:TextBox>
            <br />
            Phone Number :
            <asp:TextBox ID="TextBox3" runat="server" Width="155px"></asp:TextBox>
            <br />
            Address :
            <asp:TextBox ID="TextBox5" runat="server" Width="155px"></asp:TextBox>
            <br />
            Postal Code :
            <asp:TextBox ID="TextBox6" runat="server" Width="155px"></asp:TextBox>
            <br />
            New Password :
            <asp:TextBox ID="TextBox7" runat="server" Width="155px"></asp:TextBox>
            <br />
            Confirm Password :
            <asp:TextBox ID="TextBox8" runat="server" Width="155px"></asp:TextBox>
            <br />
            Referral Code :
            <asp:TextBox ID="TextBox9" runat="server" Width="155px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Sign Up" />
            <br />
        </div>
    </form>
</body>
</html>
