<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="tests.aspx.cs" Inherits="projectmockbite.tests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Currently Available Tests</h1>
    <center>
    <asp:DataList CssClass="datalistbr" ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal" BorderColor="Black" BorderWidth="3px" CellPadding="10" CellSpacing="3" GridLines="Both" RepeatColumns="5">
        <ItemTemplate>
            <table class="w-100">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" AlternateText="Image Not Uploaded" ImageUrl="~/imgs/logo.png" />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Subject :
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("subject") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>No of Questions :
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("noofques") %>'></asp:Label>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Attempt" OnClick="Button1_Click"   />
                    </td>
                </tr>
            </table>
            <br />
<br />
        </ItemTemplate>
    </asp:DataList>
        </center>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mockbiteConnectionString %>" SelectCommand="SELECT [subject], [title], [description], [noofques] FROM [testdesc]"></asp:SqlDataSource>
    <br /><br />
  <br /><br /><br /><br /><br />
</asp:Content>
