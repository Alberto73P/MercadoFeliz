<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wpAcceso.aspx.cs" Inherits="wsMercaditoFeliz.wpAcceso" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inicio de Sesión - Mercadito Feliz</title>
    <link rel="stylesheet" href="css/stylesLogin.css">
</head>
<body>
    
    <main>
        <section class="login">
            <h2>Inicio de Sesión</h2>
            <br>
            <form id="form1" runat="server">
                <div class="form-group">
                    <label for="email">Usuario:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </label>
                    &nbsp;
                </div>
                <div class="form-group">
                    <label for="password">Contraseña:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </label>&nbsp;
                </div>
                <br>
                <center>
                    <asp:Button ID="Button1" runat="server" BackColor="#990000" ForeColor="White" OnClick="Button1_Click" Text="iniciar sesión" />
                </center>
            </form>
        </section>
    </main>
</body>
</html>
