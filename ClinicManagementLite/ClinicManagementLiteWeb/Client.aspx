<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Client.aspx.cs" Inherits="Views_Client" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
            <!--Rplc label--><h1>Clients</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <div class="row">
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
            <div class="col-sm-10 col-md-10 col-lg-8">
                <div class="panel panel-default">
                    <div class="panel-heading">
                    Client's table
                    </div>
                    <div class="panel-body">
                        <asp:GridView ID="gdvClients" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:ButtonField ButtonType="Button" Text="Editar" />
                            </Columns>
                        </asp:GridView>    
                        <button class="btn btn-lg btn-success">Descargar</button>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
        <div class="row">
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
            <div class="col-sm-10 col-md-10 col-lg-8 buttons-container">
                <button class="btn btn-lg btn-success" style="margin: 0px 6px 0px 6px">Insertar</button>
            </div>
        </div>
    </div>
</asp:Content>

