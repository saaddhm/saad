using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace test2
{
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3LEBPS\SQLEXPRESS1;Initial Catalog=saad;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* SqlDataAdapter sda = new SqlDataAdapter("insert into info values('"+nom.Text+"',"+prenom.Text+"',"+dtnaissance.Text+"',"+mat.Text+"',"+motdepass.Text+"')", con);
            sda.Fill(dt);*/
            
        }
    }
}