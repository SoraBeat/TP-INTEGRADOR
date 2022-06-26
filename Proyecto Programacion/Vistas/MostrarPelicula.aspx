<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarPelicula.aspx.cs" Inherits="Vistas.MostrarPelicula" %>

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
            width: 663px;
        }
        .auto-style3 {
            width: 273px;
        }
        .auto-style4 {
            width: 399px;
        }
        .auto-style5 {
            width: 102px;
        }
        .auto-style6 {
            width: 102px;
            height: 35px;
        }
        .auto-style7 {
            height: 35px;
        }
        .auto-style8 {
            width: 102px;
            height: 34px;
        }
        .auto-style9 {
            height: 34px;
        }
        .auto-style10 {
            width: 102px;
            height: 33px;
        }
        .auto-style11 {
            height: 33px;
        }
        .auto-style12 {
            width: 150px;
        }
        .auto-style13 {
            width: 48px;
        }
        .auto-style14 {
            width: 65px;
        }
        .auto-style15 {
            height: 23px;
        }
        .auto-style16 {
            height: 23px;
            width: 260px;
        }
        .auto-style17 {
            width: 24px;
        }
        .auto-style18 {
            width: 35px;
            height: 34px;
        }
        .auto-style19 {
            width: 38px;
            height: 34px;
        }
        .auto-style20 {
            width: 34px;
            height: 34px;
        }
        .auto-style21 {
            height: 33px;
            width: 42px;
        }
        .auto-style22 {
            width: 31px;
            height: 34px;
        }
        .auto-style23 {
            width: 102px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Text="CINEPOLIS"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Ayuda" />
                        <asp:Button ID="Button2" runat="server" Text="Menu" />
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="TITULO PELICULA"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="201px" Width="396px" />
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="ELEGIR PELICULA POR:"></asp:Label>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6">COMPLEJO</td>
                                <td class="auto-style7">
                                    <asp:DropDownList ID="DDLcomplejo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLcomplejo_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:Label ID="ll" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">FORMATO</td>
                                <td class="auto-style7">
                                    <asp:DropDownList ID="DDLformato" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLformato_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">IDIOMA</td>
                                <td class="auto-style9">
                                    <asp:DropDownList ID="DDLidioma" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLidioma_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">FECHA</td>
                                <td class="auto-style11">
                                    <asp:DropDownList ID="DDLfecha" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLfecha_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style23">HORARIO</td>
                                <td class="auto-style15">
                                    <asp:DropDownList ID="DDLhorario" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLhorario_SelectedIndexChanged" Width="113px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">
                        <asp:Image ID="Image2" runat="server" Width="145px" />
                        <br />
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image3" runat="server" Height="29px" />
                                    <br />
&nbsp;
                                    <asp:Label ID="Label4" runat="server" Text="120 m"></asp:Label>
                                </td>
                                <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image4" runat="server" Height="29px" />
                                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label5" runat="server" Text="P-16"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style16">
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" Text="Sinopsis"></asp:Label>
                                    <br />
                                    <br />
                                    <span style="color: rgb(0, 0, 0); font-family: &quot;Open Sans&quot;, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. </span></td>
                                <td class="auto-style15">
                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" Text="Datos técnicos"></asp:Label>
                                    <br />
                                    <br />
                                    Titulo: Lorem Ipsum<br />
                                    Genero: Lorem Ipsum, Lorem Ipsum, Lorem Ipsum<br />
                                    Clasificacion: P-16<br />
                                    Duracion: 120 m<br />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONTACTANOS<br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style13">
                            <img alt="" class="auto-style18" src="" /></td>
                        <td class="auto-style13">
                            <img alt="" class="auto-style19" src="" /></td>
                        <td class="auto-style21">
                            <img alt="" class="auto-style20" src="" /></td>
                        <td>
                            <img alt="" class="auto-style22" src="" /></td>
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
            <br />
        </div>
    </form>
</body>
</html>
