<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaAdmin.aspx.cs" Inherits="Vistas.PaginaAdmin" %>

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
            width: 799px;
        }
        .auto-style3 {
            width: 276px;
        }
        .auto-style4 {
            width: 120px;
        }
        .auto-style7 {
            width: 100%;
            height: 218px;
        }
        .auto-style8 {
            width: 119px;
        }
        .auto-style9 {
            width: 118px;
        }
        .auto-style10 {
            width: 26px;
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
                        <asp:LinkButton ID="LinkButton1" runat="server">Cerrar Sesión</asp:LinkButton>
&nbsp;</td>
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="Bienvenido a la administracion"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style7">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" Height="156px" Width="148px" />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" Text="Informacion personal"></asp:Label>
                        <br />
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4">ID Usuario:</td>
                                <td>0001</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Nombre: </td>
                                <td>Pepito</td>
                            </tr>
                        </table>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style8">Apellido:</td>
                                <td>Gomez</td>
                            </tr>
                            <tr>
                                <td class="auto-style8">DNI:</td>
                                <td>42.123.123</td>
                            </tr>
                        </table>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style9">Telefono:</td>
                                <td>11-1234-1234</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Email:</td>
                                <td>PepitoGomez@gmail.com</td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlComplejos" runat="server" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlSalas" runat="server" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlPeliculas" runat="server" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlFunciones" runat="server" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlAsientos" runat="server" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlAsientosComprados" runat="server" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVentas" runat="server" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlDV" runat="server" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlUsuarios" runat="server" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
