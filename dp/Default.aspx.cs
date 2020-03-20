using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write( Get());
    }

    private String Get()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        connection.Open();
        String sql = "insert test(id)values(1)";
        SqlCommand command = new SqlCommand(sql, connection);
        int a = command.ExecuteNonQuery();
        sql = "select count(0) from test";
        command = new SqlCommand(sql, connection);
        object obj = command.ExecuteScalar();
        return obj.ToString();
    }
}