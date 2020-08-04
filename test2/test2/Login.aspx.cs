using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace test2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3LEBPS\SQLEXPRESS1;Initial Catalog=saad;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*)  from info  where Matricule ='"+TextBox1.Text+"'and mdp='"+TextBox2.Text+"'", con);
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}