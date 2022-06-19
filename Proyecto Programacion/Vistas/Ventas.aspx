<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Vistas.Ventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 752px;
        }
        .auto-style4 {
            margin-left: 40px;
        }
        .auto-style16 {
            text-align: center;
        }
        .auto-style5 {
            width: 171px;
        }
        .auto-style3 {
            height: 89px;
        }
        .auto-style10 {
            width: 26px;
        }
        .auto-style17 {
            text-align: center;
            width: 107px;
            height: 23px;
        }
        .auto-style11 {
            width: 26px;
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
            width: 107px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style19 {
            width: 107px;
        }
        .auto-style20 {
            width: 26px;
            height: 22px;
        }
        .auto-style21 {
            height: 22px;
        }
        .auto-style23 {
            width: 107px;
            height: 22px;
        }
        .auto-style24 {
            width: 481px;
        }
        .auto-style25 {
            height: 22px;
            width: 481px;
        }
        .auto-style26 {
            width: 481px;
            height: 23px;
        }
        .auto-style27 {
            text-align: center;
            height: 23px;
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; VENTAS</p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style16">Filtrar busqueda</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlFiltro" runat="server">
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" OnClick="btnQuitarFiltro_Click" />
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <img alt="" class="auto-style3" src="" />*Perfil admin*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        <asp:GridView ID="gvVentas" runat="server" Width="734px" AutoGenerateColumns="False" AllowPaging="True">
                            <Columns>
                                <asp:TemplateField HeaderText="ID VENTA">
                                    <ItemTemplate>
                                        <asp:Label ID="LBL_IT_IDVENTA" runat="server" Text='<%# Bind("IDVenta") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ID USUARIO">
                                    <ItemTemplate>
                                        <asp:Label ID="LBL_IT_IDUSUARIO" runat="server" Text='<%# Bind("IDUsuario") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="FECHA ">
                                    <ItemTemplate>
                                        <asp:Label ID="LBL_IT_FECHAVENTA" runat="server" Text='<%# Bind("Fecha") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="METODO DE PAGO">
                                    <ItemTemplate>
                                        <asp:Label ID="LBL_IT_METODOPAGO" runat="server" Text='<%# Bind("MetodoPago") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="MONTO FINAL">
                                    <ItemTemplate>
                                        <asp:Label ID="LBL_IT_MONTOFINAL" runat="server" Text='<%# Bind("MontoFinal") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <br />
&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
            </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style26">
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>
                    </td>
                    <td class="auto-style17">
                        </td>
                    <td class="auto-style27">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlComplejos" runat="server" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style26">
                        <asp:HyperLink ID="hlSalas" runat="server" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlPeliculas" runat="server" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlFunciones" runat="server" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style26">
                        <asp:HyperLink ID="hlAsientos" runat="server" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
                    </td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlAsientosComprados" runat="server" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlVentas" runat="server" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:HyperLink ID="hlDV" runat="server" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20"></td>
                    <td class="auto-style25">
                        <asp:HyperLink ID="hlUsuarios" runat="server" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
                    </td>
                    <td class="auto-style23">
                        </td>
                    <td class="auto-style21">
                        </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <div>
        </div>
    </form>
</body>
</html>
