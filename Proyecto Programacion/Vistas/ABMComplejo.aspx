﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMComplejo.aspx.cs" Inherits="Vistas.ABMComplejo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Complejos ADMIN</title>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: 'Roboto', sans-serif;
            text-align: center;
            font-weight: 500;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style16 {
            text-align: center;
        }

        .auto-style20 {
            width: 275px;
        }

        .auto-style22 {
            width: 100%;
            left: 0px;
            top: 0px;
        }

        .auto-style23 {
            position: relative;
            display: block;
            color: #212529;
            text-decoration: none;
            background-color: #fff;
            left: 0px;
            top: 0px;
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
                <asp:Button runat="server" onclick="desloguear" class="btn" style="height: 50px; color: white; font-weight: 700; font-size: 20px; margin-right: 30px;" Text="Cerrar sesion">
                </asp:Button>
            </nav>
            <div>
                <h1 style="text-align: center; background-color: #343434; padding: 10px 0; color: white; font-weight: 700;">COMPLEJOS</h1>
            </div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlFiltro" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="tbFiltro" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button class="btn btn-secondary" ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button class="btn btn-secondary" ID="btnFiltrarTodo" runat="server" Text="Quitar filtro" OnClick="btnFiltrarTodo_Click" />
                    </td>
                </tr>
            </table>
            <div style="display: flex; flex-direction: row; margin-top: 20px;">
                <a style="width: 20%;text-decoration:none;color:black;" href="PaginaAdmin.aspx">
                <div style=" display: flex; flex-direction: column; justify-content: start; align-items: center;">
                    
                    <img style="width: 100px; height: 100px;" src="Imagenes/Pagina/Persona.png" alt="Alternate Text" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_NOMBREUSUARIO" Text="Nombre" runat="server" />
                        <asp:Label Style="font-size: 20px; font-weight: 700;" ID="LBL_APELLIDOUSUARIO" Text="Apellido" runat="server" />
                    
                </div>
                </a>
                <div style="width: 80%">
                    <asp:GridView Style="width: 80%;" ID="gvComplejos" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" Width="734px" AutoGenerateColumns="False" OnRowCancelingEdit="gvComplejos_RowCancelingEdit" OnRowDeleting="gvComplejos_RowDeleting" OnRowEditing="gvComplejos_RowEditing" OnRowUpdating="gvComplejos_RowUpdating" AllowPaging="True" OnPageIndexChanging="gvComplejos_PageIndexChanging" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                        <Columns>
                            <asp:TemplateField HeaderText="ID">
                                <EditItemTemplate>
                                    <asp:Label ID="LBL_EDT_ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_ID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NOMBRE">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_NOMBRE" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_NOMBRE" runat="server" ControlToValidate="TXT_EDT_NOMBRE" Display="Dynamic">CAMPO VACIO</asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_NOMBRE" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DIRECCION">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_DIRECCION" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_DIRECCION" runat="server" ControlToValidate="TXT_EDT_DIRECCION" Display="Dynamic">CAMPO VACIO</asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_DIRECCION" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="TELEFONO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_TELEFONO" runat="server" Text='<%# Bind("Telefono") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_TELEFONO" runat="server" ControlToValidate="TXT_EDT_TELEFONO" Display="Dynamic">CAMPO VACIO</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="reTelefono0" runat="server" ControlToValidate="TXT_EDT_TELEFONO" ValidationExpression="^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$">TELEFONO INVALIDO</asp:RegularExpressionValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_TELEFONO" runat="server" Text='<%# Bind("Telefono") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="EMAIL">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TXT_EDT_EMAIL" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RFV_EMAIL" runat="server" ControlToValidate="TXT_EDT_EMAIL" Display="Dynamic">CAMPO VACIO</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="reEmail0" runat="server" ControlToValidate="TXT_EDT_EMAIL" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">EMAIL INVALIDO</asp:RegularExpressionValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_EMAIL" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ESTADO">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="TXT_EDT_ESTADO" runat="server" Checked="True" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LBL_IT_ESTADO" runat="server" Text='<%# Bind("Estado") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />

                    </asp:GridView>
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </div>
            </div>
            <br />
            <div style="width: 100%;display:flex;flex-direction:row;">
                <div class="list-group" style="width: 20%;">
                    <asp:Label CssClass="auto-style23 font-weight-bolder" ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" Text="MODIFICACION"></asp:Label>

                    <asp:HyperLink CssClass="list-group-item" ID="hlComplejos" runat="server" NavigateUrl="~/ABMComplejo.aspx">Complejos</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlSalas" runat="server" NavigateUrl="~/ABMSalas.aspx">Salas</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlPeliculas" runat="server" NavigateUrl="~/ABMPeliculas.aspx">Peliculas</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlFunciones" runat="server" NavigateUrl="~/ABMFunciones.aspx">Funciones</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlAsientos" runat="server" NavigateUrl="~/ABMAsientos.aspx">Asientos</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlAsientosComprados" runat="server" NavigateUrl="~/ABMAsientosComprados.aspx">Asientos Comprados</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlVentas" runat="server" NavigateUrl="~/Ventas.aspx">Ventas</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlDV" runat="server" NavigateUrl="~/ABMDetalleVentas.aspx">Detalle de Ventas</asp:HyperLink>
                    <asp:HyperLink CssClass="list-group-item" ID="hlUsuarios" runat="server" NavigateUrl="~/ABMUsuario.aspx">Usuarios</asp:HyperLink>
                </div>
                <div style="width: 60%;display:flex;flex-direction:column;gap:15px;">
                    <h4>AGREGAR COMPLEJO</h4>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtID" runat="server" ValidationGroup="Grupo1" placeholder="ID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ValidationGroup="Grupo1" Display="Dynamic">*</asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="Grupo1" placeholder="NOMBRE"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ValidationGroup="Grupo1" Display="Dynamic">*</asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtDireccion" runat="server" ValidationGroup="Grupo1" placeholder="DIRECCION"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDireccion" ValidationGroup="Grupo1" Display="Dynamic">*</asp:RequiredFieldValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="Grupo1" placeholder="TELEFONO"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelefono" ValidationGroup="Grupo1" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="reTelefono" runat="server" ControlToValidate="txtTelefono" ValidationExpression="^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$" ValidationGroup="Grupo1" Display="Dynamic">Telefono invalido</asp:RegularExpressionValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;">
                        <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="Grupo1" placeholder="EMAIL"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ValidationGroup="Grupo1" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="reEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Grupo1" Display="Dynamic">Email invalido</asp:RegularExpressionValidator>
                    </div>
                    <div style="display:flex;justify-content:center;flex-direction:row;text-align:center;">
                        <asp:Button CssClass="btn btn-primary" ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Guardar" ValidationGroup="Grupo1" />
                        <asp:Label ID="lblResultadoGuardar" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
