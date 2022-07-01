<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Precompra.aspx.cs" Inherits="Vistas.Precompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Compra Realizada</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
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
        <nav style="background-color: #10179B; padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
            <a class="" style="margin-left:30px; href="PantallaInicial.aspx">
            <img style="width: 120px; height: 70px;" src="./Imagenes/Pagina/logo-piola.png" />
            </a>
            </nav>
        <div style="background-color:#10ae5c; padding:15px; drop-shadow:initial; box-shadow: 0px 0px 20px -3px #000000d6;">
            <h1 style="text-align: center; padding: 10px 0; color: #ffffff; font-weight: 700;">GRACIAS POR ELEGIRNOS!</h1>
            <h3 style="text-align: center; color:#ffffff;">Tu compra se realizó con éxito</h3>
        </div>
          <div>
              <div style="padding:30px;">
                  <asp:Label Style="font-size: 30px; font-weight: 700;" ID="Label12" runat="server" Text="CÓDIGO DE RETIRO" Font-Bold></asp:Label>
                  <br />
                  <asp:Label Style="font-size: 20px; font-weight: 700;" ID="lblCodigoRetiro" runat="server" Text="Label"></asp:Label>
                  <br />
                  <asp:Image style="width: 300px; height: 300px;" ID="imagenQR" runat="server"/>
              </div>
              <div style="background-color: #a9a9a9; padding:5px;color: #ffffff;text-align: left;padding-left: 600px;box-shadow: 0px 0px 20px -3px #00000057;">
                      <asp:Label ID="Label13" runat="server" Text="Información de tu compra:"></asp:Label>
              </div>
              <div style="padding: 30px">
                  <div style="display:flex:table-column; width:49%; float:left;text-align: initial;padding-left: 570px;">
                    <asp:Label ID="Label1" runat="server" Text="Cine:"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Película:"></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Sala:"></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Idioma:"></asp:Label>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Formato:"></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Fecha:"></asp:Label>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Horario:"></asp:Label>
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Entradas:"></asp:Label>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Costo:"></asp:Label>
                </div>
                  <div style="display:flex:table-column; width:49%; float:right; text-align: left;">
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
                  <asp:Label ID="lblAsientos" runat="server"></asp:Label>
              </div>
              <div>
                  <asp:Label ID="lblCosto" runat="server"></asp:Label>
              </div>
                      </div>
                  <div style="padding-top:240px">
                  <asp:Button Style="font-weight: 900; width: 100px; height: 40px;" CssClass="btn btn-success" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
              </div>
                  </div>
                
            </div>
        
        </div>
    </form>
</body>
</html>
