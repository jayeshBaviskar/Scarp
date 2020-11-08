using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;

public class DAL
{
    
    SqlConnection con = null;
    public static SqlCommand cmd;
    String conString = "";

    public DAL()
	{
        conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\StockExchange\Scarp\Scrap\Database1.mdf;Integrated Security=True";
        con = new SqlConnection(conString);        
    }


    public void CloseConnection()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
    public SqlConnection returnConnection()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        
        return con;
    }


    public int MyExecuteNonQuery(String query)
    {
        SqlCommand cmd = new SqlCommand(query,con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res ; 

    }

    public object MyExecuteScalar(String query)
    {
        SqlCommand cmd = new SqlCommand(query, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        object res = cmd.ExecuteScalar();
        return res; 
    }

    public DataAdapter getAdapter(String query)
    {
        var c = new SqlConnection(conString); // Your Connection String here
        var dataAdapter = new SqlDataAdapter(query, c);
        return dataAdapter;
    }
    public SqlDataReader  MyExecuteReader(String query)
    {
        SqlCommand cmd = new SqlCommand(query, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlDataReader res = cmd.ExecuteReader();
        return res;
    }

    public object ExecuteWithParams()
    {
       
        object obj =  cmd.ExecuteScalar();
        return obj;
    }

    public SqlDataAdapter getDataAdapter(String query)
    {
       
        SqlCommand cmd = new SqlCommand(query, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
         SqlDataAdapter da = new SqlDataAdapter(cmd);

        return da;

    }
    
}