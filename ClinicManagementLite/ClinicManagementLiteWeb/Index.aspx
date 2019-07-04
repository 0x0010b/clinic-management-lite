<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Views_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h2><asp:Label ID="lblMessageUser" runat="server" Text="Label"></asp:Label></h2>
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
                        Consultas
                    </div>
                    <div class="panel-body">
                        <div class="btn-group" role="group" aria-label="...">
                            <asp:Button ID="btnEmployeByAreaPos" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar empleado por area y cargo" OnClick="btnEmployeByAreaPos_Click" />
                            <asp:Button ID="btnTotalPerson" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar total de personas registradas" OnClick="btnTotalPerson_Click" />
                            <asp:Button ID="btnAccountByType" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar cuentas por tipo de permiso" OnClick="btnAccountByType_Click" />
                            <asp:Button ID="btnPosByArea" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar cargos por area" OnClick="btnPosByArea_Click" />
                            <asp:Button ID="btnClientHistory" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar historial medico por cliente" OnClick="btnClientHistory_Click" />
                            <asp:Button ID="btnSalaryArea" CssClass="btn btn-default" style="margin: 6px 4px 6px 4px" runat="server" Text="Consultar salarios por area" OnClick="btnSalaryArea_Click"/>                            
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
    </div>
</asp:Content>

