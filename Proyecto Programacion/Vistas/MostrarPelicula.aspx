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
                                <td class="auto-style6">FORMATO</td>
                                <td class="auto-style7">
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">IDIOMA</td>
                                <td class="auto-style9">
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">FUNCION</td>
                                <td class="auto-style11">
                                    <asp:DropDownList ID="DropDownList3" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5"></td>
                                <td></td>
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
            <br />
            <br />
        </div>
    </form>
</body>
</html>
