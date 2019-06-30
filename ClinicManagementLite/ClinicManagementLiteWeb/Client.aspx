<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Client.aspx.cs" Inherits="Views_Client" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="container-fluid flex-header">
                <h4><a href="#">Clients</a></h4>
                <h4><a href="#">Employees</a></h4>
                <h4><a href="#">Areas</a></h4>
                <h4><a href="#">Permission</a></h4>
                <h4><a href="#">Position</a></h4>
                <!--Rplc Button--><h4><a href="#"> <i class="fa fa-sign-out fa-fw"></i> Logout</a></h4>
            </div>
        </nav>
        <div id="page-wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <!--Rplc label--><h1>Employee by area and position</h1>
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
                                    <asp:BoundField DataField="name" HeaderText="Nombre" />
                                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                    <asp:BoundField DataField="phone" HeaderText="Phone" />
                                    <asp:BoundField DataField="address" HeaderText="Address" />
                                    <asp:BoundField DataField="email" HeaderText="Email" />
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
                    <button class="btn btn-lg btn-warning" style="margin: 0px 6px 0px 6px">Editar</button>
                    <button class="btn btn-lg btn-danger" style="margin: 0px 0px 0px 6px">Eliminar</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

