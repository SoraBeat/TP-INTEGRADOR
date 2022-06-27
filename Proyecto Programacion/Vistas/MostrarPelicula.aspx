<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarPelicula.aspx.cs" Inherits="Vistas.MostrarPelicula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Galag CINE</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Content/owl.carousel.css" />
    <link href="Content/hover.css" rel="stylesheet" />
    <link href="Content/animate.min.css" rel="stylesheet" />
    <link href="Content/animate2.css" rel="stylesheet" />
    <style type="text/css">
        body {
            width: 100%;
            height: auto;
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
            background-image: url("/Imagenes/Pagina/fondo-mostrarpelicula4.png");
            background-repeat: no-repeat;
            background-size: cover;
            background-position: center center;
            background-color: rgba(0, 0, 0, 0.79);
            color: white;
        }

        .auto-style1 {
            width: 375px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server">
                <Scripts>
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                    <asp:ScriptReference Path="Scripts/bootstrap.bundle.min.js" />
                    <asp:ScriptReference Path="Scripts/jquery-3.6.0.min.js" />
                    <asp:ScriptReference Path="Scripts/owl.carousel.js" />
                </Scripts>
            </asp:ScriptManager>
            <nav class="navbar fixed-top" style="background-color: rgba(0, 0, 0, 0.79); padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" href="PantallaInicial.aspx" style="margin-left: 30px;">
                    <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
                </a>
                <div style="margin-right: 20px">
                    <asp:Button class="btn btn-primary" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" />
                    <asp:Button class="btn btn-warning" ID="txtPaginaAdmin" runat="server" OnClick="txtPaginaAdmin_Click" Text="Funciones admin" Visible="False" />
                </div>
            </nav>
            <br />
            <br />
            <br />
            <br />
            <br />
            <div style="width: 100%; background-color: rgba(0, 0, 0, 0.79);">
                <asp:Label Style="color: white; font-size: 40px" ID="LBLtitulo" runat="server" Font-Bold="True" Font-Italic="False"></asp:Label>
            </div>
            <br />
            <br />
            <br />
            <div style="display: flex; flex-direction: row; width: 100%">
                <div style="width: 50%">
                    <iframe id="youtube" runat="server" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" width="500" height="300" type="text/html" style="margin-left: 30px; border-radius: 10px;"></iframe>
                </div>
                <div style="width: 50%; display: flex; flex-direction: column; align-items: start">
                    <h3>ELEGIR FUNCION</h3>
                    <div style="display: flex; flex-direction: row; margin-top: 20px">
                        <h5 id="LBL_COMPLEJO" runat="server">Complejo</h5>
                        <asp:DropDownList Style="margin-left: 20px; background-color: #212529; color: white;" ID="DDLcomplejo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLcomplejo_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div style="display: flex; flex-direction: row">
                        <h5 id="LBL_FORMATO" runat="server">Formato</h5>
                        <asp:DropDownList Style="margin-left: 30px; background-color: #212529; color: white;" ID="DDLformato" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLformato_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div style="display: flex; flex-direction: row">
                        <h5 id="LBL_IDIOMA" runat="server">Idioma</h5>
                        <asp:DropDownList Style="margin-left: 44px; background-color: #212529; color: white;" ID="DDLidioma" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLidioma_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div style="display: flex; flex-direction: row">
                        <h5 id="LBL_FECHA" runat="server">Fecha</h5>
                        <asp:DropDownList Style="margin-left: 52px; background-color: #212529; color: white;" ID="DDLfecha" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLfecha_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div style="display: flex; flex-direction: row">
                        <h5 id="LBL_HORARIO" runat="server">Hora</h5>
                        <asp:DropDownList Style="margin-left: 62px; background-color: #212529; color: white;" ID="DDLhorario" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLhorario_SelectedIndexChanged" Width="113px">
                        </asp:DropDownList>
                    </div>
                    <div style="display: flex; flex-direction: row">
                        <asp:Button ID="BTN_COMPRAR" OnClick="btnComprar_Click" runat="server" class="btn btn-success" Text="COMPRAR"></asp:Button>
                    </div>
                </div>
            </div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">
                        <asp:Image Style="margin-left: 80px; border-radius: 10px;" ID="IMG_PORTADA" runat="server" Width="250px" />
                        <br />
                        <table class="auto-style1">
                            <tr>
                                <div style="width: 250px; display: flex; flex-direction: row; justify-content: space-around; align-content: center; margin-left: 100px; margin-top: 20px">
                                    <div style="display: flex; flex-direction: column; justify-content: center; align-items: center">
                                        <asp:Image Style="height: 80px; width: 80px;" ImageUrl="/Imagenes/Pagina/logo-duracion.png" ID="Image3" runat="server" Height="29px" />
                                        <asp:Label Style="font-size: 30px" ID="LBLduracion" runat="server"></asp:Label>
                                    </div>
                                    <div style="display: flex; flex-direction: column; justify-content: center; align-items: center">
                                        <asp:Image Style="height: 80px; width: 80px;" ImageUrl="/Imagenes/Pagina/logo-edad.png" ID="Image4" runat="server" Height="29px" />
                                        <asp:Label Style="font-size: 30px" ID="LBLclasificacion" runat="server"></asp:Label>
                                    </div>
                                </div>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style16">&nbsp;</td>
                                <td class="">
                                    <div style="display: flex; flex-direction: row; height: 400px">
                                        <div style="display: flex; flex-direction: column; align-items: start; justify-content: start; text-align: justify; width: 250px">
                                            <asp:Label Style="font-size: 25px" ID="Label6" runat="server" Font-Bold="True" Text="Sinopsis"></asp:Label>
                                            <asp:Label ID="LBLSinopsis" runat="server"></asp:Label>
                                        </div>
                                        <div style="display: flex; flex-direction: column; align-items: start; margin-left: 30px; justify-content: start; text-align: start; width: 250px">
                                            <asp:Label Style="font-size: 25px" ID="Label7" runat="server" Font-Bold="True" Font-Italic="False" Text="Datos técnicos"></asp:Label>
                                            <div>
                                                <label>Titulo: </label>
                                                <asp:Label ID="LBL_Titulo_Tecnico" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <label>Genero: </label>
                                                <asp:Label ID="LBL_Genero" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <label>Clasificacion: </label>
                                                <asp:Label ID="LBL_Clasificacion_Tecnico" runat="server"></asp:Label>
                                            </div>
                                            <div>
                                                <label>Duracion: </label>
                                                <asp:Label ID="LBL_Duracion_Tecnico" runat="server"></asp:Label>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <br />
                <div style="display: flex; flex-direction: row; justify-content: center; align-items: center;">
                    <img style="height: 80px" src="/Imagenes/Pagina/logo-piola.png" alt="Alternate Text" />
                </div>
                <br />
                <br />
                <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 20px">
                    <img class="imagen-portada" style="height: 30px" alt="" class="auto-style8" src="/Imagenes/Pagina/logo-facebook.png" />
                    <img class="imagen-portada" style="height: 30px" alt="" class="auto-style8" src="/Imagenes/Pagina/logo-twitter.png" />
                    <img class="imagen-portada" style="height: 30px" alt="" class="auto-style8" src="/Imagenes/Pagina/logo-instagram.png" />
                    <img class="imagen-portada" style="height: 30px" alt="" class="auto-style8" src="/Imagenes/Pagina/logo-youtube.png" />
                </div>
                <br />
                Email:<a style="color: white" href="mailto:GmailEmpresa@gmail.com"> Empresa@gmail.com</a>
                <br />
                Tel: 11-1232-1234
            <br />
                Derechos reservados <span class="auto-style7" style="font-family: arial, sans-serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">ⓒ 2022 GALAG<br />
                </span>
            </div>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
