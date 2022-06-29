<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaAdmin.aspx.cs" Inherits="Vistas.PaginaAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Asientos ADMIN</title>
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

        .auto-style1 {
            font-weight: bold;
            font-size: 30px;
            color: #FFFFFF;
        }
        .auto-style2 {
            width: 80%;
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
                <asp:Button runat="server" OnClick="desloguear" class="btn" Style="height: 50px; color: white; font-weight: 700; font-size: 20px; margin-right: 30px;" Text="Cerrar sesion"></asp:Button>
            </nav>
            <div>
                <h1 id="LABELPIOLA" style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">Bienvenido a la administracion</h1>
            </div>
            <br />

            <div style="display: flex; flex-direction: row; margin-top: 20px;">
                <a style="width: 20%; text-decoration: none; color: black;" href="PaginaAdmin.aspx">
                    <div style="display: flex; flex-direction: column; justify-content: start; align-items: center;">

                        <img style="width: 100px; height: 100px;" src="Imagenes/Pagina/Persona.png" alt="Alternate Text" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_NOMBREUSUARIO" Text="Nombre" runat="server" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_APELLIDOUSUARIO" Text="Apellido" runat="server" />

                    </div>
                </a>
                <div style="width: 70%; display: grid; grid-template-columns: repeat(6,1fr); gap: 20px; margin: 0 10%">
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label class="auto-style1">ID</label>
                        <asp:Label ID="LBL_ID" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label style="font-weight: bold; font-size: 30px; color: #FFFFFF;">Nombre</label>
                        <asp:Label ID="LBL_NOMBRE" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label style="font-weight: bold; font-size: 30px; color: #FFFFFF;">Apellido</label>
                        <asp:Label ID="LBL_APELLIDO" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label style="font-weight: bold; font-size: 30px; color: #FFFFFF;">DNI</label>
                        <asp:Label ID="LBL_DNI" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label style="font-weight: bold; font-size: 30px; color: #FFFFFF;">Telefono</label>
                        <asp:Label ID="LBL_TELEFONO" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                    <div style="height: 100px; display: flex; flex-direction: column; align-items: center; justify-content: center; background-color: #10179B; border-radius: 10px; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); padding: 10px">
                        <label style="font-weight: bold; font-size: 30px; color: #FFFFFF;">Email</label>
                        <asp:Label ID="LBL_EMAIL" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <div style="display: flex; flex-direction: row;">
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
                <div class="auto-style2">
                    <h3 style="font-size: 30px; font-weight: 700;">ESTADISTICAS</h3>
                    <br />
                    <div style="display: grid; grid-template-columns: repeat(4,1fr); gap: 10%; margin-left: 60px;">
                        <div style="height: auto; background-color: rgba(4, 4, 4, 0.8); display: flex; justify-content: start; align-items: center; width: 250px; padding: 15px 20px; gap: 10px; border-radius: 10px; flex-direction: column; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75);">
                            <img style="width: 100px; height: 100px" src="Imagenes/Pagina/logo-usuario.png" alt="Alternate Text" />
                            <asp:Label Style="font-weight: 700; color: white;" Text="USUARIOS" runat="server" Font-Size="X-Large" />
                            <asp:Label Style="font-weight: 700; color: white; font-size: 25px;" ID="LBL_USUARIOS" Text="14" runat="server" />
                        </div>
                        <div style="height: auto; background-color: rgba(4, 4, 4, 0.8); display: flex; justify-content: start; align-items: center; width: 250px; padding: 15px 20px; gap: 10px; border-radius: 10px; flex-direction: column; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75);">
                            <img style="width: 100px; height: 100px" src="Imagenes/Pagina/venta-logo.png" alt="Alternate Text" />
                            <asp:Label Style="font-weight: 700; color: white;" Text="VENTAS" runat="server" Font-Size="X-Large" />
                            <asp:Label Style="font-weight: 700; font-size: 25px;" ID="LBL_VENTAS" Text="100" runat="server" />
                        </div>
                        <div style="height: auto; background-color: rgba(4, 4, 4, 0.8); display: flex; justify-content: start; align-items: center; width: 250px; padding: 15px 20px; gap: 10px; border-radius: 10px; flex-direction: column; -webkit-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); -moz-box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75); box-shadow: 0px 0px 12px 0px rgba(0,0,0,0.75);">
                            <img style="width: 100px; height: 100px" src="Imagenes/Pagina/logo-dinero.png" alt="Alternate Text" />
                            <asp:Label Style="font-weight: 700; color: white;" Text="DINERO" runat="server" Font-Size="X-Large" />
                            <asp:Label Style="font-weight: 700; font-size: 25px;" ID="LBL_DINERO" Text="$1200" runat="server" />
                            <br />
                            INICIO<asp:Calendar ID="CLD1" runat="server" OnSelectionChanged="CLD1_SelectionChanged"></asp:Calendar>
                            <br />
                            FINAL<br />
                            <asp:Calendar ID="CLD2" runat="server" OnSelectionChanged="CLD2_SelectionChanged"></asp:Calendar>
                            <br />
                            <asp:Button ID="BTNBorrarFiltro" runat="server" OnClick="BTNBorrarFiltro_Click" Text="Borrar Filtro" />
                        </div>
                    </div>
                    <br />
                    <h4>Tóp 5 peliculas mas vistas</h4>
                    <br />
                    <div>
                        <canvas style="width:300px !important;height:300px !important;" id="myChart"></canvas>
                    </div>
                </div>

            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<script>
    var nombreDePeliculas = '<%=this.NOMBREDEPELICULAS%>'.split("$");
    var vecesVista = '<%=this.VECESVISTA%>'.split("$");
    nombreDePeliculas.shift();
    vecesVista.shift();
    const ctx = document.getElementById('myChart').getContext('2d');
    const myChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: nombreDePeliculas,
            datasets: [{
                label: 'Peliculas mas vistas',
                data: vecesVista,
                backgroundColor: [
                    'rgba(255, 0, 0, 0.5)',
                    'rgba(0, 255, 0, 0.5)',
                    'rgba(0, 0, 255, 0.5)',
                    'rgba(255, 255, 0, 0.5)',
                    'rgba(255, 0, 255, 0.5)'
                ]
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
</script>
</body>
</html>
