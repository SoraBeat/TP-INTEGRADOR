<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Precompra.aspx.cs" Inherits="Vistas.Precompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Compra Realizada
    </title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet" />
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
<nav class="h1" style="background-color: #10179B; padding: 10px 0; display: flex; flex-direction: row; justify-content: space-between; align-items: center;">
                <a class="" style="margin-left: 30px; width:10px; height:10px" href="PantallaInicial.aspx">
                <%--<img src="./Imagenes/Pagina/logo-piola.png"/>--%>
                </a>
                </nav> 
          
        <div>
            <h1 id="LABELPIOLA" style="text-align: center; background-color: #343434; padding: 10px 0; " class="auto-style36">GRACIAS POR ELEGIRNOS!</h1>
            <p style="text-align: center; background-color: #343434; padding: 10px 0; " class="auto-style36">Tu compra se realizó con éxito</p>
        </div>
                
          <div>
              <div>
                  CÓDIGO DE RETIRO<br />
                  <asp:Label ID="lblCodigoRetiro" runat="server" Text="Label"></asp:Label>
                  <br />
                  <asp:Image ID="imagenQR" runat="server" />
              </div>
              <div>
                  <p style="text-align: center; background-color: #343434; padding: 10px 0;">Información de tu compra:</p>
              </div>
              <div>
                  <div style="display:flex:table-column; width:49%; float:left">
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
                  <div style="display:flex:table-column; width:49%; float:right;">
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
                  </div>
              <div>
                  <asp:Button ID="btnConfirmar0" runat="server" Text="Volver" OnClick="btnConfirmar_Click" Height="26px" />
              </div>
            
          </div>
        </div>
    </form>
</body>
</html>
