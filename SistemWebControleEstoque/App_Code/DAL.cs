using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Descrição resumida de DAL
/// </summary>
public class DAL
{
    private String server = "localhost";
    private String database = "estoque";
    private String user = "root";
    private String password = "root";
    private String connectionString = "Server=localhost;Database=estoque;Uid=root;Pwd=root;SslMode=none";

    private MySqlConnection connection;


    public DAL()
    {
        connectionString = String.Format(connectionString, server, database, user, password);
        connection = new MySqlConnection(connectionString); 
        connection.Open();

    }



    public DataTable RetDataTable(String sql)
    {
        DataTable dataTable = new DataTable();
        MySqlCommand command = new MySqlCommand(sql, connection);
        MySqlDataAdapter da = new MySqlDataAdapter(command);
        da.Fill(dataTable);//Aqui consigo agora solicitar p meu bd algum sql command e ele me retorna o dataTable preenchido

         return dataTable;
    }


    public void ExecutarComandoSQL(String sql)
    {
        MySqlCommand command = new MySqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }



}