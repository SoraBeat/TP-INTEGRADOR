<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Precompra.aspx.cs" Inherits="Vistas.Precompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Galag Login</title>
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
            background-image: url("Imagenes/Pagina/fondo-login.png");
            background-size: cover;
            background-repeat: no-repeat;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<nav class="h1" style="background-color: #10179B; padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" style="margin-left: 30px;" href="PantallaInicial.aspx">
                    <img src="./Imagenes/Pagina/logo-piola.png" class="auto-style34" />
                </a>
                <asp:Button runat="server" OnClick="desloguear" class="btn" Style="color: white; font-weight: 700; font-size: 20px; margin-right: 30px;" Text="Cerrar sesion" Height="44px" Width="187px"></asp:Button>
                <img style="width: 100px; height: 100px;" src="Imagenes/Pagina/Persona.png" alt="Alternate Text" /></nav> 
          
        <div>
            <h1 id="LABELPIOLA" style="text-align: center; background-color: #343434; padding: 10px 0; " class="auto-style36">GRACIAS POR ELEGIRNOS!</h1>
            <p style="text-align: center; background-color: #343434; padding: 10px 0; " class="auto-style36">Tu compra se realizó con éxito</p>
        </div>
                
          <div>
              <div>
                  <asp:ImageButton ID="ImageButton" runat="server" Height="240px" Width="240px" OnClick="ImageButton1_Click" />
              </div>
              <div>
                  <p style="text-align: center; background-color: #343434; padding: 10px 0; ">Información de tu compra:</p>
              </div>
              <div style="float:left">
                  <p>Complejo:</p>
              </div>
                  <div style="float:right">
              <div>
                  <asp:Label ID="lblComplejo" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblNombrePelicula" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblSala" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblIdioma" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblFormato" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblFecha" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblHorario" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblCosto" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblAsientos" runat="server"></asp:Label>
              </div>
                      </div>
              <div>
                  <asp:Button ID="btnConfirmar0" runat="server" Text="Volver" OnClick="btnConfirmar_Click" Height="26px" />
              </div>
            
          </div>
        </div>
    </form>
</body>
</html>
