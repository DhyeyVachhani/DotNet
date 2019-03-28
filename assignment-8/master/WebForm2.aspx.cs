using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace master
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Click(object sender, EventArgs e)
        {
            getData();
        }
        void getData()
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study\SEM 6\NET\master\master\App_Data\Database1.mdf;Integrated Security=True";
            string select = "select * from Table where name like %" + ((Site1)Master).search.Text + "%";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }

    }
}