<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            width: 100%;
            background-image:url("Imagenes/Pagina/fondo-login.png");
            background-size:cover;
            background-repeat:no-repeat;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="auto-style7" style=" padding-left: 0; padding-right: 0; padding: 10px; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a href="PantallaInicial.aspx">
                    <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
                </a>
            </nav>
            <br />
            <asp:ScriptManager runat="server">
                <Scripts>
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                </Scripts>
            </asp:ScriptManager>
            <br />
            <br />
            <br />
            <div style="width: 100%; display: flex; flex-direction: row; justify-content: center;">
                <div style="width: 25%; display: flex; flex-direction: column; gap: 15px; align-items: center;background-color:rgba(0, 0, 0, 0.85);-webkit-box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75);
                    -moz-box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75);
                    box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75);border-radius:10px;color:white;padding:20px 20px">
                    <h4 style="justify-content: center;font-weight:700;">INICIAR SESIÓN</h4>
                    <div style="display: flex; justify-content: center; flex-direction: row;">
                        <asp:TextBox Style="margin-right: 22px" ID="txtUsuario" runat="server"  placeholder="usuario"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtUsuario" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="txtUsuario" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">Email invalido</asp:RegularExpressionValidator>
                    </div>
                    <div style="display: flex; justify-content: center;align-items:center;gap:5px; flex-direction: row;">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="contraseña"></asp:TextBox>
                        <!-- validacion chk contraseña-->
                        <input type="checkbox" onchange="document.getElementById('txtPassword').type = this.checked ? 'text' : 'password'" />
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtUsuario" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </div>
                    <div style="display: flex; justify-content: center; flex-direction: row;">
                        <asp:Button CssClass="btn btn-danger" ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" />
                    </div>
                    <div>
                        <h1 style="font-size:15px">No tienes una cuenta?  
                        
                        <asp:HyperLink ID="hlRegistrarse" runat="server" CssClass="auto-style5" NavigateUrl="~/Register.aspx">Registrarse</asp:HyperLink>
</h1>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
