<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscrireMenbLava.aspx.cs" Inherits="prjWebCsTransaction1.inscrireMenbLava" %>

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
    <title>LavaInscriptions</title>
    <style>
           #ilog{
            color:red;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
            .log{
            width:50px;
            height:50px;
        }
        .ll_right_bg {
            background-image: url(image/ll_step1_img.jpg);
            background-size: contain;
            width: 800px;
            background-size: cover;
            height: 700px;
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
          color:black;
          margin-top:-15px;

        }
           .lstJour{
               width:20%;
                height:40px;
           }
           .lstMoi{
               width:40%;
               height:40px;

           }
           .lstAnne{
               width:30%;
               height:40px;

           }
           .btnJoinNow{
               background-color:red;
               color:white;
               margin-top:20px;
                border:20px;
           }
           table{
                margin-left:20px;
                width:300px;
            }
           .btnlogin{
               border:20px;
               margin-right:20px;
           }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div class="container">
    <i id="ilog"><img src="image/loglava.png"class="log"/>Lavalife</></i><br />
   <div class="row">
      <div class="col-sm-8 ll_right_bg">
     </div>  
       <div class="col-sm-4 ll_let_bg">
         <i id="ilogtableaux"><img src="image/loglava.png"class="log"/></></i>
           <p id="p1">Create Your Profile</p>
            <p id="p2">AND RECEIVE A 7-DAY FREE TRIAL.</p>
           <table>
               <tr>
                   <td>First Name</td>
                    <td>Last Name</td>
               </tr>
                 <tr>
                   <td>
                       <asp:TextBox ID="txtPrenom" runat="server" Height="35px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txtNom" runat="server" Height="35px"></asp:TextBox></td>
               </tr>
                   <tr>
                   <td >I'm a</td>
               </tr>
               <tr>
                    <td colspan="3">
                       <asp:DropDownList ID="cboSexe" runat="server" Width="100%" Height="35px"></asp:DropDownList></td>
               </tr>
               <tr>
                   <td>Birthday</td>
               </tr>
               <tr>
                  <td  colspan="3"><asp:ListBox ID="lstMoi" runat="server" CssClass="lstMoi" Rows="1" ></asp:ListBox>
                  
                       <asp:ListBox ID="lstJour" runat="server"  Rows="1" CssClass="lstJour"  ></asp:ListBox>
               
                       <asp:ListBox ID="lstAnne" runat="server"  Rows="1" CssClass="lstAnne"></asp:ListBox></td>
               </tr>
               <tr>
                   <td>Email Adress</td>
               </tr>
               <tr><td colspan="3">
                   <asp:TextBox ID="txtEmail" runat="server" Width="100%" Height="35px"></asp:TextBox></td></tr>
               <tr>
                   <td>Password</td>

               </tr>
               <tr>
                   <td colspan="3">
                       <asp:TextBox ID="txtPassword" runat="server" Width="100%" Height="35px"></asp:TextBox></td>
               </tr>
               <tr>
                   <td colspan="3">
                       <asp:Button ID="btnJoinNow" runat="server" Text="JOIN NOW" CssClass="btnJoinNow" Width="100%" Height="35px" OnClick="btnJoinNow_Click" /></td>
               </tr>
                <tr>
                   <td colspan="3" style="text-align:center;margin-top:50px;">OR</td>
               </tr>
               <tr><td colspan="3" style="border:10px;">
                   <asp:Button ID="btnFacebook" runat="server" CssClass="btnJoinNow" Text="SIGN UP FACEBOOK" BackColor="White" ForeColor="Black" Width="100%" /></td></tr>
               <tr><td colspan="3">
                   <hr style="width:100%;"/>
                   </td></tr>
               <tr style="margin-left:50px;"><td>
                   Already a member?
                   </td>
                   <td><asp:Button ID="btnlogin" runat="server" CssClass="btnlogin" Text="Log in" BackColor="White" ForeColor="Black" OnClick="btnlogin_Click" /></td>
               </tr>
           </table>
      </div>
        
   </div>
</div>
           <footer style="height:200px;">
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4">
                </div>
            </div>
        </div>
    </footer>
    </form>
</body>
</html>
