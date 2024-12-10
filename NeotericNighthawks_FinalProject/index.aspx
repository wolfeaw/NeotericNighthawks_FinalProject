<!--
# Name: Neoteric Nighthawks
# email:
# Assignment Title: Assignment Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project is our final project which solves leetcode problems
# Citations: https://chatgpt.com/
# Anything else that's relevant: n/a
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NeotericNighthawks_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Neoteric Nighthawks - Combined Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Problem Solver</h1>

            <asp:Table id="TableProblems" runat="server" CellPadding="10" GridLines="Both" HorizontalAlign="left">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSelectProblem" runat="server" Text="Select a Problem:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlProblems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProblems_SelectedIndexChanged"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow ID="rowIntegerInput" runat="server" Visible="false">
                    <asp:TableCell>
                        <asp:Label ID="lblInt" runat="server" Text="Please Enter Your Number"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtInt" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow ID="rowWordOutput" runat="server" Visible="true">
                    <asp:TableCell>
                        <asp:Label ID="lblWrd" runat="server" Text="Integer in word form:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="Wrd" runat="server" Text=" "></asp:Label> 
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDescription" runat="server" Text="Problem Description:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Literal ID="litDescription" runat="server"></asp:Literal>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblTestCase" runat="server" Text="Example Test Case:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Literal ID="litTestCase" runat="server"></asp:Literal>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSolution" runat="server" Text="Solution:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Literal ID="litSolution" runat="server"></asp:Literal>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" CssClass="btn btn-primary" />
        </div>
    </form>
</body>
</html>
