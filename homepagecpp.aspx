<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepagecpp.aspx.cs" Inherits="projectmockbite.homepageCpp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container card card-body">
   <center>
      
          <h1>C++</h1>
       <hr />
          </center>

        <asp:Label ID="Label1" runat="server" Text="1. 
 Who invented C++??"></asp:Label>
      <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="True">
            <asp:ListItem Value=" Dennis Ritchie"></asp:ListItem><%----%>
            <asp:ListItem Value=" Ken Thompson"></asp:ListItem>
            <asp:ListItem Value=" Brian Kernighan"></asp:ListItem>
            <asp:ListItem Value=" Bjarne Stroustrup"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label13" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />


               <asp:Label ID="Label2" runat="server" Text="2.What is C++??"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList2" runat="server" Visible="True">
            <asp:ListItem Value=" C++ is an object oriented programming language"></asp:ListItem>
            <asp:ListItem Value=" C++ is a procedural programming language"></asp:ListItem>
            <asp:ListItem Value=" C++ supports both procedural and object oriented programming language"></asp:ListItem><%----%>
            <asp:ListItem Value="  C++ is a functional programming language"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label11" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />


               <asp:Label ID="Label3" runat="server" Text="3. Which of the following is the correct syntax of including a user defined header files in C++?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList3" runat="server" Visible="True">
            <asp:ListItem Value=" #include userdefined"></asp:ListItem>
            <asp:ListItem Value=" #include “userdefined”"></asp:ListItem><%----%>
            <asp:ListItem Value=" #include <userdefined.h>"></asp:ListItem>
            <asp:ListItem Value=" #include <userdefined>"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label14" runat="server" Text="" Visible="False"></asp:Label><br />

               <asp:Label ID="Label4" runat="server" Text="4. Which of the following user-defined header file extension used in c++?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList4" runat="server" Visible="True">
            <asp:ListItem Value=" hg"></asp:ListItem>
            <asp:ListItem Value=" cpp"></asp:ListItem>
            <asp:ListItem Value="  h"></asp:ListItem><%----%>
            <asp:ListItem Value=" hf"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label15" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label5" runat="server" Text="5. Which of the following is a correct identifier in C++?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList5" runat="server" Visible="True">
            <asp:ListItem Value=" VAR_1234
"></asp:ListItem><%----%>
            <asp:ListItem Value=" $var_name"></asp:ListItem>
            <asp:ListItem Value=" 7VARNAME"></asp:ListItem>
            <asp:ListItem Value=" 7var_name"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label16" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label6" runat="server" Text="6. Which of the following is not a type of Constructor in C++?"></asp:Label><br />
              <asp:RadioButtonList ID="RadioButtonList6" runat="server" Visible="True">
            <asp:ListItem Value=" Default constructor"></asp:ListItem>
            <asp:ListItem Value=" Parameterized constructor"></asp:ListItem>
            <asp:ListItem Value=" Copy constructor"></asp:ListItem>
            <asp:ListItem Value=" Friend constructor"></asp:ListItem><%----%>
        </asp:RadioButtonList><asp:Label ID="Label17" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label7" runat="server" Text="7. Which of the following approach is used by C++?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList7" runat="server" Visible="True">
            <asp:ListItem Value=" Left-right"></asp:ListItem>
            <asp:ListItem Value=" Right-left
"></asp:ListItem>
            <asp:ListItem Value=" Bottom-up"></asp:ListItem><%----%>
            <asp:ListItem Value=" Top-down
"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label18" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label8" runat="server" Text="8.Which of the following is C++ equivalent for scanf()?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList8" runat="server" Visible="True">
            <asp:ListItem Value=" cin"></asp:ListItem><%----%>
            <asp:ListItem Value=" cout"></asp:ListItem>
            <asp:ListItem Value=" print"></asp:ListItem>
            <asp:ListItem Value=" input"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label19" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label9" runat="server" Text="9.Which of the following is an exit-controlled loop?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList9" runat="server" Visible="True">
            <asp:ListItem Value=" for"></asp:ListItem>
            <asp:ListItem Value=" while"></asp:ListItem>
            <asp:ListItem Value=" do-while"></asp:ListItem><%----%>
            <asp:ListItem Value=" all of the mentioned"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label20" runat="server" Text="" Visible="False"></asp:Label><br />



               <asp:Label ID="Label10" runat="server" Text="10.What if we define the structure in C and C++?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList10" runat="server" Visible="True">
            <asp:ListItem Value=" Error in C but not in C++"></asp:ListItem>
            <asp:ListItem Value=" Error in C++ but not in C
"></asp:ListItem>
            <asp:ListItem Value=" No error in both C and C++
"></asp:ListItem><%----%>
            <asp:ListItem Value=" Error in both C and C++
"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label21" runat="server" Text="" Visible="False"></asp:Label>

        <br /><hr /><br />
        <center>

<asp:Button ID="Button2" class="btn btn-primary " Width="200px" runat="server" Text="Submit Test" OnClick="Button1_Click"></asp:Button></br>
<asp:Label ID="Label12" runat="server" Text="" Visible="False"></asp:Label>
        </center>
    </div>



</asp:Content>
