using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class LireMessageLava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                Discussion();
                recuperCompte();
                Message();
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
            string sql = "SELECT * FROM Messageries WHERE Receveur =" + Refreceveur;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            Int32 nbMsg = 0;
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
            
            Response.Redirect("LireMessageLava.aspx");

        }
        private void Message()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 refutilisateur = Convert.ToInt32(Session["IdUtilisateurs"]);
            //Messages.RefMessage,Messages.Titre,Messages.Nouveau,Membres.Nom FROM Messages,Membres WHERE Membres.RefMembres = Messages.Envoyeur AND Messages.Receveur = " + refM ;
            string sql = "SELECT Messageries.RefMessagerie,Messageries.Titre,Messageries.Date,Utilisateurs.Nom,Utilisateurs.Prenom,Utilisateurs.RefUtilisateurs FROM Messageries,Utilisateurs WHERE Utilisateurs.RefUtilisateurs = Messageries.Envoyeur AND Messageries.Receveur = " + refutilisateur;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            TableRow maLigne = new TableRow();
            maLigne.BackColor = Color.Red;
            maLigne.ForeColor=Color.White;
            TableCell maCol = new TableCell();
            maCol.Text = "Titres";
            maCol.Width = 300;
            maLigne.Cells.Add(maCol);

            maCol = new TableCell();
            maCol.Text = "Expediteur";
            maCol.Width = 300;
            maLigne.Cells.Add(maCol);

            maCol = new TableCell();
            maCol.Text = "Actions";
            maCol.Width = 200;
            maLigne.Cells.Add(maCol);


            tabMessage.Rows.Add(maLigne);
            //boucle a travers les message recucs par ce mmebre
            while (read.Read())
            {
                maLigne = new TableRow();
                maCol = new TableCell();
                maCol.Text = read["Titre"].ToString();
                maLigne.Cells.Add(maCol);
                Int32 refMsg = Convert.ToInt32(read["RefMessagerie"].ToString());
                Int32 refUtilisa = Convert.ToInt32(read["RefUtilisateurs"].ToString());
                maCol = new TableCell();
                maCol.Text = read["Nom"].ToString();
                maLigne.Cells.Add(maCol);
                maCol = new TableCell();
                //<a href="nom_de_page.aspx">< img src = "nom_de_l_image.png" alt = "Description de l'image" /></ a >
                //<a href='lireMessage.aspx?refMessage=" + refMsg + "'><img src=\"nom_de_l_image.png\" alt=\"Description de l'image\" /></a>
                maCol.Text = "<a href='lireMessage.aspx?refMessage=" + refMsg + "'><img src=\"image/lire.png\" width='30' height='20' /></a> " + 
                    " <a href ='effaceMessLava.aspx?refMessage=" + refMsg + "'><img src=\"image/supp.png\" width='30' height='20' /></a> " +
                    "<a href ='repon.aspx?refMessage=" + refUtilisa + "'><img src=\"image/repond.png\" width='30' height='20' /></a> ";
                maLigne.Cells.Add(maCol);

                //verifier si message est nouveau et couleur par consequence
                //if (myReder["Nouveau"].ToString() == "True")
                //{
                //    maLigne.BackColor = Color.Yellow;
                //}
                tabMessage.Rows.Add(maLigne);


                //nombMess++;
            }
            read.Close();
            conn.Close();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("accuiellLava.aspx");
        }
    }
}
