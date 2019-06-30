<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Views_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Login - Clinic Management</h3>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtUsername" placeholder="Username" CssClass="form-control" runat="server" MaxLength="12"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPassword" placeholder="Password" CssClass="form-control" runat="server" MaxLength="12"></asp:TextBox>
                        </div>
                        <asp:CheckBox ID="cbxRemember" CssClass="checkbox-inline" runat="server" Text="Remember me" />
                        <asp:Button ID="btnLogin" CssClass="btn btn-lg btn-success btn-block" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <div class="form-group" style="margin-top:12px;">
                            <p class="bg-warning">
                                <asp:Label ID="lblMessageWarning" CssClass="login-error-message" runat="server" Visible="False">Carajo</asp:Label>
                            </p>
                            <p class="bg-danger">
                                <asp:Label ID="lblMessageDanger" CssClass="login-error-message" runat="server" Visible="False">hola</asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

