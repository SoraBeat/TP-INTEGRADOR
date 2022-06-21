<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: right;
            width: 687px;
        }
        .auto-style4 {
            width: 687px;
        }
        .auto-style5 {
            color: #0000FF;
        }
        .auto-style6 {
            text-align: left;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="auto-style22" style="background-color: #10179B; width:120%; padding-left:0; padding-right:0; padding: 10px; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" href="PantallaInicial.aspx"">
                    <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
                </a>
            </nav>
            </div>
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div style="width: 100%; display: flex; flex-direction: row; justify-content:center;">
            <div style="width: 60%; display: flex; flex-direction: column; gap: 15px; align-items:center">
                <h4 style="justify-content:center">INICIAR SESIÓN</h4>
                <div style="display:flex;justify-content:center;flex-direction:row;">
                    <asp:TextBox style="margin-right:20px" ID="txtUsuario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtUsuario" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="txtUsuario" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">Email invalido</asp:RegularExpressionValidator>
                </div>
            <div style="display:flex;justify-content:center;flex-direction:row;">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <!-- validacion chk contraseña--> <input  type="checkbox" onchange="document.getElementById('txtPassword').type = this.checked ? 'text' : 'password'"/>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtUsuario" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </div>
            <div style="display:flex;justify-content:center;flex-direction:row;">
                    <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" />
            </div>
                <div 
                    <h1>No tienes una cuenta?  
                    <asp:HyperLink ID="hlRegistrarse" runat="server" CssClass="auto-style5" NavigateUrl="~/Register.aspx">Registrarse</asp:HyperLink>
                        </h1>  
            </div>
            </div>
        </div>
    </form>
</body>
</html>
