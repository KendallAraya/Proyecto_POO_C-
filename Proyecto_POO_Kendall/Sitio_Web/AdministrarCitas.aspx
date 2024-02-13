<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="AdministrarCitas.aspx.cs" Inherits="Sitio_Web.AdministrarCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMainHolder1" runat="server">
    <h1 class="p-3 mb-3 bg-secondary text-white text-center">Busca un paciente</h1>
    <div class="container ">

        <asp:Panel ID="pnlPacientes" runat="server">
            <hr/>  
            Nombre del Paciente: 
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar Paciente" class="btn btn-primary m-2 btn-buscar" OnClick="btnBuscar_Click"/>
            <hr />  
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="#333333" GridLines="None" Width="100%" PageSize="8" OnPageIndexChanging="grdLista_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="IdPaciente" HeaderText="ID. Paciente"></asp:BoundField>
                    <asp:BoundField DataField="CedulaP" HeaderText="Cedula"></asp:BoundField>
                    <asp:BoundField DataField="NombreCompletoP" HeaderText="Nombre" />
                    <asp:BoundField DataField="TelefonoP" HeaderText="Telefono" />
                     <asp:BoundField DataField="CorreoElecP" HeaderText="Correo Electronico" />
                    <asp:BoundField DataField="NacionalidadP" HeaderText="Nacionalidad" />
                    <asp:BoundField DataField="DireccionP" HeaderText="Direccion" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("IdPaciente").ToString() %>' CommandName="Seleccionar" OnCommand="lnkSeleccionar_Command" >Seleccionar</asp:LinkButton>
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

        <asp:Panel ID="pnlDatosPaciente" runat="server" Visible="False">
            <div class="row">
            <div class="col-sm-6" >
                <div class="row mb-3">
                    <div id="ID" class="col-4">
                        ID:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtID2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Cedula:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtCedula2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Nombre Completo:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtNombre2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Numero de telefono:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtTelefono2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="row mb-3">
                    <div class="col-4">
                        Correo Electronico:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtCorreo2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Nacionalidad:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtNacionalidad2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-4">
                        Direccion:
                    </div>
                    <div class="col-8">
                        <asp:TextBox ID="txtDireccion2" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 text-right">
                        <asp:Button ID="btnLimpiar" runat="server" Text="Seleccionar otro paciente" class="btn btn-primary m-2" OnClick="btnLimpiar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        </asp:Panel>   
        
        <asp:Panel ID="pnlCitas" runat="server" Visible="false">
            <h1 class="p-3 mb-3 bg-secondary text-white text-center">Cancele su cita Aqui</h1>
            <asp:GridView ID="grdCitas" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="#333333" GridLines="None" Width="100%" PageSize="8">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="IDcitaWeb" HeaderText="ID. Cita Web"></asp:BoundField>
                    <asp:BoundField DataField="IDAgendaEspecialista" HeaderText="ID. Agenda"></asp:BoundField>
                    <asp:BoundField DataField="NombreCompletoP" HeaderText="Nombre del Paciente" />
                    <asp:BoundField DataField="HoraInico" HeaderText="Hora de Inicio" />
                     <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkCancelar" runat="server" CommandArgument='<%# Eval("IDcitaWeb").ToString() %>' CommandName="Cancelar" OnCommand="lnkCancelar_Command" >Cancelar</asp:LinkButton>
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
       
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentFooterHolder2" runat="server">
</asp:Content>
