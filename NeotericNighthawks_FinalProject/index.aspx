<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NeotericNighthawks_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Richie's Code-->

<h1>
    Interger to Word Converter
</h1>
             <asp:Table id="Table1" runat="server"
    CellPadding="10" 
    GridLines="Both"
    HorizontalAlign="left">
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="lblInt" runat="server" Text="Please Enter Your Number"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtInt" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="lblWrd" runat="server" Text="Interger in word form:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Label ID="Wrd" runat="server" Text=" "></asp:Label>
        </asp:TableCell>
    </asp:TableRow>
</asp:Table> 
<asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" CssClass="btn btn-primary" />
            <!--End of Richie's Code-->
        </div>
    </form>
</body>
</html>