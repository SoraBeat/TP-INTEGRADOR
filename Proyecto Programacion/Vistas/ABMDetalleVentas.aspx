﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMComplejo.aspx.cs" Inherits="Vistas.ABMComplejo" %>

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
            width: 752px;
        }
        .auto-style3 {
            height: 89px;
        }
        .auto-style4 {
            margin-left: 40px;
        }
        .auto-style5 {
            width: 171px;
        }
        .auto-style10 {
            width: 26px;
        }
        .auto-style11 {
            width: 26px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style14 {
            height: 23px;
            width: 192px;
        }
        .auto-style15 {
            width: 192px;
        }
        .auto-style16 {
            text-align: center;
        }
        .auto-style17 {
            text-align: center;
            width: 101px;
        }
        .auto-style18 {
            height: 23px;
            width: 101px;
        }
        .auto-style19 {
            width: 101px;
        }
        .auto-style20 {
            width: 26px;
            height: 26px;
        }
        .auto-style21 {
            width: 192px;
            height: 26px;
        }
        .auto-style22 {
            width: 101px;
            height: 26px;
        }
        .auto-style23 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">*Nombre del cine*</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton ID="LinkButton1" runat="server">Cerrar sesion</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <p class="auto-style4">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DETALLE DE VENTAS</p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style16">Filtrar busqueda</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Quitar filtro" />
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <img alt="" class="auto-style3" src="" />*Perfil admin*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Width="734px">

                        </asp:GridView>
                    </td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>
                    </td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style16">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td>
                        <asp:HyperLink ID="hlComplejos" runat="server" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td>
                        <asp:HyperLink ID="hlSalas" runat="server" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td>
                        <asp:HyperLink ID="hlPeliculas" runat="server" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20"></td>
                    <td>
                        <asp:HyperLink ID="hlFunciones" runat="server" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
                    </td>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlAsientos" runat="server" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlAsientosComprados" runat="server" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVentas" runat="server" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlDV" runat="server" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlUsuarios" runat="server" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
