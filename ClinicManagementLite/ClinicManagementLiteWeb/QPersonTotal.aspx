<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QPersonTotal.aspx.cs" Inherits="QPersonTotal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="container-fluid flex-header">
                <h4><a href="Client.aspx">Clients</a></h4>
                <h4><a href="#">Employees</a></h4>
                <h4><a href="#">Areas</a></h4>
                <h4><a href="#">Permission</a></h4>
                <h4><a href="#">Position</a></h4>
                <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click"><h4><i class="fa fa-sign-out fa-fw"></i> Logout</h4></asp:LinkButton>
            </div>
        </nav>
        <div id="page-wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <!--Rplc label--><h1>Total person</h1>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <div class="row" style="margin-top: 16px;">
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8">
                    <p class="bg-danger" style="border-radius: 12px;">
                        <asp:Label ID="lblMessageDanger" CssClass="login-error-message" runat="server" Visible="false">Danger</asp:Label>
                    </p>
                    <p class="bg-warning" style="border-radius: 12px;">
                        <asp:Label ID="lblMessageWarning" CssClass="login-error-message" runat="server" Visible="False">Warning</asp:Label>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                        Query
                        </div>

                        <div class="panel-body">
                            <asp:GridView ID="gdvPersons" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $('#ContentPlaceHolder1_gdvPersons').DataTable({
                paging: false,
                ordering: false,
                searching: false,
                scrollY: '40vh',
                scrollCollapse: true,
                responsive: true
            });       
    </script>
</asp:Content>

