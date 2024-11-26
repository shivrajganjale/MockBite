<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminpanel.aspx.cs" Inherits="projectmockbite.adminpanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <h1>Admin panel</h1>
        <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">

                    <div class="row">

                        <div class="col-md-4 ">
                                
                            <asp:Button ID="Button1" class="btn btn-success btn-block btn-lg" runat="server" Text="Create a New Test" OnClick="Button1_Click"></asp:Button>
                       </div>
                          
                

                  
                        <div class="col-md-3 ">
                            <asp:Button ID="Button2" class="btn btn-success btn-block btn-lg" runat="server" Text="Update a Test"></asp:Button>
                       </div>
                

                  
                        <div class="col-md-3 ">
                            <asp:Button ID="Button3" class="btn btn-success btn-block btn-lg" runat="server" Text="Delete a Test"></asp:Button>
                       </div>
            

                   
                        <div class="col-md-2 ">
                            <asp:Button ID="Button4" class="btn btn-success btn-block btn-lg" runat="server" Text="Test Data"></asp:Button>
                       </div>
          


                   </div>
                </div>
             </div>
   </center>
    <br /><br /><br /> 
    <asp:Label ID="Label1" runat="server" Text="User Information :" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="userid" DataSourceID="SqlDataSource1" Width="1231px">
        <Columns>
            <asp:TemplateField HeaderText="userid" InsertVisible="False" SortExpression="userid">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("userid") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("userid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname" />
            <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
            <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
            <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
            <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
            <asp:BoundField DataField="pincode" HeaderText="pincode" SortExpression="pincode" />
            <asp:BoundField DataField="collegename" HeaderText="collegename" SortExpression="collegename" />
            <asp:BoundField DataField="emailID" HeaderText="emailID" SortExpression="emailID" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mockbiteConnectionString %>" SelectCommand="SELECT * FROM [usersignuptable]"></asp:SqlDataSource>
    <br /><br /><br />
    <asp:Label ID="Label2" runat="server" Text="Tests" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="testId" DataSourceID="SqlDataSource2" Width="1220px">
        <Columns>
            <asp:BoundField DataField="testId" HeaderText="testId" InsertVisible="False" ReadOnly="True" SortExpression="testId" />
            <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            <asp:BoundField DataField="noofques" HeaderText="noofques" SortExpression="noofques" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:mockbiteConnectionString %>" SelectCommand="SELECT * FROM [testdesc]"></asp:SqlDataSource>
    <br /><br /><br /> <br />
<br />    
   
</asp:Content>
