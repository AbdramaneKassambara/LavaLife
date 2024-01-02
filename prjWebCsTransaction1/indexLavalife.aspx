<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexLavalife.aspx.cs" Inherits="prjWebCsTransaction1.indexLavalife" %>

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
    <title>Lavalive</title>
    <style>
        .ll_let_bg{
            background-image: url(image/LL_right_bg.jpg);
            background-size: contain;
            width:100%;
            background-size:cover;
            height: 500px;
            margin-left:10px;
        }
          .ll_right_bg{
            background-image: url(image/LL_left_bg.jpg);
            background-size: contain;
            background-size:cover;
            margin-left:20px;
            height: 500px;
           
        }
        #log{
            width:50px;
            height:50px;
        }
        #ilog{
            color:white;
        }
        #p1{
            font-size:45px;
            color:white;
        }
          #p2{
            margin-top:-20px;
            color:red;
        }
            #p3{
           color:white;
        }
            #p1droit{
                margin-top:20px;
                color:white;
                width:500px;
                margin-left:20px;
               
            }
            .btnsign{
                background-color:white;
               border:20px;
               width:150px;
               height:30px;
               background-color:red;
               color:white;
            }
               .btnlogin{
                background-color:white;
                margin-left:80px;
                 border:20px;
                  width:150px;
                  height:30px;
                  color:red;
            }footer{
                 width:100%;
                 background-color:red;
                 height:100px;
                 color:white;
                 margin-top:20px;
             }
             footer p {
                 margin-left:100px;
             }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
        <div class="row">
            <div class="col-sm-4 ll_right_bg">
                <i id="ilog"><img src="image/loglava.png"id="log"/>Lavalife</></i>
                <div>
                <p id="p1">MEET FUN
                  SINGLES!</p>
                    <p id="p2">
                  CALL 1-866-546-5282</p>
                    <p id="p3">
                  CALL • CLICK • CONNECT
                 TRY IT FREE!</p></div>
            </div>
            &nbsp;
            <div class="col-sm-7 ll_let_bg">
            <h2 style="color:white; margin-top:90px;margin-left:160px;">DATING FUN </h2>
               <hr style="background-color:white;"/>
                <p id="p1droit">Lavalife wants to put the excitement back in dating. We match your interests
                  to help you break the ice and give you online dating tips along the 
                    way to make sure you have the best experience possible. Get started today.</p>
                <div style="margin-left:130px;" >
                     <div class="row">
                       <div class="col-sm-2">
                           <p>
                               <asp:Button ID="btnSign" runat="server" Text="SIGN UP" CssClass="btnsign" OnClick="btnSign_Click" /></p>
                       </div> 
                         <div class="col-sm-4">
                             <p>
                                 <asp:Button ID="btnLogin" runat="server" Text="LOGIN" CssClass="btnlogin" OnClick="btnLogin_Click" /></p>

                              </div>
                       </div>
            </div>
        </div>
        </div>
    </div>
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <p>Meet more people, spark more conversations and have more fun!
                    SIGN UP NOW FOR YOUR 7-DAY FREE TRIAL.</p>
                </div>
               
            </div>
        </div>
    </footer>
</form>
</body>
</html>
