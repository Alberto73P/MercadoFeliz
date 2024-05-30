<%@ Page Language="C#"  MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="fwClientes.aspx.cs" Inherits="wsMercaditoFeliz.fwClientes" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <h2>AGREGAR CLIENTE</h2>
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
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </div>

    <h2>ELIMINAR CLIENTE</h2>
    <div>
        <asp:Label Text="RFC: " runat="server" />
        <asp:TextBox ID="txtRFCDel" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    </div>

    <h2>ACTUALIZAR CLIENTE</h2>
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
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    </div>
</asp:Content>



