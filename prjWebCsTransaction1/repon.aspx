<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repon.aspx.cs" Inherits="prjWebCsTransaction1.repon" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
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
        body{
            height:900px;
        }
        .log {
            width: 50px;
            height: 50px;
        }
        #ilog{
            color:red;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
         .ll_let_bg {
            background-image: url(image/LL_left_bg.jpg);
            background-size: contain;
            width: 600px;
            background-size: cover;
             margin-top:20px;
            height: 500px;
        }
          #ilogtableaux{
            margin-left:340px;
        }
          #p1{
          color:red;
          font-size:30px;
          font-family:Consolas;

        }
           #p2{
          font-family:bold;
          color:white;
          margin-top:-15px;

        }
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
             #p1droit{
                margin-top:20px;
                color:white;
                width:500px;
                margin-left:20px;
               
            }
             .btnDest{
                 border:20px;
             }
             .cboDes{
                 margin-left:25px;
             }
             h2{
                 text-align:center;
                 margin-top:30px;
             }
             .btnSend{
                 margin-left:30px;
                  border:20px;
             }.btnAnnul{
                   border:20px;
                    margin-left:30px;
              }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div class="container">
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
                    <asp:Button ID="btnDiscussion" runat="server" CssClass="discuss" Text="Discussions" BackColor="White" />
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
    <i id="ilog"><img src="image/loglava.png"class="log"/>Lavalife</></i><br />
   <div class="row">
      <div class="col-sm-6 ll_right_bg">
          <h2><strong>Rediger Message </strong></h2>
          <table>
              <tr><td>Destinateur</td></tr>
              <tr> <td>
          <asp:Button ID="btnDest" runat="server" Text="Modifier Destinateur" CssClass="btnDest" Font-Italic="True" Font-Bold="True" BackColor="Red" ForeColor="White" OnClick="btnDest_Click"/></td>
                 <td> <asp:DropDownList ID="cboDes" runat="server" Width="250px" CssClass="cboDes" Font-Bold="True" Font-Italic="True" ForeColor="Red"></asp:DropDownList></td>
              </tr>
               <tr> <td>
                  <asp:Literal ID="litimg" runat="server"></asp:Literal></td>
     </tr>
  <tr>
    <td colspan="4">Titre</td>
  </tr>
  <tr>
    <td colspan="4">
      <asp:TextBox ID="txtTitre"  Width="500px"  runat="server"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td colspan="4">Message</td>
  </tr>
  <tr>
    <td colspan="4">
      <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Width="500px" Height="200px"></asp:TextBox>
    </td>
  </tr>
     <tr><td>
         <asp:Button ID="btnSend" runat="server" Text="Envoyer" CssClass="btnSend" Width="150px" ForeColor="Red" Font-Bold="True" Font-Italic="True" BackColor="White" OnClick="btnSend_Click"/></td>
         <td>
             <asp:Button ID="btnAnnul" runat="server" Text="Annuler" CssClass="btnAnnul" Width="150px" ForeColor="Red" Font-Bold="True" Font-Italic="True" BackColor="White" /></td>
     </tr>
</table>
     </div>  
       <div class="col-sm-5 ll_let_bg">
         <i id="ilogtableaux"><img src="image/loglava.png"class="log"/></></i>
           <p id="p1">Send Message</p>
            <p id="p2">WELCOME BACK TO LAVALIFE!</p>
           </div>
       </div>
          </div>
    </form>
</body>
</html>
