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


            <br />
            <br />
            <br />
            <br />
            <table class="auto-style4">
                <tr>
                    <td class="auto-style19">

                        <img src="/Imagenes/Pagina/ticket.png" style="width: 120px; height: 70px;" /></td>
                    <td class="auto-style3">
                        <asp:Label ID="lblCosto" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        <asp:TextBox ID="txtCantidad" runat="server" AutoPostBack="True" OnTextChanged="txtCantidad_TextChanged" TextMode="Number" ValidationGroup="Grupo1" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
                        <asp:RangeValidator ID="RV_CANTIDAD" runat="server" ControlToValidate="txtCantidad" MaximumValue="7" MinimumValue="1" Type="Integer" ValidationGroup="Grupo1">*</asp:RangeValidator>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblTotal" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">

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
                                <td runat="server" style="">ID_Asiento_A:
                                    <asp:TextBox ID="ID_Asiento_ATextBox" runat="server" Text='<%# Bind("ID_Asiento_A") %>' />
                                    <br />
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                    <br />
                                </td>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <td runat="server" style="">ID_Asiento_A:
                                    <asp:Label ID="ID_Asiento_ALabel" runat="server" Text='<%# Eval("ID_Asiento_A") %>' />
                                    <asp:Button OnLoad="secargaLosBotones" runat="server" id="ButtonAsiento" OnCommand="chequearBoton" CommandName="chequear" CommandArgument='<%# Eval("ID_Asiento_A") %>' text='<%# Eval("ID_Asiento_A") %>'></asp:Button>
                                    <br />
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
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">

                        <asp:ImageButton ID="ImageButton1" runat="server" Height="240px" ImageUrl="~/Imagenes/Portadas/Doctor Strange.jpg" Width="240px" />

                    </td>
                    <td class="auto-style1">
                        <table class="destacado">
                            <td>
                                <p>
                                    <asp:Label ID="lblNombrePelicula" runat="server"></asp:Label>
                                    <asp:Label ID="lblIdioma" runat="server"></asp:Label>
                                    </br>
                                    <asp:Label ID="lblComplejo" runat="server"></asp:Label>
                                    <br>
                                        <asp:Label ID="lblDireccion" runat="server"></asp:Label>
                                    </br>
                                    <asp:Label ID="lblFechayhora" runat="server"></asp:Label>
                                    &nbsp;
                                </p>
                                <p>
                                    <br>
                                    <br>
                                    &nbsp;
                                </p>
                            </td>

                        </table>

                    </td>

                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnConfirmar0" runat="server" Text="Volver" OnClick="btnConfirmar_Click" Height="26px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Siguiente" OnClick="btnConfirmar_Click" Height="26px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCineConnectionString %>" SelectCommand="SELECT [ID_Asiento_A] FROM [Asientos]"></asp:SqlDataSource>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style35"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
