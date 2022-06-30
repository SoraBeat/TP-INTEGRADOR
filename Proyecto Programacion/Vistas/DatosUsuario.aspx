<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosUsuario.aspx.cs" Inherits="Vistas.DatosUsuario" %>

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
    <link href="Content/hover.css" rel="stylesheet" />
    <link href="Content/animate.min.css" rel="stylesheet" />
    <link href="Content/animate2.css" rel="stylesheet" />
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
            background-color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="auto-style22 navbar animate__animated animate__slideInDown" style="background-color: rgba(0, 0, 0, 0.79); padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" href="PantallaInicial.aspx" style="margin-left: 30px;">
                    <img src="Imagenes/Pagina/logo-piola.png" style="width: 120px; height: 70px;" />
                </a>
                <div style="margin-right: 20px; display: flex; flex-direction: row; align-items: center">
                    <asp:Button class="btn btn-primary" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" />
                    <asp:Button Style="margin-left: 20px" class="btn btn-warning" ID="txtPaginaAdmin" runat="server" OnClick="txtPaginaAdmin_Click" Text="Funciones admin" Visible="False" />
                    <asp:HyperLink runat="server" ID="ContenedorUsuario" href="DatosUsuario.aspx" Style="margin-left: 20px; color: white; text-decoration: none; display: flex; flex-direction: row; align-items: end;">
                        <asp:Label Style="font-size: 20px" ID="ContenedorNombre" Text="Pepe Pepito" runat="server" />
                        <asp:Image Style="height: 40px; width: 40px" ImageUrl="/Imagenes/Pagina/persona.png" runat="server" />
                    </asp:HyperLink>
                </div>
            </nav>
            <br />
            <br />
            <div style="display:flex;flex-direction:row">
                <div style="width:50%">
                    <div>
                        <h1 style="font-weight: 900; text-align: left; margin-left: 70px">DATOS DE USUARIO</h1>
                    </div>
                    <br />
                    <br />
                    <div style="display: flex; flex-direction: row;">
                        <div style="display: flex; justify-content: center; align-items: start; width: 40%;">
                            <img style="width: 200px" src="/Imagenes/Pagina/persona.png" alt="Alternate Text" />
                        </div>
                        <div style="display: flex; flex-direction: column; justify-content: start; align-items: start; width: 80%; font-size: 25px">
                            <div>
                                <label style="font-size: ">Nombre: </label>
                                <asp:Label ID="TXT_NOMBRE" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Apellido: </label>
                                <asp:Label ID="TXT_APELLIDO" Text="" runat="server" />
                            </div>
                            <div>
                                <label>DNI: </label>
                                <asp:Label ID="TXT_DNI" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Telefono: </label>
                                <asp:Label ID="TXT_TELEFONO" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Email: </label>
                                <asp:Label ID="TXT_EMAIL" Text="" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
                <div style="width:50%">
                    <div>
                        <h1 style="font-weight: 900; text-align: left;">COMPRAS REALIZADAS</h1>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
