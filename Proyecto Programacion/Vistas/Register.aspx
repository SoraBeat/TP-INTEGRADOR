<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Vistas.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
            width: 541px;
        }
        .auto-style4 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style5 {
            width: 541px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2"><strong>REGISTRO</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombre:</td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevNombre" runat="server" ControlToValidate="txtNombre" ValidationExpression="[A-Za-z ]*" ValidationGroup="Grupo1">Nombre invalido</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Apellido:</td>
                    <td>
                        <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtApellido" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevApellido" runat="server" ControlToValidate="txtApellido" ValidationExpression="[A-Za-z ]*" ValidationGroup="Grupo1">Apellido invalido</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">DNI:</td>
                    <td>
                        <asp:TextBox ID="txtDNI" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDNI" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDNI" runat="server" ControlToValidate="txtDNI" MaximumValue="5000000" MinimumValue="3000000">Dni invalido</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Teléfono:</td>
                    <td>
                        <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtTelefono" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevTelefono" runat="server" ControlToValidate="txtTelefono" ValidationExpression="^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$" ValidationGroup="Grupo1">Telefono invalido</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="Grupo1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email invalido</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Contraseña:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RevContraseña" runat="server" ControlToValidate="txtPassword" ValidationExpression="(?=^.{8,10}$)(?=.*\d)(?=.*[a-zA-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$" ValidationGroup="Grupo1">La contraseña debe tener entre 8 y 10 caracteres con al menos un carácter numérico, una letra y un carácter especial.</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Confirmar contraseña:</td>
                    <td>
                        <asp:TextBox ID="txtPassword2" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPassword2" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword2" ControlToValidate="txtPassword" ErrorMessage="Las contraseñas no coinciden" ValidationGroup="Grupo1"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="REGISTRARSE" OnClick="Button1_Click" ValidationGroup="Grupo1" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
