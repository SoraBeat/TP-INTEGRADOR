<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmarCompra.aspx.cs" Inherits="Vistas.ConfirmarCompra" %>

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

        .asiento-ocupado {
            background: url("/Imagenes/Pagina/asiento-ocupado.png");
            background-size: cover;
            background-repeat: no-repeat;
            height: 79px;
            text-align: end;
            width: 57px;
            color: white;
            font-weight: 900;
        }

        .asiento-libre {
            background: url("/Imagenes/Pagina/asiento-libre.png");
            background-size: cover;
            background-repeat: no-repeat;
            height: 79px;
            text-align: end;
            width: 57px;
            color: black;
            font-weight: 900;
        }

        .asiento-seleccionado {
            background: url("/Imagenes/Pagina/asiento-seleccionado.png");
            background-size: cover;
            background-repeat: no-repeat;
            height: 79px;
            text-align: end;
            width: 57px;
            color: black;
            font-weight: 900;
        }

        .auto-style1 {
            width: 498px;
        }

        .auto-style2 {
            width: 737px;
        }

        .auto-style3 {
            width: 560px;
        }

        .auto-style4 {
            height: 20px;
        }

        .auto-style5 {
            height: 83px;
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
            <div style="display: flex; flex-direction: row;">
                <div style="display: flex; justify-content: center; align-items: start; width: 30%">
                    <asp:Image ID="ImagenPortada" runat="server" Height="350px" ImageUrl="~/Imagenes/Portadas/Doctor Strange.jpg" Width="250px" />
                </div>
                <div style="display: flex; flex-direction: column; justify-content: start; align-items: start; gap: 10px">
                    <asp:Label Style="font-size: 30px; font-weight: 900;" Text="DATOS DE FUNCION" runat="server" />
                    <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 10px">
                        <asp:Label Style="font-size: 25px; font-weight: 900" Text="Pelicula: " runat="server" />
                        <asp:Label Style="font-size: 18px" ID="lblNombrePelicula" runat="server"></asp:Label>
                    </div>
                    <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 10px">
                        <asp:Label Style="font-size: 25px; font-weight: 900" Text="Idioma: " runat="server" />
                        <asp:Label Style="font-size: 18px" ID="lblIdioma" runat="server"></asp:Label>
                    </div>
                    <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 10px">
                        <asp:Label Style="font-size: 25px; font-weight: 900" Text="Complejo: " runat="server" />
                        <asp:Label Style="font-size: 18px" ID="lblComplejo" runat="server"></asp:Label>
                    </div>
                    <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 10px">
                        <asp:Label Style="font-size: 25px; font-weight: 900" Text="Direccion: " runat="server" />
                        <asp:Label Style="font-size: 18px" ID="lblDireccion" runat="server"></asp:Label>
                    </div>
                    <div style="display: flex; flex-direction: row; justify-content: center; align-items: center; gap: 10px">
                        <asp:Label Style="font-size: 25px; font-weight: 900" Text="Fecha y hora: " runat="server" />
                        <asp:Label Style="font-size: 18px" ID="lblFechayhora" runat="server"></asp:Label>
                    </div>

                </div>
                <div style="margin-left: 6%; text-align: left; display: flex; flex-direction: column; gap: 20px">
                    <asp:Label Style="font-size: 30px; font-weight: 900" Text="INFORMACIOND DE COMPRA" runat="server" />
                    <div>
                        <asp:Label Style="font-size: 20px" Text="Metodo de pago" runat="server" />
                        <asp:DropDownList runat="server" Style="height: 30px; width: 100px; background-color: #212529; border-color: #212529; color: white;">
                            <asp:ListItem Text="Credito" Value="Credito" />
                            <asp:ListItem Text="Debito" Value="Debito" />
                        </asp:DropDownList>
                    </div>
                    <div>
                        <asp:Label Style="font-size: 20px" Text="Costo por asiento: " runat="server" />
                        <asp:Label ID="lblCosto" runat="server"></asp:Label>
                    </div>
                    <div>
                        <div>
                            <asp:Label Style="font-size: 20px" Text="Cantidad de asientos" runat="server" />
                            <asp:TextBox Style="width: 50px; background-color: #212529; border-color: #212529; color: white;" ID="txtCantidad" runat="server" AutoPostBack="True" OnTextChanged="txtCantidad_TextChanged" TextMode="Number" ValidationGroup="Grupo1" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
                            <asp:CustomValidator ID="CVCantidad" runat="server" ControlToValidate="txtCantidad" OnServerValidate="CVCantidad_ServerValidate" Display="Dynamic" ValidationGroup="Grupo1">Cantidad invalida</asp:CustomValidator>
                        </div>
                        <br />
                        <div style="display: flex; justify-content: center">
                            <asp:Label Style="font-size: 30px" Text="ELEGIR ASIENTOS" runat="server" />
                        </div>
                        <div style="display: flex; justify-content: center; flex-direction: column; align-items: center;">
                            <asp:ListView ID="lvAsientos" runat="server" GroupItemCount="3">
                                <%--<AlternatingItemTemplate>
                                <td runat="server" style="">ID_Asiento_A:
                                    <asp:Label ID="ID_Asiento_ALabel" runat="server" Text='<%# Eval("ID_Asiento_A") %>' />
                                    <br /></td>
                            </AlternatingItemTemplate>--%>
                                <EditItemTemplate>
                                    <td runat="server" style="">ID_Asiento_A:
                                    <asp:TextBox ID="ID_Asiento_ATextBox" runat="server" Text='<%# Bind("ID_Asiento_A") %>' />
                                        <br />
                                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                        <br />
                                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                        <br />
                                    </td>
                                </EditItemTemplate>
                                <EmptyDataTemplate>
                                    <table runat="server" style="">
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
                                    <td runat="server">ID_Asiento_A:
                                    <asp:TextBox ID="ID_Asiento_ATextBox" runat="server" Text='<%# Bind("ID_Asiento_A") %>' />
                                        <br />
                                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                        <br />
                                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                        <br />
                                    </td>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <td runat="server">
                                        <asp:Button Style="margin: 10px" OnLoad="secargaLosBotones" runat="server" ID="ButtonAsiento" OnCommand="chequearBoton" CommandName="chequear" CommandArgument='<%# Eval("ID_Asiento_A") %>' Text='<%# Eval("ID_Asiento_A") %>' CssClass="asiento-libre"></asp:Button>
                                    </td>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table runat="server">
                                        <tr runat="server">
                                            <td runat="server">
                                                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                                    <tr id="groupPlaceholder" runat="server">
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style=""></td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <SelectedItemTemplate>
                                    <td runat="server" style="">ID_Asiento_A:
                                    <asp:Label ID="ID_Asiento_ALabel" runat="server" Text='<%# Eval("ID_Asiento_A") %>' />
                                        <br />
                                    </td>
                                </SelectedItemTemplate>
                            </asp:ListView>
                            <asp:Image Style="width: 220px" ImageUrl="/Imagenes/Pagina/logo-pantalla.png" runat="server" />
                        </div>
                    </div>
                    <div>
                        <asp:Label Style="font-size: 35px" Text="SUBTOTAL: $" runat="server" />
                        <asp:Label Style="font-size: 35px" ID="lblTotal" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <div style="display: flex; gap: 30px; justify-content: center; align-items: center; margin-bottom: 30px">
                <asp:Button Style="font-weight: 900; width: 161px; height: 53px;" CssClass="btn btn-danger" ID="btnVolver" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" />
                <asp:Button Style="font-weight: 900; width: 161px; height: 53px;" CssClass="btn btn-success" ID="btnConfirmar" runat="server" Text="CONFIRMAR" OnClick="btnConfirmar_Click" type="button" class="btn" data-bs-trigger="hover focus" data-bs-toggle="popover" data-bs-content="Por favor, seleccione metodo de pago, cantidad de asientos y locacion de los mismos para confirmar la compra." />
            </div>
        </div>
        <script>
            var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
            var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
                return new bootstrap.Popover(popoverTriggerEl)
            })
        </script>
    </form>
</body>
</html>
