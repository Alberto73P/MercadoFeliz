<%@ Page Language="C#" MasterPageFile="~/principal.Master"AutoEventWireup="true" CodeBehind="fwVentas.aspx.cs" Inherits="wsMercaditoFeliz.fwVentas" %>







<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div>
        <div>
            <asp:Label Text="Producto :" runat="server" />
            <asp:TextBox runat="server" Width="250px" ID="txtProducto" />    
            <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
        </div> 
        <div>
            <asp:Table ID="tblVenta" runat="server" Height="91px" Width="564px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Cantidad</asp:TableCell>
                    <asp:TableCell runat="server">Producto</asp:TableCell>
                    <asp:TableCell runat="server">Precio</asp:TableCell>
                    <asp:TableCell runat="server">Total</asp:TableCell>
                </asp:TableRow>               
            </asp:Table>
        </div>
        <div>
            <asp:Button ID="btnGuardar" Text="Vender" runat="server" OnClick="btnGuardar_Click" />
        </div>
    </div>
    
    
</asp:Content>








