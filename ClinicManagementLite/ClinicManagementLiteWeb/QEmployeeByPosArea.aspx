<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QEmployeeByPosArea.aspx.cs" Inherits="Views_QEmployeeByPosArea" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
            <!--Rplc label--><h1>Empleados por area y cargo</h1>
            </div>
        <!-- /.col-lg-12 -->
        </div>
        <div class="row" style="margin-top: 16px;">
            <div class="col-sm-1 col-md-1 col-lg-0"></div>
            <div class="col-sm-10 col-md-10 col-lg-12 buttons-container">
                <div class="form-group" style="margin: 6px 6px 0px 6px">
                    <asp:DropDownList ID="dropArea" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropArea_SelectedIndexChanged">
                        <asp:ListItem Value="-1">--</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group" style="margin: 6px 6px 0px 6px">
                    <asp:DropDownList ID="dropPosition" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropPosition_SelectedIndexChanged1">
                        <asp:ListItem Value="-1">--</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row" style="margin-top: 16px;">
            <div class="col-sm-1 col-md-1 col-lg-1"></div>
            <div class="col-sm-10 col-md-10 col-lg-10">
                <p class="bg-danger" style="border-radius: 12px;">
                    <asp:Label ID="lblMessageDanger" CssClass="login-error-message" runat="server" Visible="false">Danger</asp:Label>
                </p>
                <p class="bg-warning" style="border-radius: 12px;">
                    <asp:Label ID="lblMessageWarning" CssClass="login-error-message" runat="server" Visible="False">Warning</asp:Label>
                </p>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-1 col-md-1 col-lg-0"></div>
            <div class="col-sm-10 col-md-10 col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                    Empleados
                    </div>
                    <div class="panel-body table-responsive" style="margin-right:20px;">
                        <asp:GridView ID="gdvClients" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server">
                        
                        </asp:GridView>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
    </div>
    <script type="text/javascript">
        $('#ContentPlaceHolder1_gdvClients').DataTable({
                paging: false,
                ordering: false,
                searching: false,
                scrollY: '40vh',
                scrollCollapse: true,
                responsive: true
            });       
    </script>
            </contentTemplate>
    </asp:UpdatePanel>
</asp:Content>

