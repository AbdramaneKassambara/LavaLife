using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class loginLaval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsing_Click(object sender, EventArgs e)
        {
            Response.Redirect("inscrireMenbLava.aspx");
        }

        protected void btnJoinNow_Click(object sender, EventArgs e)
        {
             //recuper les champ
             string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            string sql = "SELECT RefUtilisateurs,Nom,Prenom FROM Utilisateurs WHERE Email ='" + email + "' AND Mot2Passe ='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                Session["IdUtilisateurs"] = read["RefUtilisateurs"];
                Session["NomUtilisateurs"] =read["Nom"];
                Session["PrenomUtilisateurs"] = read["Prenom"];
                conn.Close();
                Response.Redirect("accuiellLava.aspx");
            }
            else
            {   lblErreur.Visible=true;
                lblErreur.Text = "Something went wrong. Please try again.&nbsp;&nbsp;<img src='image/Error.png' width='20px' height='17px'";
            }
        }

        protected void btnModifierPass_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePasswod.aspx");
        }
    }
}