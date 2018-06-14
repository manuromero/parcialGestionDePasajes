<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaPasajero.aspx.cs" Inherits="Presentacion.AltaPasajero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="row">

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblNombre" runat="server" Text="Nombre Pasajero" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TbxNombre" placeholder="Nombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblApellido" runat="server" Text="Apellido Pasajero" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TbxApellido" placeholder="Apellido Pasajero" runat="server" CssClass="form-control"></asp:TextBox>
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
                            <asp:Label ID="LblFechaCompra" runat="server" Text="Fecha de Nacimiento" CssClass="label control-label alert-info center-block"></asp:Label>
                            <div class="row">
                                <div class="container">
                                    <div class="row">

                                        <div class='col-md-3'>
                                            <div class="form-group">
                                                <div class='input-group date' id='myDate'>
                                                    <asp:TextBox ID="tbxFechaNacimiento" placeholder="Fecha de Nacimiento" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <span class="input-group-addon">
                                                        <span class="glyphicon glyphicon-calendar"></span>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="guardar" class="btn btn-success col-md-3" />
                            <asp:Button ID="BtnListar" runat="server" OnClick="BtnListar_Click" Text="listar" class="btn btn-info col-md-3" />
                        </div>
                    </div>


                    <div class="form-group">
                    <asp:GridView ID="GdvPasajeros" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-bordered table-condensed">
                        <Columns>
                            
                            <%--<asp:BoundField HeaderText="idAuto" DataField="idAuto" FooterText=""/>--%>
                            <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
                            <asp:BoundField HeaderText="Apellido" DataField="apellido"/>
                            <asp:BoundField HeaderText="Edad" DataField="edad"/>
                            <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="fechaNacimiento"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="BtnEditar" OnClick="BtnEditar_Click" CommandName='<%# Eval("idPasajero") %>' CommandArgument='<%# Eval("idPasajero") %>' runat="server" Text="Editar" CssClass="btn btn-warning"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="BtnComprar" OnClick="BtnComprar_Click" CommandName='<%# Eval("idPasajero") %>' CommandArgument='<%# Eval("idPasajero") %>' runat="server" Text="ComprarPasaje" CssClass="btn btn-success"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>




                </div>
            </div>
        </div>





    </div>

    <script type="text/javascript">

        $(function () {
            $('#myDate').datetimepicker({format: 'DD-MM-YYYY'}).on('dp.change', function (e) {

                if (!e.oldDate || !e.date.isSame(e.oldDate, 'day')) {
                    $(this).data('DateTimePicker').hide();
                }
            });


        });
    </script>
</asp:Content>
