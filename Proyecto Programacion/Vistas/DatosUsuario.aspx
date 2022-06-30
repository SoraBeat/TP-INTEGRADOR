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
                    </asp:HyperLink></div></nav><br />
            <br />
            <div style="display:flex;flex-direction:row">
                <div style="width:50%">
                    <div>
                        <h1 style="font-weight: 900; text-align: left; margin-left: 70px">DATOS DE USUARIO</h1></div><br />
                    <br />
                    <div style="display: flex; flex-direction: row;">
                        <div style="display: flex; justify-content: center; align-items: start; width: 40%;">
                            <img style="width: 200px" src="/Imagenes/Pagina/persona.png" alt="Alternate Text" /> </div><div style="display: flex; flex-direction: column; justify-content: start; align-items: start; width: 80%; font-size: 25px">
                            <div>
                                <label style="font-size: ">Nombre: </label><asp:Label ID="TXT_NOMBRE" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Apellido: </label><asp:Label ID="TXT_APELLIDO" Text="" runat="server" />
                            </div>
                            <div>
                                <label>DNI: </label><asp:Label ID="TXT_DNI" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Telefono: </label><asp:Label ID="TXT_TELEFONO" Text="" runat="server" />
                            </div>
                            <div>
                                <label>Email: </label><asp:Label ID="TXT_EMAIL" Text="" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
                <div style="width:50%">
                    <div>
                        <h1 style="font-weight: 900; text-align: left;">COMPRAS REALIZADAS</h1></div><div>
                        
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID_Venta_V" DataSourceID="SqlDataSource1"><AlternatingItemTemplate><span style="">ID_Venta_V: <asp:Label ID="ID_Venta_VLabel" runat="server" Text='<%# Eval("ID_Venta_V") %>' /><br />
ID_Usuario_V: <asp:Label ID="ID_Usuario_VLabel" runat="server" Text='<%# Eval("ID_Usuario_V") %>' /><br />
Fecha_V: <asp:Label ID="Fecha_VLabel" runat="server" Text='<%# Eval("Fecha_V") %>' /><br />
Metodo_Pago_V: <asp:Label ID="Metodo_Pago_VLabel" runat="server" Text='<%# Eval("Metodo_Pago_V") %>' /><br />
Monto_Final_V: <asp:Label ID="Monto_Final_VLabel" runat="server" Text='<%# Eval("Monto_Final_V") %>' /><br />
<br /></span></AlternatingItemTemplate><EditItemTemplate><span style="">ID_Venta_V: <asp:Label ID="ID_Venta_VLabel1" runat="server" Text='<%# Eval("ID_Venta_V") %>' /><br />
ID_Usuario_V: <asp:TextBox ID="ID_Usuario_VTextBox" runat="server" Text='<%# Bind("ID_Usuario_V") %>' /><br />
Fecha_V: <asp:TextBox ID="Fecha_VTextBox" runat="server" Text='<%# Bind("Fecha_V") %>' /><br />
Metodo_Pago_V: <asp:TextBox ID="Metodo_Pago_VTextBox" runat="server" Text='<%# Bind("Metodo_Pago_V") %>' /><br />
Monto_Final_V: <asp:TextBox ID="Monto_Final_VTextBox" runat="server" Text='<%# Bind("Monto_Final_V") %>' /><br />
<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" /><asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" /><br /><br /></span></EditItemTemplate><EmptyDataTemplate><span>No se han devuelto datos.</span></EmptyDataTemplate><InsertItemTemplate><span style="">ID_Usuario_V: <asp:TextBox ID="ID_Usuario_VTextBox" runat="server" Text='<%# Bind("ID_Usuario_V") %>' /><br />Fecha_V: <asp:TextBox ID="Fecha_VTextBox" runat="server" Text='<%# Bind("Fecha_V") %>' /><br />Metodo_Pago_V: <asp:TextBox ID="Metodo_Pago_VTextBox" runat="server" Text='<%# Bind("Metodo_Pago_V") %>' /><br />Monto_Final_V: <asp:TextBox ID="Monto_Final_VTextBox" runat="server" Text='<%# Bind("Monto_Final_V") %>' /><br /><asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" /><asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" /><br /><br /></span></InsertItemTemplate><ItemTemplate><span style="">ID_Venta_V: <asp:Label ID="ID_Venta_VLabel" runat="server" Text='<%# Eval("ID_Venta_V") %>' /><br />
ID_Usuario_V: <asp:Label ID="ID_Usuario_VLabel" runat="server" Text='<%# Eval("ID_Usuario_V") %>' /><br />
Fecha_V: <asp:Label ID="Fecha_VLabel" runat="server" Text='<%# Eval("Fecha_V") %>' /><br />
Metodo_Pago_V: <asp:Label ID="Metodo_Pago_VLabel" runat="server" Text='<%# Eval("Metodo_Pago_V") %>' /><br />
Monto_Final_V: <asp:Label ID="Monto_Final_VLabel" runat="server" Text='<%# Eval("Monto_Final_V") %>' /><br />
<br /></span></ItemTemplate><LayoutTemplate><div id="itemPlaceholderContainer" runat="server" style=""><span runat="server" id="itemPlaceholder" /></div><div style=""><asp:DataPager ID="DataPager1" runat="server"><Fields><asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" /><asp:NumericPagerField /><asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" /></Fields></asp:DataPager></div></LayoutTemplate><SelectedItemTemplate><span style="">ID_Venta_V: <asp:Label ID="ID_Venta_VLabel" runat="server" Text='<%# Eval("ID_Venta_V") %>' /><br />
ID_Usuario_V: <asp:Label ID="ID_Usuario_VLabel" runat="server" Text='<%# Eval("ID_Usuario_V") %>' /><br />
Fecha_V: <asp:Label ID="Fecha_VLabel" runat="server" Text='<%# Eval("Fecha_V") %>' /><br />
Metodo_Pago_V: <asp:Label ID="Metodo_Pago_VLabel" runat="server" Text='<%# Eval("Metodo_Pago_V") %>' /><br />
Monto_Final_V: <asp:Label ID="Monto_Final_VLabel" runat="server" Text='<%# Eval("Monto_Final_V") %>' /><br />
<br /></span></SelectedItemTemplate></asp:ListView></div>
                </div>
            </div>
        </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCineConnectionString %>" SelectCommand="SELECT * FROM [Ventas]"></asp:SqlDataSource></form>
</body>
</html>
