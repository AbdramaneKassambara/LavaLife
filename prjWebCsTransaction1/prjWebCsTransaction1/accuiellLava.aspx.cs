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
    public partial class accuiellLava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Discussion();
                recuperCompte();
                utilisateur();
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
            {   btnDiscussion.ForeColor = System.Drawing.Color.Red;
                btnDiscussion.Text += "(" + nbMsg.ToString() + ")";
            }
        }

        private void utilisateur()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            string sql = "SELECT * FROM Utilisateurs ORDER BY Nom";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
   
            while (read.Read())
            {
                TableRow ligneUtilisateur = new TableRow();TableCell colonneVide = new TableCell();
                ligneUtilisateur.Cells.Add(colonneVide);

                TableCell iconeGenre = new TableCell();
                if (read["Genre"].ToString().Equals("Femme"))
                {
                    iconeGenre.Text = "<img src='image/femme.png' width='100' height='90'>";
                }
                else
                {
                    iconeGenre.Text = "<img src='image/homme.png' width='100' height='90'>";
                }
                ligneUtilisateur.Cells.Add(iconeGenre);

                TableCell nom = new TableCell();
                nom.Width = 100;
                nom.Text = "<strong>" + read["Nom"].ToString() + "</strong>";
                ligneUtilisateur.Cells.Add(nom);

                TableCell prenom = new TableCell();
             
                prenom.Text = "<strong>" + read["Prenom"].ToString() + "</strong>";
                ligneUtilisateur.Cells.Add(prenom);

                Int32 refuti = Convert.ToInt32(read["RefUtilisateurs"].ToString());
                TableCell boutonMessage = new TableCell();
                boutonMessage.Text = "<a href='MessageLava.aspx?refUtilisat=" + refuti + "' class='btn btn-danger'>Envoyer un message</a>";
                ligneUtilisateur.Cells.Add(boutonMessage);
               
                tabUtilisateur.Rows.Add(ligneUtilisateur);
            }
            read.Close();
            conn.Close();
        }
        //class='btn btn-danger'
        //
        private void recuperCompte()
        {
            string compte =  Session["NomUtilisateurs"].ToString() + "  ";
            compte += Session["PrenomUtilisateurs"].ToString();
            lstCompte.Items.Add(new ListItem(compte));
            lstCompte.Items.Add(new ListItem("Mon Compte"));
           
           
        }

        protected void btnDiscussion_Click(object sender, EventArgs e)
        {
            //Int32 RefMess = Convert.ToInt32(Session["RefMessage"]);
            Response.Redirect("LireMessageLava.aspx");


        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("accuiellLava.aspx"); 
        }

        protected void btnCher_Click(object sender, EventArgs e)
        {
            
            tabUtilisateur.Visible=false;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            string val = txtCher.Text.Trim();
            string sql = "SELECT * FROM Utilisateurs WHERE NOM='" +val+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                //string val = txtCher.Text.Trim();
                //string Nom = read["Nom"].ToString();
                //string Prenom = read["Prenom"].ToString();
                //string Np = read["Nom"].ToString() + " " + read["Prenom"].ToString();
                //if (val==Nom || val==Prenom || val==Np){
                    TableRow ligneUtilisateur = new TableRow();
                    TableCell iconeGenre = new TableCell();
                    if (read["Genre"].ToString().Equals("Femme"))
                    {
                        iconeGenre.Text = "<img src='image/femme.png' width='100' height='90'>";
                    }
                    else
                    {
                        iconeGenre.Text = "<img src='image/homme.png' width='100' height='90'>";
                    }
                    ligneUtilisateur.Cells.Add(iconeGenre);

                    TableCell nom = new TableCell();
                    nom.Width = 100;
                    nom.Text = "<strong>" + read["Nom"].ToString() + "</strong>";
                    ligneUtilisateur.Cells.Add(nom);

                    TableCell prenom = new TableCell();

                    prenom.Text = "<strong>" + read["Prenom"].ToString() + "</strong>";
                    ligneUtilisateur.Cells.Add(prenom);

                    Int32 refuti = Convert.ToInt32(read["RefUtilisateurs"].ToString());
                    TableCell boutonMessage = new TableCell();
                    boutonMessage.Text = "<a href='MessageLava.aspx?refUtilisat=" + refuti + "' class='btn btn-danger'>Envoyer un message</a>";
                    ligneUtilisateur.Cells.Add(boutonMessage);

                    tabcher.Rows.Add(ligneUtilisateur);
               
            }
            read.Close();
            conn.Close();

        }
    }
}