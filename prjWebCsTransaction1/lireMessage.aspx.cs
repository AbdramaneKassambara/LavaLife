using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class lireMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Discussion();
                recuperCompte();
                LireMessage();
            }
            if (lstCompte.SelectedIndex >= 0 && lstCompte.SelectedItem.Text == "Mon Compte")
            {  //je vais verifier ici un element est selection
                Response.Redirect("UpdateCompte.aspx");
            }

        }
        private void Discussion()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 Refreceveur = Convert.ToInt32(Session["IdUtilisateurs"]);
            Int32 nbMsg = 0;
            string sql = "SELECT Messageries.RefMessagerie,Messageries.Titre,Messageries.Date,Utilisateurs.Nom,Utilisateurs.Prenom FROM Messageries,Utilisateurs WHERE Utilisateurs.RefUtilisateurs = Messageries.Envoyeur AND Messageries.Receveur = " + Refreceveur;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                nbMsg++;
            }
            read.Close();
            conn.Close();
            if (nbMsg > 0)
            {
                btnDiscussion.ForeColor = System.Drawing.Color.Red;
                btnDiscussion.Text += "(" + nbMsg.ToString() + ")";
            }
        }

        
        private void recuperCompte()
        {
            string compte = Session["NomUtilisateurs"].ToString() + "  ";
            compte += Session["PrenomUtilisateurs"].ToString();
            lstCompte.Items.Add(new ListItem(compte));
            lstCompte.Items.Add(new ListItem("Mon Compte"));


        }

        protected void btnDiscussion_Click(object sender, EventArgs e)
        {
            //Int32 RefMess = Convert.ToInt32(Session["RefMessage"]);
            Response.Redirect("LireMessageLava.aspx");


        }
        private void LireMessage()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 refMes = Convert.ToInt32(Request.QueryString["refMessage"].ToString());
            //Messages.RefMessage,Messages.Titre,Messages.Nouveau,Membres.Nom FROM Messages,Membres WHERE Membres.RefMembres = Messages.Envoyeur AND Messages.Receveur = " + refM ;
            string sql = "SELECT Message,Date FROM Messageries WHERE RefMessagerie=" + refMes;
            SqlCommand cmd = new SqlCommand(sql, conn);
           SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblMess.Text = reader["Message"].ToString();
            }
            reader.Close();
            conn.Close();   
            //refMessage
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("accuiellLava.aspx");
        }
    }
}