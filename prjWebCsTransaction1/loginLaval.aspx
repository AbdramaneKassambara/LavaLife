<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginLaval.aspx.cs" Inherits="prjWebCsTransaction1.loginLaval" %>
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
        .log {
            width: 50px;
            height: 50px;
        }
        #ilog{
            color:red;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
         .ll_right_bg {
            background-image: url(image/ll_login_img.jpg);
            background-size: contain;
            width: 800px;
            background-size: cover;
            height: 600px;
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
           .btnJoinNow{
               background-color:red;
               color:white;
               margin-top:80px;
               margin:20px;
                border:20px;
           }
           .btnFacebook{
                 background-color:red;
               color:white;
               margin-top:10px;
                border:20px;
           }
            .btnlogin{
               border:20px;
               margin-right:20px;
           }.btnModifierPass{
                border:20px;
                margin-left:125px;
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
           <p id="p1">Log in</p>
            <p id="p2">WELCOME BACK TO LAVALIFE!</p>
            <table>
                <tr><td colspan="3">
                    <asp:Label ID="lblErreur" runat="server" Text="Erreur" Width="80%" ForeColor="#FF3300" Visible="False"></asp:Label>
                    </td></tr>
               <tr>
                   <td colspan="3">Email Address</td>
               </tr>
                <tr>
                   <td colspan="2"> <asp:TextBox ID="txtEmail" runat="server" Height="35px" Width="100%"></asp:TextBox></td>
                   <%-- <asp:RequiredFieldValidator ID="valitxtEmail" runat="server" ErrorMessage="Email requis" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>--%>
               </tr>
                 <tr>
                    <td>Password</td>
                     <td>
                         <asp:Button ID="btnModifierPass" runat="server" Text="Forgot Password" CssClass="btnModifierPass" BackColor="White" ForeColor="Black" OnClick="btnModifierPass_Click"/></td>
                 </tr>
                <tr>
                     <td colspan="2">
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
                   <asp:Button ID="btnFacebook" runat="server" CssClass="btnFacebook" Text="SIGN UP FACEBOOK" BackColor="White" ForeColor="Black" Width="400px" /></td></tr>
                 <tr><td colspan="3">
                   <hr style="width:100%;"/>
                   </td></tr>
               <tr style="margin-left:50px;"><td>
                   Not a member yet?
                   </td>
                   <td><asp:Button ID="btnsing" runat="server" CssClass="btnlogin" Text="Sign Up." BackColor="White" ForeColor="Black" OnClick="btnsing_Click" /></td>
               </tr>
                </table>
           </div>
       </div>
          </div>
    </form>
</body>
</html>
