using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de ProdutoBLL
/// </summary>
public class ProdutoBLL
{
    DAL objDAL = new DAL();
    public ProdutoBLL()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }


    public DataTable RetornarCategoriaProdutos()
    {
        return objDAL.RetDataTable("select * from categoria");
        
    }

}