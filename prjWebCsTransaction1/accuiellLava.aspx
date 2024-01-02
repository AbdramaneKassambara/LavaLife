<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accuiellLava.aspx.cs" Inherits="prjWebCsTransaction1.accuiellLava" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
    <title>Login</title>
    <style>
         .log {
            width: 50px;
            height: 50px;

         } #ilog{
            color:red;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
         #collapsibleNavbar{
             background-color:white;
         }
         .home{
             margin-top:10px;
             margin-left:170px;
              border:20px;
         }.discuss{
               margin-top:10px;
             margin-left:90px;
              border:20px;
          }.blog{
               margin-top:10px;
             margin-left:90px;
              border:20px;
           }.listComp{
             margin-top:10px;
             margin-left:90px;
              border:20px;
            }
             .ll_right_bg{
            background-image: url(image/LL_left_bg.jpg);
            background-size: contain;
            background-size:cover;
            margin-left:20px;
            height: 700px;
            width:700px;

             }#p1droit{
                margin-top:20px;
                color:white;
                width:500px;
                margin-left:20px;
               
            }
           #table{
               margin-top:90px;
           }
           
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="di">
             <nav class="navbar navbar-expand-sm bg-dark navbar-dark fixed-top" id="nav">
        <div class="collapse navbar-collapse" id="collapsibleNavbar">
            <ul class="navbar-nav">
                <li class="nav-item">
                   <i id="ilog"><img src="image/loglava.png"class="log"/>Lavalife</></i><br />
                </li>
                <li class="nav-item">
                    <asp:Button ID="btnHome" runat="server" CssClass="home" Text="Home" BackColor="White" OnClick="btnHome_Click" />
                </li>
                <li class="nav-item">
                   <p style="margin-left:50px;margin-top:10px;">|||</p>
                </li>
                <li class="nav-item">
                    <asp:Button ID="btnDiscussion" runat="server" CssClass="discuss" Text="Discussions" BackColor="White" OnClick="btnDiscussion_Click" />
                </li>
                <li class="nav-item">
                     <p style="margin-left:50px;margin-top:10px;">|||</p>
                </li>
                <li class="nav-item">
                    <asp:Button ID="btnBlog" runat="server" CssClass="blog" Text="Blog" BackColor="White" />
                </li>
                <li class="nav-item">
                    <p style="margin-left:70px;margin-top:10px;">|||</p>
                </li>
                 <li class="nav-item">
                 <asp:ListBox ID="lstCompte" runat="server" CssClass="listComp" Rows="1" BackColor="White" Width="230px" ForeColor="Red" Font-Bold="True" AutoPostBack="True">
                 </asp:ListBox>
                </li>
            </ul>
        </div>
    </nav>
   </div>
        <div class="container">
        <div class="row">
            <div class="col-sm-7 ll_let_bg">
      <table id="table">
          <tr><td>CherCher Nom</td>
          </tr>
          <tr><td>
              <asp:TextBox ID="txtCher" runat="server" Width="400px"></asp:TextBox>
              </td>
              <td>
                  <asp:Button ID="btnCher" runat="server" Text="CherCher" OnClick="btnCher_Click" BackColor="#FF3300" ForeColor="White"/></td>
          </tr>
          <tr>
              <asp:Table ID="tabcher" runat="server"></asp:Table>
          </tr>
          <tr>
              <td>
              <asp:Table ID="tabUtilisateur" CssClass="grid" runat="server"></asp:Table></td>

          </tr>
      </table>
         
              
         </div>  &nbsp;
             <div class="col-sm-4 ll_right_bg">
                <h2 style="color:white; margin-top:90px;margin-left:160px;">DATING FUN </h2>
               <hr style="background-color:white;"/>
                <p id="p1droit">Lavalife wants to put the excitement back in dating. We match your interests
                  to help you break the ice and give you online dating tips along the 
                    way to make sure you have the best experience possible. Get started today.</p>
                
            </div>
        </div>
    </div>
    </form>
</body>
</html>
