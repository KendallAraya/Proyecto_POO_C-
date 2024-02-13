<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="AdministarClientes.aspx.cs" Inherits="Sitio_Web.AdministarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMainHolder1" runat="server">
        <h1 class="p-3 mb-3 bg-primary text-white text-center">Pacientes</h1>
    <div class="container">
        <div class="row">
             <div id="ID" class="col-4">
                ID:

            </div>
            <div class="col-7">
                <asp:TextBox ID="txtID" Width="100%" class="form-control" runat="server" Enabled="False"></asp:TextBox>
            </div>

            <div class="col-4 mt-3">
                Cedula:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtCedula" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El campo Cedula es requerido" ControlToValidate="txtCedula" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>
            </div>

            <div class="col-4 mt-3">
                Nombre Completo:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtNombre" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo Nombre es requerido" ControlToValidate="txtNombre" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>
            </div>

            <div class="col-4 mt-3">
                Numero de telefono:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtTelefono" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El campo Telefono es requerido" ControlToValidate="txtTelefono" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingrese un numero de telefono valido (67896543) " ControlToValidate="txtTelefono" ValidationExpression="^[5-9]\d{3}-?\d{4}$" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RegularExpressionValidator>
            </div>

            <div class="col-4 mt-3">
                Correo Electronico:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtCorreo" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El campo Correo es requerido" ControlToValidate="txtCorreo" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Ingrese un correo valido (Nombre@gmail.com)" ControlToValidate="txtCorreo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RegularExpressionValidator>
            </div>

            <div class="col-4 mt-3">
               Nacionalidad:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtNacionalidad" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="El campo Nacionalidad es requerido" ControlToValidate="txtNacionalidad" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>
            </div>

            <div class="col-4 mt-3">
                Direccion:

            </div>
            <div class="col-7 mt-3">
                <asp:TextBox ID="txtDireccion" Width="100%" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-1 mt-3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El campo Direccion es requerido" ControlToValidate="txtDireccion" ValidationGroup="ValidarFormulario" class="text-danger">*</asp:RequiredFieldValidator>
            </div>

            <div class="col-4 mt-3">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary m-2" ValidationGroup="ValidarFormulario" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary m-2" OnClick="btnCancelar_Click"/>
                
            </div>

        </div>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ValidarFormulario" class="text-danger"/>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentFooterHolder2" runat="server">
</asp:Content>
