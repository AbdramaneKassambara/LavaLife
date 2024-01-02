using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class UpdatePasswod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnJoinNow_Click(object sender, EventArgs e)
        {
            // recuper les cham
            string email = txtEmail.Text.Trim();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            // recuper email 
            string sql = "SELECT RefUtilisateurs FROM Utilisateurs WHERE Email='" + email + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            if (!read.Read())
            { //Erreur
                lblErreur.Text= "Something went wrong. Please try again.&nbsp;&nbsp;<img src='image/Error.png' width='20px' height='17px'";
                read.Close();
                conn.Close();
            }
            else
            {  string newPass = txtNewPass.Text.Trim(); 
                sql = "UPDATE Utilisateurs SET Mot2Passe='"+newPass + "' WHERE RefUtilisateurs=" + read["RefUtilisateurs"];
                read.Close();
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("loginLaval.aspx");
            }     
        }
    }
}