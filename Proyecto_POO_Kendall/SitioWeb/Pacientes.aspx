<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="SitioWeb.Pacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMainHolder1" runat="server">
    <div>
            <h1>Listado de Pacientes</h1>
            <hr/>  
            Nombre del Paciente: 
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary m-2" />
            <asp:Button ID="btnGuardar" runat="server" Text="Nuevo cliente" class="btn btn-primary m-2" />
            <hr />  
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="#333333" GridLines="None" Width="100%" PageSize="8">
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
                            <asp:LinkButton ID="lnkMoficar" runat="server" CommandArgument='<%# Eval("IdPaciente").ToString() %>' CommandName="Modificar">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("IdPaciente").ToString() %>' CommandName="Eliminar">Eliminar</asp:LinkButton>
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
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentFooterHolder2" runat="server">
</asp:Content>
