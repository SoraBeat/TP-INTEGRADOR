<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMAsientosComprados.aspx.cs" Inherits="Vistas.ABMAsientosComprados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asientos Comprados ADMIN</title>
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
                <button class="btn" style="height: 50px; color: white; font-weight: 700; font-size: 20px; margin-right: 30px;">Cerrar sesion</button>
            </nav>
            <div>
                <h1 style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">ASIENTOS COMPRADOS</h1>
            </div>
            <table style="width: 100%">
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="DDL_FILTRO" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TXT_FILTRO" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btn btn-secondary" ID="BTN_FILTRAR" runat="server" Text="Filtrar" OnClick="BTN_FILTRAR_Click" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button CssClass="btn btn-secondary" ID="BTN_QUITARFILTRO" runat="server" Text="Quitar filtro" OnClick="BTN_QUITARFILTRO_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <div style="display: flex; flex-direction: row; margin-top: 20px;">
                <div style="width: 20%; display: flex; flex-direction: column; justify-content: start; align-items: center;">
                    <img style="width: 100px; height: 100px;" src="Imagenes/Pagina/Persona.png" alt="Alternate Text" />
                    <h3>NOMBRE</h3>
                    <h3>APELLIDO</h3>
                </div>
                <div style="width: 80%">
                    <asp:GridView style="width: 80%" ID="GV_ASIENTOSCOMPRADOS" runat="server" Width="734px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gvSalas_PageIndexChanging">
                        <Columns>
                            <asp:TemplateField HeaderText="ID">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DETALLE VENTA">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDDETALLEVENTA" runat="server" Text='<%# Bind("IDDETALLEVENTA") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="VENTA">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDVENTA" runat="server" Text='<%# Bind("IDVENTA") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="FUNCION">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDFUNCION" runat="server" Text='<%# Bind("IDFUNCION") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SALA">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDSALA" runat="server" Text='<%# Bind("IDSALA") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="COMPLEJO">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_IDCOMPLEJO" runat="server" Text='<%# Bind("IDCOMPLEJO") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ESTADO">
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_ESTADO" runat="server" Text='<%# Bind("ESTADO") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
            </div>

        </div>
        <br />
        <div class="list-group" style="width: 20%;">
            <asp:Label ID="Label5" runat="server" CssClass="auto-style23 font-weight-bolder" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>
            <asp:HyperLink ID="hlComplejos" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
            <asp:HyperLink ID="hlSalas" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
            <asp:HyperLink ID="hlPeliculas" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
            <asp:HyperLink ID="hlFunciones" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
            <asp:HyperLink ID="hlAsientos" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
            <asp:HyperLink ID="hlAsientosComprados" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
            <asp:HyperLink ID="hlVentas" runat="server" CssClass="list-group-item" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
            <asp:HyperLink ID="hlDV" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
            <asp:HyperLink ID="hlUsuarios" runat="server" CssClass="list-group-item" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
        </div>
    </form>
</body>
</html>
