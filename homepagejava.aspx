<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepagejava.aspx.cs" Inherits="projectmockbite.homepagejava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container card card-body">
   <center>
      
          <h1>Java</h1>
       <hr />
          </center>

        <asp:Label ID="Label1" runat="server" Text="1. 
 Number of primitive data types in Java are?"></asp:Label>
      <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="True">
            <asp:ListItem Value=" 6"></asp:ListItem>
            <asp:ListItem Value=" 7"></asp:ListItem>
            <asp:ListItem Value=" 8"></asp:ListItem><%----%>
            <asp:ListItem Value=" 9"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label13" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />

               <asp:Label ID="Label2" runat="server" Text="2. Which statement is true about Java?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList2" runat="server" Visible="True">
            <asp:ListItem Value=" Java is a sequence-dependent programming language"></asp:ListItem>
            <asp:ListItem Value=" Java is a code dependent programming language"></asp:ListItem>
            <asp:ListItem Value=" Java is a platform-dependent programming language"></asp:ListItem><%----%>
            <asp:ListItem Value=" Java is scripting language"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label11" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />


               <asp:Label ID="Label3" runat="server" Text="3. Which component is used to compile, debug and execute the java programs?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList3" runat="server" Visible="True">
            <asp:ListItem Value=" JRE"></asp:ListItem>
            <asp:ListItem Value=" JIT"></asp:ListItem>
            <asp:ListItem Value=" JDK"></asp:ListItem><%----%>
            <asp:ListItem Value=" JVM"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label14" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label4" runat="server" Text="4. Which one of the following is not a Java feature?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList4" runat="server" Visible="True">
            <asp:ListItem Value=" Object-oriented"></asp:ListItem>
            <asp:ListItem Value=" Use of pointers"></asp:ListItem><%----%>
            <asp:ListItem Value=" Portable"></asp:ListItem>
            <asp:ListItem Value=" Dynamic and Extensible"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label15" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label5" runat="server" Text="5. Which of these cannot be used for a variable name in Java?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList5" runat="server" Visible="True">
            <asp:ListItem Value=" identifier & keyword"></asp:ListItem>
            <asp:ListItem Value=" identifier"></asp:ListItem>
            <asp:ListItem Value=" keyword"></asp:ListItem><%----%>
            <asp:ListItem Value=" none"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label16" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label6" runat="server" Text="6. What is the extension of java code files?"></asp:Label><br />
              <asp:RadioButtonList ID="RadioButtonList6" runat="server" Visible="True">
            <asp:ListItem Value=" .js"></asp:ListItem>
            <asp:ListItem Value=" .txt"></asp:ListItem>
            <asp:ListItem Value=" .class"></asp:ListItem>
            <asp:ListItem Value=" .java"></asp:ListItem><%----%>
        </asp:RadioButtonList><asp:Label ID="Label17" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label7" runat="server" Text="7. Which environment variable is used to set the java path?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList7" runat="server" Visible="True">
            <asp:ListItem Value=" JavaPATH"></asp:ListItem>
            <asp:ListItem Value=" MAVEN_Path"></asp:ListItem>
            <asp:ListItem Value=" JAVA"></asp:ListItem>
            <asp:ListItem Value=" JAVA_HOME"></asp:ListItem><%----%>
        </asp:RadioButtonList><asp:Label ID="Label18" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label8" runat="server" Text="8.What is not the use of “this” keyword in Java?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList8" runat="server" Visible="True">
            <asp:ListItem Value=" Referring to the instance variable when a local variable has the same name"></asp:ListItem>
            <asp:ListItem Value=" Passing itself to the method of the same class"></asp:ListItem><%----%>
            <asp:ListItem Value=" Passing itself to another method"></asp:ListItem>
            <asp:ListItem Value=" Calling another constructor in constructor chaining"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label19" runat="server" Text="" Visible="False"></asp:Label><br />


               <asp:Label ID="Label9" runat="server" Text="9.Which of the following is a type of polymorphism in Java Programming?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList9" runat="server" Visible="True">
            <asp:ListItem Value=" Multiple polymorphism"></asp:ListItem>
            <asp:ListItem Value=" Compile time polymorphism"></asp:ListItem><%----%>
            <asp:ListItem Value=" Multilevel polymorphism"></asp:ListItem>
            <asp:ListItem Value=" Execution time polymorphism"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label20" runat="server" Text="" Visible="False"></asp:Label><br />



               <asp:Label ID="Label10" runat="server" Text="10.What is Truncation in Java?"></asp:Label>
              <asp:RadioButtonList ID="RadioButtonList10" runat="server" Visible="True">
            <asp:ListItem Value=" Floating-point value assigned to a Floating type"></asp:ListItem>
            <asp:ListItem Value=" Floating-point value assigned to an integer type"></asp:ListItem><%----%>
            <asp:ListItem Value=" Integer value assigned to floating type"></asp:ListItem>
            <asp:ListItem Value=" Integer value assigned to char type"></asp:ListItem>
        </asp:RadioButtonList><asp:Label ID="Label21" runat="server" Text="" Visible="False"></asp:Label>

        <br /><hr /><br />
        <center>

<asp:Button ID="Button1" class="btn btn-primary " Width="200px" runat="server" Text="Submit Test" OnClick="Button1_Click"></asp:Button></br>
</asp:Label><asp:Label ID="Label12" runat="server" Text="" Visible="False"></asp:Label>
        </center>
    </div>

        

</asp:Content>
