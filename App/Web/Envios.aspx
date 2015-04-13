<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Envios.aspx.cs" Inherits="App.Web.Envios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3><a href="index.aspx">Regresar al inicio</a></h3>
        <br />

        <h2>Facturas</h2>
        <div style="border:1px solid #0094ff; padding:10px">
            <label>Id Cliente: </label>
            <asp:DropDownList ID="selectCliente" runat="server" DataSourceID="ObjectDataPerson" DataTextField="Id" DataValueField="Id"></asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataPerson" runat="server" SelectMethod="ObtenerLista" TypeName="App.Datos.PersonRepositories"></asp:ObjectDataSource>
            <br />
            <h2>Datos del Receptor</h2>
            <label>Identificacion</label><br />
            <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox><br />
            <label>Nommbre:</label><br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <label>Direccion: </label><br />
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox><br />
            <label>Codigo postal:</label><br />
            <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox><br />
        </div>
        <br />
        <div style="border:1px solid #0094ff; padding:10px">
            <h2>Datos del Paquete</h2>
            <label>Tipo de Paquete:</label><br />
            <asp:DropDownList ID="tipoPaquete" runat="server">
                <asp:ListItem Value="1">OvernightPackage</asp:ListItem>
                <asp:ListItem Value="2">TwoDayPackage</asp:ListItem>
            </asp:DropDownList>
            <label>
            <br />
            Codigo:</label><br />
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox><br />
            <label>Peso:</label><br />
            <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox><br />
            <label>Costo: </label><br />
            <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox><br /><br />
            <br />
            <br />
        </div>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar Factura" OnClick="btnGuardar_Click" />
       
        <br />
        <br />
        <h2>
            Factura generada:
        </h2>
        <p>
            <asp:Label ID="txtPrintFactura" runat="server" Text="No hay Datos"></asp:Label>
        </p>
       
    </div>
    </form>
</body>
</html>
