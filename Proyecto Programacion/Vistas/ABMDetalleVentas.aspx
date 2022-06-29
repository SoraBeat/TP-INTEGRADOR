<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMDetalleVentas.aspx.cs" Inherits="Vistas.ABMDetalleVentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Detalle de Ventas ADMIN</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager runat="server">
                <Scripts>
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                </Scripts>
            </asp:ScriptManager>
            <nav class="auto-style22" style="background-color: #10179B; padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" style="margin-left: 30px;" href="PantallaInicial.aspx">
                    <img style="width: 120px; height: 70px;" src="./Imagenes/Pagina/logo-piola.png" />
                </a>
                <asp:Button runat="server" onclick="desloguear" class="btn" style="height: 50px; color: white; font-weight: 700; font-size: 20px; margin-right: 30px;" Text="Cerrar sesion">
                </asp:Button>
            </nav>
            <div>
                <h1 style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">DETALLE DE VENTAS</h1>
            </div>
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlFiltro" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtFiltro" runat="server" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btn btn-secondary" ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btn btn-secondary" ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" OnClick="btnQuitarFiltro_Click" />
                    </td>
                </tr>
            </table>
            <div style="display: flex; flex-direction: row; margin-top: 20px;">
                <a style="width: 20%;text-decoration:none;color:black;" href="PaginaAdmin.aspx">
                <div style=" display: flex; flex-direction: column; justify-content: start; align-items: center;">
                    
                    <img style="width: 100px; height: 100px;" src="Imagenes/Pagina/Persona.png" alt="Alternate Text" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_NOMBREUSUARIO" Text="Nombre" runat="server" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_APELLIDOUSUARIO" Text="Apellido" runat="server" />
                    
                </div>
                </a>
                <div style="width: 80%">
                    <asp:GridView Style="width: 80%" ID="gvDetalleVentas" runat="server" Width="734px" AllowPaging="True" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText=" ID Detalle Venta">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDDETALLEVENTA" runat="server" Text='<%# Bind("IDDetalleVenta") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ID Venta">
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("IDVenta") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ID Funcion">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDFUNCION" runat="server" Text='<%# Bind("IDFuncion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ID Sala">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDSALA" runat="server" Text='<%# Bind("IDSALA") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ID Complejo">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDCOMPLEJO" runat="server" Text='<%# Bind("IDComplejo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cantidad">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_CANTIDAD" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_PRECIO" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
            </div>
            <br />
            <div class="list-group" style="width: 20%;">
                <asp:Label CssClass="auto-style23 font-weight-bolder" ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>

                <asp:HyperLink CssClass="list-group-item" ID="hlComplejos" runat="server" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlSalas" runat="server" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlPeliculas" runat="server" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlFunciones" runat="server" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlAsientos" runat="server" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlAsientosComprados" runat="server" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlVentas" runat="server" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlDV" runat="server" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
                <asp:HyperLink CssClass="list-group-item" ID="hlUsuarios" runat="server" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
