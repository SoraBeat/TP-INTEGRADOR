<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaInicial.aspx.cs" Inherits="Vistas.PantallaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Galag CINE
    </title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Content/owl.carousel.css" />
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
        <div style="width:100%; background-color:black;height:90px;"></div>
        <nav class="auto-style22 navbar fixed-top" style="background-color: rgba(0, 0, 0, 0.79); padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
            <a class="" href="PantallaInicial.aspx" style="margin-left: 30px;">
                <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
            </a>
            <div style="margin-right: 20px">
                <asp:Button class="btn btn-primary" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" />
                <asp:Button class="btn btn-warning" ID="txtPaginaAdmin" runat="server" OnClick="txtPaginaAdmin_Click" Text="Funciones admin" Visible="False" />
            </div>
        </nav>
        <!-- CARRUSEL-->
        <div id="myCarousel" class="carousel slide" data-bs-ride="carousel">
            <!-- Carousel indicators -->
            <ol class="carousel-indicators">
                <li data-bs-target="#myCarousel" data-bs-slide-to="0" class="active"></li>
                <li data-bs-target="#myCarousel" data-bs-slide-to="1"></li>
                <li data-bs-target="#myCarousel" data-bs-slide-to="2"></li>
            </ol>

            <!-- Wrapper for carousel items -->
            <div class="carousel-inner" style="height:500px;width:100%">
                <div class="carousel-item active" style="height:500px;width:100%">
                    <img style="height:500px;width:100%" src="/Imagenes/Portadas/lightyear horizontal.jpg" class="d-block w-100" alt="Slide 1">
                </div>
                <div class="carousel-item" style="height:500px;width:100%">
                    <img style="height:500px;width:100%" src="/Imagenes/Portadas/dr strange horizontal2.jpg" class="d-block w-100" alt="Slide 2">
                </div>
                <div class="carousel-item" style="height:500px;width:100%">
                    <img style="height:500px;width:100%" src="/Imagenes/Portadas/pulp fiction horizontal.jpg" class="d-block w-100" alt="Slide 3">
                </div>
            </div>

            <!-- Carousel controls -->
            <a class="carousel-control-prev" href="#myCarousel" data-bs-slide="prev">
                <span class="carousel-control-prev-icon"></span>
            </a>
            <a class="carousel-control-next" href="#myCarousel" data-bs-slide="next">
                <span class="carousel-control-next-icon"></span>
            </a>
        </div>
        <!-- CARRUSEL-->
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">COMPLEJO</td>
                <td class="auto-style2">FORMATO</td>
                <td class="auto-style2">IDIOMA</td>
                <td class="auto-style2" rowspan="2">
                    <asp:Button ID="btnVerTodo" runat="server" Text="Ver todo" OnClick="btnVerTodo_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="DDLsucursales" runat="server" Height="17px" Width="199px" AutoPostBack="True" OnSelectedIndexChanged="DDLsucursales_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btn2D" runat="server" Text="2D" OnClick="btn2D_Click" />
                    <asp:Button ID="btn3D" runat="server" Text="3D" OnClick="btn3D_Click" />
                    <asp:Button ID="btn4D" runat="server" Text="4D" OnClick="btn4D_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnSubtitulada" runat="server" Text="Subtitulado" OnClick="btnSubtitulada_Click" />
                    <asp:Button ID="btnEspanol" runat="server" Text="Español" OnClick="btnEspanol_Click" />
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:ListView ID="lvPeliculas" runat="server" GroupItemCount="4">
                        <%--                        <AlternatingItemTemplate>
                            <td runat="server" style="background-color: #FFFFFF;color: #284775;">Titulo_P:
                                <asp:Label ID="Titulo_PLabel" runat="server" Text='<%# Eval("Titulo_P") %>' />
                                <br />Portada_P:
                                <asp:Label ID="Portada_PLabel" runat="server" Text='<%# Eval("Portada_P") %>' />
                                <br />ID_Pelicula_P:
                                <asp:Label ID="ID_Pelicula_PLabel" runat="server" Text='<%# Eval("ID_Pelicula_P") %>' />
                                <br />Descripcion_P:
                                <asp:Label ID="Descripcion_PLabel" runat="server" Text='<%# Eval("Descripcion_P") %>' />
                                <br />Duracion_P:
                                <asp:Label ID="Duracion_PLabel" runat="server" Text='<%# Eval("Duracion_P") %>' />
                                <br />Clasificacion_P:
                                <asp:Label ID="Clasificacion_PLabel" runat="server" Text='<%# Eval("Clasificacion_P") %>' />
                                <br />Genero_P:
                                <asp:Label ID="Genero_PLabel" runat="server" Text='<%# Eval("Genero_P") %>' />
                                <br />Formato_P:
                                <asp:Label ID="Formato_PLabel" runat="server" Text='<%# Eval("Formato_P") %>' />
                                <br />
                                <asp:CheckBox ID="Estado_PCheckBox" runat="server" Checked='<%# Eval("Estado_P") %>' Enabled="false" Text="Estado_P" />
                                <br /></td>
                        </AlternatingItemTemplate>--%>
                        <EditItemTemplate>
                            <td runat="server" style="background-color: #999999;">Titulo_P:
                                <asp:TextBox ID="Titulo_PTextBox" runat="server" Text='<%# Bind("Titulo") %>' />
                                <br />
                                Portada_P:
                                <asp:TextBox ID="Portada_PTextBox" runat="server" Text='<%# Bind("Portada") %>' />
                                <br />
                                ID_Pelicula_P:
                                <asp:Label ID="ID_Pelicula_PLabel1" runat="server" Text='<%# Eval("ID") %>' />
                                <br />
                                Descripcion_P:
                                <asp:TextBox ID="Descripcion_PTextBox" runat="server" Text='<%# Bind("Descripcion") %>' />
                                <br />
                                Duracion_P:
                                <asp:TextBox ID="Duracion_PTextBox" runat="server" Text='<%# Bind("Duracion") %>' />
                                <br />
                                Clasificacion_P:
                                <asp:TextBox ID="Clasificacion_PTextBox" runat="server" Text='<%# Bind("Clasificacion") %>' />
                                <br />
                                Genero_P:
                                <asp:TextBox ID="Genero_PTextBox" runat="server" Text='<%# Bind("Genero") %>' />
                                <br />
                                Formato_P:
                                <asp:TextBox ID="Formato_PTextBox" runat="server" Text='<%# Bind("Formato") %>' />
                                <br />
                                <asp:CheckBox ID="Estado_PCheckBox" runat="server" Checked='<%# Bind("Estado") %>' Text="Estado_P" />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                <br />
                            </td>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                                <tr>
                                    <td>No se han devuelto datos.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
                            <td runat="server" />
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <InsertItemTemplate>
                            <td runat="server" style="">Titulo_P:
                                <asp:TextBox ID="Titulo_PTextBox" runat="server" Text='<%# Bind("Titulo") %>' />
                                <br />
                                Portada_P:
                                <asp:TextBox ID="Portada_PTextBox" runat="server" Text='<%# Bind("Portada") %>' />
                                <br />
                                ID_Pelicula_P:
                                <asp:TextBox ID="ID_Pelicula_PTextBox" runat="server" Text='<%# Bind("ID") %>' />
                                <br />
                                Descripcion_P:
                                <asp:TextBox ID="Descripcion_PTextBox" runat="server" Text='<%# Bind("Descripcion") %>' />
                                <br />
                                Duracion_P:
                                <asp:TextBox ID="Duracion_PTextBox" runat="server" Text='<%# Bind("Duracion") %>' />
                                <br />
                                Clasificacion_P:
                                <asp:TextBox ID="Clasificacion_PTextBox" runat="server" Text='<%# Bind("Clasificacion") %>' />
                                <br />
                                Genero_P:
                                <asp:TextBox ID="Genero_PTextBox" runat="server" Text='<%# Bind("Genero") %>' />
                                <br />
                                Formato_P:
                                <asp:TextBox ID="Formato_PTextBox" runat="server" Text='<%# Bind("Formato") %>' />
                                <br />
                                <asp:CheckBox ID="Estado_PCheckBox" runat="server" Checked='<%# Bind("Estado") %>' Text="Estado_P" />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                <br />
                            </td>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <td runat="server" style="background-color: #E0FFFF; color: #333333;" class="auto-style2">
                                <asp:ImageButton Style="width: 150px; height: 300px" runat="server" OnClick="guardarPeliculaEvento" CommandName='<%# Eval("ID") %>' ImageUrl='<%# Eval("Portada") %>'></asp:ImageButton>
                            </td>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr id="groupPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF">
                                        <asp:DataPager ID="DataPager1" runat="server" PageSize="8">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                <asp:NumericPagerField />
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <td runat="server" style="background-color: #E2DED6; font-weight: bold; color: #333333;">Titulo_P:
                                <asp:Label ID="Titulo_PLabel" runat="server" Text='<%# Eval("Titulo") %>' />
                                <br />
                                Portada_P:
                                <asp:Label ID="Portada_PLabel" runat="server" Text='<%# Eval("Portada") %>' />
                                <br />
                                ID_Pelicula_P:
                                <asp:Label ID="ID_Pelicula_PLabel" runat="server" Text='<%# Eval("ID") %>' />
                                <br />
                                Descripcion_P:
                                <asp:Label ID="Descripcion_PLabel" runat="server" Text='<%# Eval("Descripcion") %>' />
                                <br />
                                Duracion_P:
                                <asp:Label ID="Duracion_PLabel" runat="server" Text='<%# Eval("Duracion") %>' />
                                <br />
                                Clasificacion_P:
                                <asp:Label ID="Clasificacion_PLabel" runat="server" Text='<%# Eval("Clasificacion") %>' />
                                <br />
                                Genero_P:
                                <asp:Label ID="Genero_PLabel" runat="server" Text='<%# Eval("Genero") %>' />
                                <br />
                                Formato_P:
                                <asp:Label ID="Formato_PLabel" runat="server" Text='<%# Eval("Formato") %>' />
                                <br />
                                <asp:CheckBox ID="Estado_PCheckBox" runat="server" Checked='<%# Eval("Estado") %>' Enabled="false" Text="Estado_P" />
                                <br />
                            </td>
                        </SelectedItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
        </table>
        <br />
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
        <asp:ScriptManager runat="server">
            <Scripts>
                <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                <asp:ScriptReference Path="Scripts/bootstrap.bundle.min.js" />
                <asp:ScriptReference Path="Scripts/jquery-3.6.0.min.js" />
                <asp:ScriptReference Path="Scripts/owl.carousel.js" />
            </Scripts>
        </asp:ScriptManager>
    </form>
</body>
</html>
