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
            <form action="procesar_login.php" method="post">
                <div class="form-group">
                    <label for="email">Usuario:</label>
                    <input type="email" id="email" name="email" required>
                </div>
                <div class="form-group">
                    <label for="password">Contraseña:</label>
                    <input type="password" id="password" name="password" required>
                </div>
                <br>
                <center><button type="submit">Iniciar Sesión</button></center>
            </form>
        </section>
    </main>
</body>
</html>
