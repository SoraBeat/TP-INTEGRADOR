<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Vistas.Ventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ventas ADMIN</title>
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
                <div style="display: flex; flex-direction: row; align-items: center; margin-right: 20px">
                    <asp:Button runat="server" OnClick="desloguear" class="btn" Style="height: 50px; color: white; font-weight: 700; font-size: 20px;" Text="Cerrar sesion"></asp:Button>
                    <asp:HyperLink runat="server" ID="ContenedorUsuario" href="DatosUsuario.aspx" Style="margin-left: 20px; color: white; text-decoration: none; display: flex; flex-direction: row; align-items: center;">
                        <asp:Label Style="font-size: 20px" ID="ContenedorNombre" Text="Pepe Pepito" runat="server" />
                        <asp:Image Style="height: 40px; width: 40px" ImageUrl="/Imagenes/Pagina/persona2.png" runat="server" />
                    </asp:HyperLink>
                </div>
            </nav>
            <div>
                <h1 style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">VENTAS</h1>
            </div>
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlFiltro" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
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
                    <asp:GridView Style="width: 80%" ID="gvVentas" runat="server" Width="734px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gvVentas_PageIndexChanging">
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
