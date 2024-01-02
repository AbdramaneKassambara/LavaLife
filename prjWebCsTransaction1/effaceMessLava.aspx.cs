using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class effaceMessLava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 refMes = Convert.ToInt32(Request.QueryString["refMessage"].ToString());
            //Messages.RefMessage,Messages.Titre,Messages.Nouveau,Membres.Nom FROM Messages,Membres WHERE Membres.RefMembres = Messages.Envoyeur AND Messages.Receveur = " + refM ;
            string sql = "DELETE FROM Messageries WHERE RefMessagerie="+refMes;
            SqlCommand cmd = new SqlCommand(sql, conn);
           cmd.ExecuteNonQuery();
            Response.Redirect("LireMessageLava.aspx");
            conn.Close();

        }
    }
}