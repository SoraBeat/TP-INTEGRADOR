<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaInicial.aspx.cs" Inherits="Vistas.PantallaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 100%;
            background-color: #33CCFF;
        }
        .auto-style4 {
            height: 138px;
            text-align: center;
        }
        .auto-style5 {
            height: 131px;
        }
        .auto-style6 {
            height: 131px;
            text-align: center;
        }
        .auto-style7 {
            color: #000000;
            background-color: #FFFFFF;
        }
        .auto-style8 {
            width: 30px;
            height: 30px;
        }
        .auto-style11 {
            width: 44px;
        }
        .auto-style12 {
            width: 16px;
        }
        .auto-style13 {
            width: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="NOMBRE DEL CINE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="INICIAR SESIÓN"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="SOPORTE"></asp:Label>
        </div>
        <asp:Image ID="Image1" runat="server" Height="421px" Width="1391px" />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">COMPLEJO</td>
                <td class="auto-style2">FORMATO</td>
                <td class="auto-style2">IDIOMA</td>
                <td class="auto-style2" rowspan="2">
                    <asp:Button ID="Button10" runat="server" Text="Ver todo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="199px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button5" runat="server" Text="2D" />
                    <asp:Button ID="Button6" runat="server" Text="3D" />
                    <asp:Button ID="Button7" runat="server" Text="4D" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button8" runat="server" Text="Subtitulado" />
                    <asp:Button ID="Button9" runat="server" Text="Español" />
                </td>
            </tr>
        </table>
        <br />
        <table class="auto-style3">
            <tr>
                <td class="auto-style4"><strong>PELICULA 1</td>
                <td class="auto-style4">PELICULA 2</td>
                <td class="auto-style4">PELICULA 3</td>
                <td class="auto-style4">PELICULA 4</td>
                <td class="auto-style4">PELICULA 6</td>
                <td class="auto-style4">PELICULA 7</td>
                <td class="auto-style4">PELICULA 8</td>
            </tr>
            <tr>
                <td class="auto-style6">PELICULA 9</td>
                <td class="auto-style6">PELICULA 10</td>
                <td class="auto-style6">PELICULA 11</td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></strong></td>
            </tr>
        </table>
        <br />
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONTACTANOS<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">
                        <img alt="" class="auto-style8" src="" /></td>
                    <td class="auto-style13">
                        <img alt="" class="auto-style8" src="" /></td>
                    <td class="auto-style11">
                        <img alt="" class="auto-style8" src="" /></td>
                    <td>
                        <img alt="" class="auto-style8" src="" /></td>
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email: <a href="mailto:GmailEmpresa@gmail.com">GmailEmpresa@gmail.com</a><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono soporte: 11-1232-1234&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server">Ayuda</asp:HyperLink>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Derechos reservados <span class="auto-style7" style="font-family: arial, sans-serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">ⓒ 2022 NOMBRE DEL CINE<br />
            </span>
        </div>
        <br />
        </form>
</body>
</html>
