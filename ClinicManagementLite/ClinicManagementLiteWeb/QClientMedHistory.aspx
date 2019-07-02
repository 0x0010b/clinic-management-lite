<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QClientMedHistory.aspx.cs" Inherits="QPersonMedHistory" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
            <!--Rplc label--><h1>Clients</h1>
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
                        <asp:GridView ID="gdvCLients" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server" OnSelectedIndexChanged="gdvCLients_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
                            </Columns>

                        </asp:GridView>
                    </div>
                </div>
            </div>
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
        </div>
        <div class"row">
            <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8 ">
                    <asp:LinkButton ID="btnPopup" style="visibility:hidden;" runat="server">.</asp:LinkButton>


                    <cc1:ModalPopupExtender ID="popupClient" BackgroundCssClass="popup-background" runat="server" 
                        TargetControlID="btnPopup" PopupControlID="modalClient">
                    </cc1:ModalPopupExtender>

                    <asp:Panel ID="modalClient" CssClass="bd-example-modal-lg" runat="server">
                        <div class="modal-dialog modal-lg">
                            <div class="modal-content">
                                <div class="modal-body">
                                    <div class="container-fluid">
                                        <div class="row">
                                            <div class="col-md-2 col-sm-4 col-xs-4">
                                                <asp:Image ID="imgClient" runat="server" ImageUrl="persons/21228271.jpg" style="margin-bottom: 10px;"/>
                                            </div>
                                            <div class="col-md-4 col-sm-4 col-xs-4">
                                                <h4><asp:Label ID="lblName" runat="server" Text="Nombre:"></asp:Label></h4>
                                                <h4><asp:Label ID="lblAge" runat="server" Text="Edad:"></asp:Label></h4>
                                                <h4><asp:Label ID="lblDni" runat="server" Text="Dni:"></asp:Label></h4>
                                            </div>
                                            <div class="col-md-6 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Tipo de
                                                        sangre:</label>
                                                    <asp:TextBox ID="txtBloodType" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Estatura:</label>
                                                    <asp:TextBox ID="txtHeight" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 col-sm-6 col-xs-6">
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Alergias:</label>
                                                    <asp:TextBox ID="txtAllergies" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Enfermedades
                                                        anteriores:</label>
                                                    <asp:TextBox ID="txtPathologies" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Enfermedades
                                                        TS:</label>
                                                    <asp:TextBox ID="txtAids" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Cancer:</label>
                                                    <asp:TextBox ID="txtCancer" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <asp:Button ID="btnClose" CssClass="btn btn-info" runat="server" Text="Salir" />
                                            </div>
                                            <div class="col-md-6 col-sm-6 col-xs-6">
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Medicinas:</label>
                                                    <asp:TextBox ID="txtMedicines" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text"
                                                        class="col-form-label">Convulsiones:</label>
                                                    <asp:TextBox ID="txtSeizures" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Presion
                                                        arterial:</label>
                                                    <asp:TextBox ID="txtBloodPressure" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="message-text" class="col-form-label">Colesterol:</label>
                                                    <asp:TextBox ID="txtCholesterol" CssClass="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
        </div>
    </div>    
    <script type="text/javascript">
        $('#ContentPlaceHolder1_gdvCLients').DataTable({
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

