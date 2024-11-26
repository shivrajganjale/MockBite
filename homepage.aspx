<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="projectmockbite.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 p-3 mx-auto">
                <h1>Welcome to MockBite</h1>
                <p>
                    MockBite is a fully responsive website which aims at providing an Exam portal for students to give Mock tests in various fields. Majority of students face the problemof not having a spot check or a testing ground for their studies . 
        Here , at MockBite students can sign up and take a Mock test , 
        which would be the exact replica of real exam in real time they chose for.
                </p>
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Explore Tests" OnClick="Button1_Click" />
            </div>
            <div class="col-md-6 mx-auto">
                <img class="img-fluid" src="imgs/homepageimg.png" />
            </div>
        </div>
    </div>



    <br />
    <br />
    <br />
    <br />
    <div class="text-center card card-body">
        <h1>Recommended Mocks</h1>
        <br />
        <div class="container ">
            <div class="row">
                <div class="col-4">

                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="imgs/c-logo-icon-28389.png" alt="C++" />
                        <div class="card-body">
                            <h5 class="card-title">C++</h5>
                            <p class="card-text">Quick Test of 10 C++ Questions </p>
                            <a href="homepagecpp.aspx" class="btn btn-primary">Attempt</a>
                        </div>
                    </div>

                </div>
                <div class="col-4">

                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="imgs/kisspng-java-runtime-environment-computer-icons-java-platf-java-5ade3063f31610.0948145615245108199957.png" alt="Java" />
                        <div class="card-body">
                            <h5 class="card-title">Java</h5>
                            <p class="card-text">Quick Test of 10 Java Questions</p>
                            <a href="homepagejava.aspx" class="btn btn-primary">Attempt</a>
                        </div>
                    </div>

                </div>
                <div class="col-4">

                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="imgs/kisspng-angle-text-symbol-brand-other-python-5ab0c09b9ea1a7.3286927515215330836498.png" alt="Python" />
                        <div class="card-body">

                            <h5 class="card-title">Python</h5>
                            <p class="card-text">Quick Test of 10 Python Questions</p>
                            <a href="homepagepython.aspx" class="btn btn-primary">Attempt </a>
                        </div>
                    </div>
                </div>



            </div>
        </div>

    </div>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
