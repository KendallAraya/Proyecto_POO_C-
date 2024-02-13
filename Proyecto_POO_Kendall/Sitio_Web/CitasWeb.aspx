<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="CitasWeb.aspx.cs" Inherits="Sitio_Web.CitasWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMainHolder1" runat="server">
    <h1 class="p-3 mb-3 bg-secondary text-white text-center">Seleccione un paciente</h1>
    <div class="container ">
         <div class="row">
            <div class="col-sm-6" >
                <div class="row mb-3">
                    <div id="ID" class="col-4">
                        ID:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtID" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Cedula:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtCedula" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Nombre Completo:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtNombre" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Numero de telefono:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtTelefono" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="row mb-3">
                    <div class="col-4">
                        Correo Electronico:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtCorreo" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Nacionalidad:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtNacionalidad" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Direccion:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtDireccion" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 text-right">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar Paciente" class="btn btn-primary m-2 btn-buscar" OnClick="btnBuscar_Click" />
                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" class="btn btn-primary m-2" OnClick="btnLimpiar_Click"/>
                    </div>
                </div>
            </div>
        </div>

        <h1 class="p-3 mb-3 bg-secondary text-white text-center">Seleccione una Especialidad</h1>
        <div class="row mb-3">
            <div class="col-12 text-center">
                <div class="text-center">
                    <asp:Label ID="lblSeleccione" runat="server" Text="Seleccionar Aqui:" class="d-block mb-2"></asp:Label>
                    <div class="mx-auto" style="max-width: 300px;">
                        <asp:DropDownList ID="cboEspecialidad" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="cboEspecialidad_SelectedIndexChanged">
                            <asp:ListItem>Pediatría</asp:ListItem>
                            <asp:ListItem>Ginecología </asp:ListItem>
                            <asp:ListItem>Cardiología</asp:ListItem>
                            <asp:ListItem>Dermatología</asp:ListItem>
                            <asp:ListItem>Oftalmología</asp:ListItem>
                            <asp:ListItem>Odontología</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>

        <asp:Panel ID="pnlLista" runat="server" Visible="False">
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="#333333" GridLines="None" Width="100%" PageSize="8">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="IDAgendaEspecialista" HeaderText="ID. Agenda Especialista"></asp:BoundField>
                    <asp:BoundField DataField="NombreCompletoE" HeaderText="Nombre Especialista"></asp:BoundField>
                    <asp:BoundField DataField="HoraInicio" HeaderText="Hora de Entrada" />
                    <asp:BoundField DataField="HoraFinal" HeaderText="Hora de Salida" />
                     <asp:BoundField DataField="FechaCita" HeaderText="Fecha" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("IDAgendaEspecialista").ToString() %>' CommandName="Seleccionar" OnCommand="lnkSeleccionar_Command">Seleccionar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="pnlAgendaEspecialistas" runat="server" Visible="False">
            <div class="row">
                <div class="col-sm-6" >
                    <div class="row mb-3">
                        <div id="ID_AGENDA" class="col-4">
                            ID:
                        </div>
                        <div class="col-8">
                            <asp:TextBox ID="txtID_A" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mb-3">
                        <div class="col-4">
                            Nombre Especialista:s
                        </div>
                        <div class="col-8">
                            <asp:TextBox ID="txtNombreEspecialista" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mb-3">
                        <div class="col-4">
                            Hora Inicio:
                        </div>
                        <div class="col-8">
                            <asp:TextBox ID="txtHoraInicio" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="row mb-3">
                        <div class="col-4">
                            Fecha:
                        </div>
                        <div class="col-8">
                            <asp:TextBox ID="txtFecha" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-4">
                           Hora Final:
                        </div>
                        <div class="col-8">
                            <asp:TextBox ID="txtHoraFinal" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12 text-right">
                            <asp:Button ID="btnLimpiarAgenda" runat="server" Text="Seleccionar otra Agenda" class="btn btn-primary m-2" OnClick="btnLimpiarAgenda_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>

        <asp:Panel ID="pnlCita" runat="server" Visible="False">
            <h1 class="p-3 mb-3 bg-secondary text-white text-center">Realice su solicitud aquí</h1>
            <div class="row justify-content-center">
                <div class="col-sm-6">
                    <div class="row mb-3">
                        <div class="col-12 text-center">
                            <label for="txtHoraInicoCita" class="form-label">Hora Inicio de la cita:</label>
                        </div>
                        <div class="col-12">
                            <div class="input-group">
                                <asp:TextBox ID="txtHoraInicoCita" runat="server" CssClass="form-control" Width="50%" Type="time" Step="1800"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe poner una hora de inicio" ControlToValidate="txtHoraInicoCita" ValidationGroup="ValidarFormulario" CssClass="text-danger">*</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-12 text-center">
                            <asp:Button ID="btnSolicitud" runat="server" Text="Realizar Solicitud" CssClass="btn btn-primary m-2" OnClick="btnSolicitud_Click" ValidationGroup="ValidarFormulario" />
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ValidarFormulario" class="text-danger text-center" />
   </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentFooterHolder2" runat="server">
</asp:Content>
