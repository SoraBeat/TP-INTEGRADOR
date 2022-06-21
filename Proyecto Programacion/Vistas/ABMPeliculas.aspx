﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMPeliculas.aspx.cs" Inherits="Vistas.ABMPeliculas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Peliculas ADMIN</title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
        }

        .auto-style1 {
            width: 100%;
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
                <h1 style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">PELICULAS</h1>
            </div>
            <table class="auto-style1">
                <tr class="auto-style1">
                    <td>
                        <asp:DropDownList ID="ddlFiltro" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="tbFiltro" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button class="btn btn-secondary" ID="Button1" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                        &nbsp;<asp:Button class="btn btn-secondary" ID="Button2" runat="server" Text="Quitar filtro" OnClick="btnFiltrarTodo_Click" />
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
                    <asp:GridView Style="width: 80%" ID="gvPeliculas" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" Width="734px" AutoGenerateColumns="False" OnRowCancelingEdit="gvPeliculas_RowCancelingEdit" OnRowDeleting="gvPeliculas_RowDeleting" OnRowEditing="gvPeliculas_RowEditing" OnRowUpdating="gvPeliculas_RowUpdating" OnSelectedIndexChanged="gvPeliculas_SelectedIndexChanged" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                        <Columns>
                            <asp:TemplateField HeaderText="ID_Pelicula">
                                <EditItemTemplate>
                                    <asp:Label ID="LBL_EDT_ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblIDPelicula" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                    <br />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Titulo">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_TITULO" runat="server" Text='<%# Bind("Titulo") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Titulo" runat="server" ControlToValidate="TXT_EDT_TITULO" ErrorMessage="CAMPO VACIO" ForeColor="Red"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblTituloPeliculas" runat="server" Text='<%# Bind ("Titulo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Descripcion">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_DESCRIPCION" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Descripcion" runat="server" ControlToValidate="TXT_EDT_DESCRIPCION" ErrorMessage="CAMPO VACIO" ForeColor="Red"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblDescripcionPeliculas" runat="server" Text='<%# Bind ("Descripcion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Duracion">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_DURACION" runat="server" Text='<%# Bind("Duracion") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Duracion" runat="server" ControlToValidate="TXT_EDT_DURACION" ForeColor="Red">CAMPO VACIO</asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblDuracionPelicula" runat="server" Text='<%# Bind ("Duracion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Clasificacion">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_CLASIFICACION" runat="server" Text='<%# Bind("Clasificacion") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Clasificacion" runat="server" ControlToValidate="TXT_EDT_CLASIFICACION" ErrorMessage="RequiredFieldValidator" ForeColor="Red">CAMPO VACIO</asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblClasificacionPelicula" runat="server" Text='<%# Bind ("Clasificacion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Genero">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_GENERO" runat="server" Text='<%# Bind("Genero") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Genero" runat="server" ControlToValidate="TXT_EDT_GENERO" ErrorMessage="CAMPO VACIO" ForeColor="Red"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblGeneroPeliculas" runat="server" Text='<%# Bind ("Genero") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Portada">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_PORTADA" runat="server" Text='<%# Bind("Portada") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_Portada" runat="server" ControlToValidate="TXT_EDT_PORTADA" ErrorMessage="RequiredFieldValidator" ForeColor="Red">CAMPO VACIO</asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblPortadaPelicula" runat="server" Text='<%# Bind ("Portada") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Estado">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="TXT_EDT_ESTADO" runat="server" Checked="True" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblEstadoPelicula" runat="server" Text='<%# Bind ("Estado") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </div>
            </div>
            <br />
            &nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <div style="width: 100%; display: flex; flex-direction: row;">
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
                <div style="width: 60%; display: flex; flex-direction: column; gap: 15px;">
                    <h4>AGREGAR PELICULA</h4>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtID" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="ID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtTitulo" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="TITULO"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTitulo" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="77px" TextMode="MultiLine" Width="273px" ValidationGroup="Grupo1" placeholder="DESCRIPCION"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtDuracion" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="DURACION"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDuracion" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtClasificacion" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="CLASIFICACION"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtClasificacion" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtGenero" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="GENERO"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtGenero" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtPortada" runat="server" Width="267px" ValidationGroup="Grupo1" placeholder="PORTADA"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPortada" ErrorMessage="*" ForeColor="Red" ValidationGroup="Grupo1" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:Button CssClass="btn btn-primary" ID="btnEnviar_Click" runat="server" OnClick="btnEnviar_Click_Click" Text="Guardar" ValidationGroup="Grupo1" />
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:Label ID="lblResultadoGuardar" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
