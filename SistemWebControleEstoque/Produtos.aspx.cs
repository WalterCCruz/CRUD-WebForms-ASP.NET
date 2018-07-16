using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produtos : System.Web.UI.Page
{
    ProdutoBLL objProduto = new ProdutoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarCategorias();
    }

    private void CarregarCategorias()
    {
        DdlCategoriaProduto.DataSource = objProduto.RetornarCategoriaProdutos();
        DdlCategoriaProduto.DataValueField = "id";
        DdlCategoriaProduto.DataTextField = "nome";
        DdlCategoriaProduto.DataBind();
    }

}