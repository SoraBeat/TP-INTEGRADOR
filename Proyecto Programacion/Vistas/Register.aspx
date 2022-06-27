<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Vistas.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Galag Registro</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Content/owl.carousel.css" />
    <link href="Content/hover.css" rel="stylesheet" />
    <link href="Content/animate.min.css" rel="stylesheet" />
    <link href="Content/animate2.css" rel="stylesheet" />
    <style type="text/css">
        body {
            width: 100%;
            background-image: url("Imagenes/Pagina/fondo-login.png");
            background-size: cover;
            background-repeat: no-repeat;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="auto-style7" style="padding-left: 0; padding-right: 0; padding: 10px; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a href="PantallaInicial.aspx">
                    <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
                </a>
            </nav>
            <br />
            <br />
            <br />
            <br />
            <div style="width: 100%; display: flex; flex-direction: row; justify-content: center;">
                <div style="width: 25%; display: flex; flex-direction: column; gap: 15px; align-items: center; background-color: rgba(0, 0, 0, 0.85); -webkit-box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.75); border-radius: 10px; color: white; padding: 20px 20px">
                    <h4 style="justify-content: center; font-weight: 700;">REGISTRARSE</h4>
                    <div style="display: flex; justify-content: center; flex-direction: column;">
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="usuario"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevNombre" runat="server" ControlToValidate="txtNombre" ValidationExpression="[A-Za-z ]*" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Solo se aceptan letras">*</asp:RegularExpressionValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="apellido"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtApellido" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevApellido" runat="server" ControlToValidate="txtApellido" ValidationExpression="[A-Za-z ]*" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Solo se aceptan letras">*</asp:RegularExpressionValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtDNI" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="dni"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDNI" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvDNI" runat="server" ControlToValidate="txtDNI" Display="Dynamic" MaximumValue="5000000" MinimumValue="3000000" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="DNI invalido, o sos muy joven o muy viejo xd">*</asp:RangeValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="telefono"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtTelefono" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevTelefono" runat="server" ControlToValidate="txtTelefono" Display="Dynamic" ValidationExpression="^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$" ValidationGroup="Grupo1" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Telefono invalido">*</asp:RegularExpressionValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="email"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="Grupo1" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Email invalido">*</asp:RegularExpressionValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtPassword" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="contraseña"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPassword" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RevContraseña" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$" ValidationGroup="Grupo1" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="La contraseña debe contener un caracter en mayuscula, uno minuscula y un caracter especial">*</asp:RegularExpressionValidator>
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:TextBox ID="txtPassword2" runat="server" ValidationGroup="Grupo1" Style="margin-right: 22px" placeholder="repetir contraseña"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPassword2" ValidationGroup="Grupo1" Display="Dynamic" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Campo vacio">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" Display="Dynamic" ValidationGroup="Grupo1" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Las contraseñas son distintas">*</asp:CompareValidator>
                        </div>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                        <br />
                        <div style="display: flex; justify-content: center; flex-direction: row;">
                            <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="REGISTRARSE" OnClick="Button1_Click" ValidationGroup="Grupo1" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:ScriptManager runat="server">
            <Scripts>
                <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                <asp:ScriptReference Path="Scripts/bootstrap.bundle.min.js" />
                <asp:ScriptReference Path="Scripts/jquery-3.6.0.min.js" />
                <asp:ScriptReference Path="Scripts/owl.carousel.js" />
            </Scripts>
        </asp:ScriptManager>
        <script>
            var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
            var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
                return new bootstrap.Popover(popoverTriggerEl)
            })
        </script>
    </form>
</body>
</html>
