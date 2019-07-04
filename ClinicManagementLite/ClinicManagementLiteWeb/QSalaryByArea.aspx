<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QSalaryByArea.aspx.cs" Inherits="QSalaryByArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
            <!--Rplc label--><h1>Calculo de salarios entre areas</h1>
            </div>
        <!-- /.col-lg-12 -->
        </div>
        <div class="row" style="margin-top: 16px;">
            <div class="col-sm-1 col-md-1 col-lg-4"></div>
            <div class="col-sm-10 col-md-10 col-lg'6">
                <p class="bg-danger" style="border-radius: 12px;">
                    <asp:Label ID="lblMessageDanger" CssClass="login-error-message" runat="server" Visible="false">Danger</asp:Label>
                </p>
                <p class="bg-warning" style="border-radius: 12px;">
                    <asp:Label ID="lblMessageWarning" CssClass="login-error-message" runat="server" Visible="False">Warning</asp:Label>
                </p>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2 col-md-2 col-lg-2"></div>
            <div class="col-sm-8 col-md-8 col-lg-8">
                <div class="panel panel-default">
                    <div class="panel-heading">
                    Salarios
                    </div>
                    <div class="panel-body" style="margin-bottom: 20px;">
                        <asp:Literal ID="litSalaries" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
    </div>
    <script>
        $(function (){
            $('[data-toggle="tooltip"]').tooltip()
        })
    </script>
            </contentTemplate>
    </asp:UpdatePanel>
</asp:Content>

