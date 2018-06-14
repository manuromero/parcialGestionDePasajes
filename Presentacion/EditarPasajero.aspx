<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPasajero.aspx.cs" Inherits="Presentacion.EditarPasajero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row col-md-6">

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblID" runat="server" Text="ID Pasajero" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblIdPasajero" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre Pasajero" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TbxNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblApellido" runat="server" Text="Apellido Pasajero" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TbxApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>  
            
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblEdad" runat="server" Text="Edad" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TbxEdad" placeholder="edad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>


            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblFechaNacimiento" runat="server" Text="Fecha de Nacimiento" CssClass="label control-label alert-info center-block"></asp:Label>
                    <div class="row">
                        <div class="container">
                            <div class="row">
                                <div class='col-md-3'>
                                    <div class="form-group">
                                        <div class='input-group date' id='Fecha'>
                                            <asp:TextBox ID="tbxFechaNacimiento" placeholder="Fecha de Nacimiento" CssClass="form-control" runat="server"></asp:TextBox>
                                            <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                             <script type="text/javascript">
                                $(function () {
                                //$('#myDate').datetimepicker();
                                $('#Fecha').datetimepicker().on('dp.change', function (e) {
                                if (!e.oldDate || !e.date.isSame(e.oldDate, 'day')) {
                                $(this).data('DateTimePicker').hide();
                                        }   
                                    });
                                });
                             </script>
                          </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-7">
                <div class="form-group">
                    <asp:Button ID="BtnModificar" runat="server" OnClick="BtnModificar_Click" Text="Modificar" CssClass="btn btn-success col-md-4"/>
                    <asp:Button ID="BtnVolver" runat="server" OnClick="BtnVolver_Click" Text="Inicio" CssClass="btn btn-primary col-md-4"/>
                </div>
            </div>            
        </div>
    </div>


</asp:Content>
