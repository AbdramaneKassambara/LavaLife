using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prjWebCsTransaction1
{
    public partial class inscrireMenbLava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                RemplirMoi();
                RemplirJour();
                RemplirAnne();
                RemplirSex();
            }
        }

        private void RemplirSex()
        {
            cboSexe.Items.Add(new ListItem("Select"));
            cboSexe.Items.Add(new ListItem("Homme"));
            cboSexe.Items.Add(new ListItem("Femme"));
            //cboSexe.Items.Add(new ListItem("Man Interested in Men"));
            //cboSexe.Items.Add(new ListItem("Woman Interested in Women"));
          

        }

        private void RemplirAnne()
        {
            lstAnne.Items.Add(new ListItem("Year"));
            for (int i = 1993; i < 2024; i++)
            {
                lstAnne.Items.Add(new ListItem(i.ToString()));
            }
        }

        private void RemplirJour()
        {
            lstJour.Items.Add(new ListItem("Day"));
            for (int i = 1; i < 32; i++)
            {
                lstJour.Items.Add(new ListItem(i.ToString()));
            }
        }

        private void RemplirMoi()
        {
            lstMoi.Items.Add(new ListItem("Month"));
            lstMoi.Items.Add(new ListItem("January"));
            lstMoi.Items.Add(new ListItem("February"));
            lstMoi.Items.Add(new ListItem("March"));
            lstMoi.Items.Add(new ListItem("April"));
            lstMoi.Items.Add(new ListItem("May"));
            lstMoi.Items.Add(new ListItem("june"));
            lstMoi.Items.Add(new ListItem("Ausgust"));
            lstMoi.Items.Add(new ListItem("Semptember"));
            lstMoi.Items.Add(new ListItem("October"));
            lstMoi.Items.Add(new ListItem("November"));
            lstMoi.Items.Add(new ListItem("December"));
            lstMoi.SelectedIndex = 0;
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginLaval.aspx");

        }

        protected void btnJoinNow_Click(object sender, EventArgs e)
        {
            //  on recupere les champs utilisateur
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mot2pass = txtPassword.Text.Trim();
            Int32 annee = Convert.ToInt32(lstAnne.SelectedItem.Text);
            string moi = lstMoi.SelectedItem.Text;
            Int16  jour = Convert.ToInt16(lstJour.SelectedItem.Text);
            string genre =cboSexe.SelectedItem.Text;
           SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
           conn.Open();
            string sql = "INSERT INTO Utilisateurs (Nom,Prenom,Genre,Email,Mot2Passe,Mois,Annee,Jours) VALUES('"+nom+"','"+prenom+"','"+genre+"','"+email+"','"+mot2pass+"','"+moi+"',"+annee+","+jour+")";
            SqlCommand cmand = new SqlCommand(sql, conn);
            cmand.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("loginLaval.aspx");
        }
    }
}