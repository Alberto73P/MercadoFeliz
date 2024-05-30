<%@ Page Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="fwEmpleados.aspx.cs" Inherits="wsMercaditoFeliz.fwEmpelados" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <h2>AGREGAR EMPLEADO</h2>
    <div style="display:flex; height:max-content;">
        <asp:Label Text="Nombre" runat="server" />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Apellido Paterno" runat="server" />
        <asp:TextBox ID="txtApellidoP" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Apellido Materno" runat="server" />
         <asp:TextBox ID="txtApellidoM" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="RFC" runat="server" />
         <asp:TextBox ID="txtRFC" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="télefono" runat="server" />
         <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="usuario" runat="server" />
         <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Contraseña" runat="server" />
         <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
        <asp:Button ID="btnAgregarEmp" runat="server" Text="Agregar" OnClick="btnAgregarEmp_Click" />
    </div>

    <h2>ELIMINAR EMPLEADO</h2>
    <div>
        <asp:Label Text="RFC: " runat="server" />
        <asp:TextBox ID="txtRFCDel" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminarEmp" runat="server" Text="Eliminar" OnClick="btnEliminarEmp_Click" />
    </div>
    

    <h2>ACTUALIZAR EMPLEADO</h2>
    <div>
        <asp:Label Text="RFC: " runat="server" />
         <asp:TextBox ID="txtRFCUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Nombre: " runat="server" />
        <asp:TextBox ID="txtNombreUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Apellido Paterno: " runat="server" />
        <asp:TextBox ID="txtApellidoPUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Apellido Materno: " runat="server" />
         <asp:TextBox ID="txtApellidoMUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="télefono" runat="server" />
         <asp:TextBox ID="txtTelefonoUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="usuario" runat="server" />
         <asp:TextBox ID="txtUsuarioUpd" runat="server"></asp:TextBox>
        <br/>
        <asp:Label Text="Contraseña" runat="server" />
         <asp:TextBox ID="txtContrasenaUpd" runat="server"></asp:TextBox>
        <asp:Button ID="btnActualizarEmp" runat="server" Text="Actualizar" OnClick="btnActualizarEmp_Click" />
    </div>
</asp:Content>



