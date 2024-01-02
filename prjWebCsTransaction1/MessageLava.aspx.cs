using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
  
    public partial class MessageLava : System.Web.UI.Page
    {
        Int32 nbMsg = 0;
        static string contro = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Page.IsPostBack==false)
            {
               cboDes.Visible = false;
                recuperCompte();
                lbldestinateu();
                Discussion();
                
            }
            if (lstCompte.SelectedIndex >= 0 && lstCompte.SelectedItem.Text == "Mon Compte")
            {  //je vais verifier ici un element est selection
                Response.Redirect("UpdateCompte.aspx");
            }

        }
        
        private void lbldestinateu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 Refreceveur = Refreceveur = Convert.ToInt32(Request.QueryString["refUtilisat"].ToString());
            string sql = "SELECT Nom,Prenom,Genre FROM Utilisateurs WHERE RefUtilisateurs=" + Refreceveur;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                if (read["Genre"].ToString().Equals("Femme"))
                {
                    litimg.Text = "<img src='image/femme.png' width='100' height='90'> <br> <strong> " + read["Nom"].ToString() + "<br>" + read["Prenom"].ToString() + "</strong>";
                }
                else
                {
                    litimg.Text = "<img src='image/homme.png' width='100' height='90'> <br> <strong> " + read["Nom"].ToString() + "<br> " + read["Prenom"].ToString()+ "</strong>";
                }
             
            }
           
            read.Close();
            conn.Close();
        }

        private void Discussion()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 Refreceveur = Convert.ToInt32(Session["IdUtilisateurs"]);
            string sql = "SELECT * FROM Messageries WHERE Receveur =" + Refreceveur;
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

        protected void btnDest_Click(object sender, EventArgs e)
        {
            contro = "Destinateur Modifier";
            cboDes.Visible = true;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            string sql = "SELECT * FROM Utilisateurs ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ListItem elem = new ListItem();
                elem.Text = read["Nom"].ToString() + "  " + read["Prenom"].ToString();
                elem.Value=read["RefUtilisateurs"].ToString();
                cboDes.Items.Add(elem);

                
            }
            read.Close();
            conn.Close();
            cboDes_SelectedIndexChanged(sender, e);
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string tit = txtTitre.Text.Trim();
            string mess = txtMessage.Text.Trim();
            Int32 envo = Convert.ToInt32(Session["IdUtilisateurs"]);
            // DateTime.Now.ToShortDateString()
            if (contro.Equals("Destinateur Modifier"))
            {
                Int32 recev = Convert.ToInt32(cboDes.SelectedItem.Value);
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
                conn.Open();
                String sql = "INSERT INTO Messageries (Envoyeur,Receveur,Titre,Message,Status,Date) VALUES(" + envo + "," + recev + ",'" + tit + "','" + mess + "','True',"+ DateTime.Now.ToShortDateString()+")";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if(contro.Length == 0)
            {
                Int32 Refreceveur  = Convert.ToInt32(Request.QueryString["refUtilisat"].ToString());
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
                conn.Open();
                String sql = "INSERT INTO Messageries (Envoyeur,Receveur,Titre,Message,Status,Date) VALUES(" + envo + "," + Refreceveur + ",'" + tit + "','" + mess + "','True'," + DateTime.Now.ToShortDateString() + ")";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            Response.Redirect("accuiellLava.aspx");

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("accuiellLava.aspx");
        }

        protected void cboDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataprjTransction1;Integrated Security=True");
            conn.Open();
            Int32 refutil = Convert.ToInt32(cboDes.SelectedItem.Value);
            string sql = "SELECT * FROM Utilisateurs Where RefUtilisateurs="+ refutil;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read["Genre"].ToString().Equals("Femme"))
                {
                    litimg.Text = "<img src='image/femme.png' width='100' height='90'> <br> <strong> " + read["Nom"].ToString() + "<br>" + read["Prenom"].ToString() + "</strong>";
                }
                else
                {
                    litimg.Text = "<img src='image/homme.png' width='100' height='90'> <br> <strong> " + read["Nom"].ToString() + "<br> " + read["Prenom"].ToString() + "</strong>";
                }

            }
            read.Close();
            conn.Close();

        }
    }
}
