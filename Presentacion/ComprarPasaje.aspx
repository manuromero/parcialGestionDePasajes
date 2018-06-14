<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComprarPasaje.aspx.cs" Inherits="Presentacion.ComprarPasaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row col-md-6">

            <asp:HiddenField ID="HFIdPasajero" runat="server"/>
            
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblNombre" Text="Nombre Pasajero" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblNom" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
                 
            <div class="col-md-6">
                <div class="form-group">   
                    <asp:Label ID="LblApellido" Text="Apellido Pasajero" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblApe" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">  
                    <asp:Label ID="LblEdad" Text="EdadPasajero" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblEd" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblFechaNacimiento" Text="Fecha de Nacimiento" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblFechaNacimie" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>

            <div class="col-md-12">
                <div class="form-group btn-group">
                    <asp:Button ID="BtnListLineas" runat="server" Text="Lineas" OnClick="BtnListLineas_Click" CssClass="btn btn-info"/>   
                    <asp:DropDownList ID="DDL" runat="server" OnSelectedIndexChanged="DDL_SelectedIndexChanged" DataTextField="Lineas Aereas" AutoPostBack="true" CssClass="dropdown dropdown-header"></asp:DropDownList>
                </div>

            </div>

            <asp:HiddenField ID="HFIdLienea" runat="server" />

            <div class="col-md-5">
                <div class="form-group">
                    <asp:Label ID="LblNombreLinea" Text="Nombre de la linea" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:Label ID="LblNombreLin" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>


            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblOrigen" Text="origen" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TbxOrigen" placeholder="origen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" Text="origen" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TextBox1" placeholder="origen" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblDestino" Text="Destino" runat="server" CssClass="label control-label alert-info center-block"></asp:Label>
                    <asp:TextBox ID="TbxDestino" placeholder="Destino" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="LblFechaViaje" runat="server" Text="Fecha de Viaje" CssClass="label control-label alert-info center-block"></asp:Label>
                    <div class="row">
                        <div class="container">
                            <div class="row">
                                <div class='col-md-3'>
                                    <div class="form-group">
                                        <div class='input-group date' id='myDate'>
                                            <asp:TextBox ID="tbxFechaViaje" placeholder="Fecha de Viaje" CssClass="form-control" runat="server"></asp:TextBox>
                                            <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                                <script type="text/javascript">
                                    $(function () {
                                    $('#myDate').datetimepicker({ format: 'DD-MM-YYYY' }).on('dp.change', function (e) {
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

            <div class="col-md-6">
                <div class="form-group">
                    <asp:Button ID="BtnComprar" runat="server" Text="Completar Compra" OnClick="BtnComprar_Click" CssClass="btn btn-success"/>
                    <asp:Button ID="BtnListarCompras" runat="server" Text="Ver Ventas" OnClick="BtnListarCompras_Click" CssClass="btn btn-info"/>
                </div>
            </div>

            <div class="form-group">
                <asp:GridView ID="GdvVentas" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
                    <Columns>
                        
                        <asp:BoundField HeaderText="nombre" DataField="nombre"/>
                        <asp:BoundField HeaderText="apellido" DataField="apellido"/>
                        <asp:BoundField HeaderText="origen" DataField="origen"/>
                        <asp:BoundField HeaderText="destino" DataField="destino"/>
                        <asp:BoundField HeaderText="fechadeViaje" DataField="fechaViaje"/>
                        <asp:BoundField HeaderText="linea" DataField="nombre"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>



</asp:Content>
