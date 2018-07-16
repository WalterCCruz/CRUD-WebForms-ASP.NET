<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produtos.aspx.cs" Inherits="Produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de produtos</div>
        ID<asp:TextBox ID="TxtId" runat="server" Width="134px"></asp:TextBox>
        <p>
            Nome<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>
        Descricao<asp:TextBox ID="txtDescricao" runat="server" Height="92px" TextMode="MultiLine" Width="479px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p style="height: 29px">
            Categoria<asp:DropDownList ID="DdlCategoriaProduto" runat="server" Width="286px">
            </asp:DropDownList>
        </p>
        precoCusto<asp:TextBox ID="txtPrecoCusto" runat="server"></asp:TextBox>
        <p>
            precoVenda<asp:TextBox ID="txtPrecoVenda" runat="server"></asp:TextBox>
        </p>
        <p>
            Quantidade<asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
        </p>
        UnidadeMedida<asp:TextBox ID="txtUnidadeMedida" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="GridProdutos" runat="server">
        </asp:GridView>
        <asp:Button ID="BtnGravar" runat="server" Text="Button" />
        <br />
        <br />
    </form>
</body>
</html>
