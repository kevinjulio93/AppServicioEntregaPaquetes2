<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_clientes.aspx.cs" Inherits="App.Web.registro_clientes" %>

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

        <label>Id Cliente</label><br />
        <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox><br />
        <label>Nommbre</label><br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
        <label>Direccion</label><br />
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox><br />
        <label>Ciudad</label><br />
        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox><br />
        <label>Estado</label><br />
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click1" Width="129px" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource3" ForeColor="#333333" GridLines="None" Height="66px" Width="730px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="Box" HeaderText="Box" SortExpression="Box" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="ObtenerLista" TypeName="App.Datos.PersonRepositories"></asp:ObjectDataSource>
        <br />
    </div>
    </form>
</body>
</html>
