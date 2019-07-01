<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QAccountByPermission.aspx.cs" Inherits="QAccountByPermission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
            <!--Rplc label--><h1>Account by permission</h1>
            </div>
        <!-- /.col-lg-12 -->
        </div>
        <div class="row" style="margin-top: 16px;">
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
            <div class="col-sm-10 col-md-10 col-lg-8 buttons-container">
                <div class="form-group" style="margin: 6px 6px 0px 6px">
                    <asp:DropDownList ID="dropPermission" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropPermission_SelectedIndexChanged" >
                    </asp:DropDownList>
                </div>
            </div>
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
                        <asp:GridView ID="gdvAccounts" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server">
                        </asp:GridView>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
    </div>
</asp:Content>

