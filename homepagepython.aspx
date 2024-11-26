<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepagepython.aspx.cs" Inherits="projectmockbite.homepagepython" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container card card-body">
   <center>
      
          <h1>Python</h1>
       <hr />
          </center>

        <asp:Label ID="Label1" runat="server" Text="1. 
Who developed Python Programming Language ?"></asp:Label>
      <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="True">
            <asp:ListItem Value=" Wick van Rossum"></asp:ListItem >
            <asp:ListItem Value=" Rasmus Lerdorf"></asp:ListItem>
            <asp:ListItem Value=" Guido van Rossum"></asp:ListItem><%----%>
            <asp:ListItem Value=" Niene Stom"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label13" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />


               <asp:Label ID="Label2" runat="server" Text="2.Which type of Programming does Python support?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList2" runat="server" Visible="True">
            <asp:ListItem Value="object-oriented programming"></asp:ListItem>
            <asp:ListItem Value=" structured programming"></asp:ListItem>
            <asp:ListItem Value=" functional programming"></asp:ListItem >
            <asp:ListItem Value="  all of the mentioned"></asp:ListItem><%----%>
        </asp:RadioButtonList>
        <asp:Label ID="Label11" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />


               <asp:Label ID="Label3" runat="server" Text="3. Is Python case sensitive when dealing with identifiers?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList3" runat="server" Visible="True">
            <asp:ListItem Value=" no"></asp:ListItem><%----%>
            <asp:ListItem Value=" yes"></asp:ListItem >
            <asp:ListItem Value=" machine dependent"></asp:ListItem>
            <asp:ListItem Value=" none of the mentioned"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label14" runat="server" Text="" Visible="False"></asp:Label><br />

               <asp:Label ID="Label4" runat="server" Text="4. Which of the following is the correct extension of the Python file?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList4" runat="server" Visible="True">
            <asp:ListItem Value=" .python"></asp:ListItem>
            <asp:ListItem Value="  .pl"></asp:ListItem>
            <asp:ListItem Value="  .py"></asp:ListItem ><%----%>
            <asp:ListItem Value=" .p"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label15" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label5" runat="server" Text="5.  Is Python code compiled or interpreted?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList5" runat="server" Visible="True">
            <asp:ListItem Value=" Python code is both compiled and interpreted
"></asp:ListItem >
            <asp:ListItem Value=" Python code is neither compiled nor interpreted"></asp:ListItem><%----%>
            <asp:ListItem Value=" Python code is only compiled"></asp:ListItem>
            <asp:ListItem Value=" Python code is only interpreted"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label16" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label6" runat="server" Text="6.All keywords in Python are in _________"></asp:Label><br />
              <asp:RadioButtonList ID="RadioButtonList6" runat="server" Visible="True">
            <asp:ListItem Value=" Capitalized"></asp:ListItem>
            <asp:ListItem Value=" lower case"></asp:ListItem>
            <asp:ListItem Value="  UPPER CASE"></asp:ListItem>
            <asp:ListItem Value=" None of the mentioned
"></asp:ListItem ><%----%>
        </asp:RadioButtonList><asp:Label ID="Label17" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label7" runat="server" Text="7. What does pip stand for python?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList7" runat="server" Visible="True">
            <asp:ListItem Value=" unlimited length"></asp:ListItem>
            <asp:ListItem Value=" all private members must have leading and trailing underscores
"></asp:ListItem><%----%>
            <asp:ListItem Value=" Preferred Installer Program"></asp:ListItem >
            <asp:ListItem Value=" none of the mentioned
"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label18" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label8" runat="server" Text="8.Which of the following is used to define a block of code in Python language??"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList8" runat="server" Visible="True">
            <asp:ListItem Value=" Indentation"></asp:ListItem ><%----%>
            <asp:ListItem Value=" Key"></asp:ListItem>
            <asp:ListItem Value=" Brackets"></asp:ListItem>
            <asp:ListItem Value=" All of the mentioned"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label19" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label9" runat="server" Text="9.Which keyword is used for function in Python language?
"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList9" runat="server" Visible="True">
            <asp:ListItem Value=" Function"></asp:ListItem>
            <asp:ListItem Value=" Def"></asp:ListItem><%----%>
            <asp:ListItem Value=" Fun"></asp:ListItem> 
            <asp:ListItem Value=" Define"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label20" runat="server" Text="" Visible="False"></asp:Label><br />



               <asp:Label ID="Label10" runat="server" Text="10. Python supports the creation of anonymous functions at runtime, using a construct called __________"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList10" runat="server" Visible="True">
            <asp:ListItem Value=" pi"></asp:ListItem>
            <asp:ListItem Value=" anonymous
"></asp:ListItem>
            <asp:ListItem Value=" lambda
"></asp:ListItem ><%----%>
            <asp:ListItem Value="none of the mentioned
"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label21" runat="server" Text="" Visible="False"></asp:Label>

        <br /><hr /><br />
        <center>

<asp:Button ID="Button2" class="btn btn-primary " Width="200px" runat="server" Text="Submit Test" OnClick="Button1_Click"></asp:Button></br>
<asp:Label ID="Label12" runat="server" Text="" Visible="False"></asp:Label>
        </center>
    </div>

</asp:Content>
