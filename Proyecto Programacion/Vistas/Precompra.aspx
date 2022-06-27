<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Precompra.aspx.cs" Inherits="Vistas.Precompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        form{
      background-color:aliceblue;
        }
       

     


               body {
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
        }

        .h1,h1{font-size:2.5rem}.h1,h1{font-size:calc(1.375rem + 1.5vw)}.h1,.h2,.h3,.h4,.h5,.h6,h1,h2,h3,h4,h5,h6{margin-top:0;margin-bottom:.5rem;font-weight:500;line-height:1.2}*,::after,::before{box-sizing:border-box}
        .auto-style29 {
            background-color: white;
            width: 648px;
            height: 377px;
        }
        .auto-style31 {
            width: 392px;
            height: 26px;
        }
        .auto-style32 {
            width: 648px;
            height: 26px;
        }
        .auto-style33 {
            width: 1271px;
            height: 26px;
        }
        .auto-style34 {
            width: 120px;
            height: 70px;
            margin-left: 0px;
        }
        .auto-style35 {
            height: 22px;
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
          
    
                <h1 id="LABELPIOLA" style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">Bienvenido juan Aaron</h1>
          
    
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style4">
                <tr>
                    <td class="auto-style19">

                         <img src="/Imagenes/Pagina/ticket.png" style="width: 120px; height: 70px;" /></td>
                    <td class="auto-style19">
                        <asp:Label ID="lblTicket" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        <input id="Text1" class="auto-style9" type="number" /></td>
                    <td class="auto-style27">
                        <asp:Label ID="lblCosto" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                    <td class="auto-style29">

                         <asp:ImageButton ID="ImageButton1" runat="server" Height="240px" ImageUrl="~/Imagenes/Portadas/Doctor Strange.jpg" Width="240px" OnClick="ImageButton1_Click" />
                         
                        </td>
                    <td class="destacado">
                        <table class="destacado">
                            <td >
                                <p>
                                    <asp:Label ID="lblNombrePelicula" runat="server"></asp:Label>
                                <br>
                                    <asp:Label ID="lblDireccion" runat="server"></asp:Label>
                                    </br>
                                    <asp:Label ID="lblFechayhora" runat="server"></asp:Label>
&nbsp;<br></br>
                        <asp:Button ID="btnConfirmar" runat="server" Text="Siguiente" OnClick="btnConfirmar_Click" Height="26px" />
                                    </p>
                                <p>
                                   <br>
                        <asp:Button ID="btnConfirmar0" runat="server" Text="Volver" OnClick="btnConfirmar_Click" Height="26px" />
                    &nbsp;</p>
                            </td>

                        </table>

                    </td>
                 
                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style31">
                        &nbsp;</td>
                    <td class="auto-style32"></td>
                    <td class="auto-style33"></td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style35"></td>
                    <td class="auto-style35"></td>
                    <td class="auto-style35"></td>
                    <td class="auto-style35"></td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
