using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsTransaction1
{
    public partial class indexLavalife : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            Response.Redirect("inscrireMenblava.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginLaval.aspx");
        }
    }
}