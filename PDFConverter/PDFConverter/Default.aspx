<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DocumentConverter._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PDF Converter - Convert Documents to PDF using Groupdocs .Net PDF Library </title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>

     
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="//jqueryui.com/jquery-wp-content/themes/jqueryui.com/style.css" />
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" type="text/css" />

   <style type="text/css">
       .vertical-center {
                          min-height: 50%;  /* Fallback for browsers do NOT support vh unit */
                          min-height: 50vh; /* These two lines are counted as one :-)     */  
                          display: flex;
                          align-items: center;
                        }

   </style>
  
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <table width="100%" style="text-align:center">
           
            <tr>
                <td>
                    <div style="padding: 20px 20px 20px 20px;">
                        <div class="panel panel-default" style="width: 95%">
                            <div class="panel-heading">
                                <h3>Documents to PDF Converter Using Groupdocs</h3>
                            </div>
                            <div class="panel-body">
                              
                             <asp:Label ID="lblConvStatus" runat="server" Text="" class="alert alert-success" Visible="false"></asp:Label>
                             <asp:Label ID="lblWrongFormat" runat="server" Text="" class="alert alert-danger" Visible="false"></asp:Label>

                              <div class="container">
                                   <div class="row">
                                     <div class="col-xs-5">
                                         <h4>Source Files</h4>
                                         </div>

                                      <div class="col-xs-2">
                                         </div>

                                      <div class="col-xs-5">
                                          <h4>Target Files</h4>
                                         </div>
                                     </div>

                                 <div class="row">
                                     <div class="col-xs-5">
                                          <asp:ListBox ID="lstSourceFiles" runat="server" class="form-control" size="13" Height="350px"></asp:ListBox>
               
                                         </div>
                                     <div class="col-xs-2 vertical-center">
                                       <asp:Button ID="btnConvertAll" runat="server" Text="Convert" class="btn btn-primary btn-block" 
                                           OnClick="btnConvertAll_Click" />
                                       </div>
                                     <div class="col-xs-5">

                                          <asp:ListBox ID="lstTargetFiles" runat="server" class="form-control" size="13" Height="350px"></asp:ListBox>
           
                                         </div>

                                   </div>

                           </div>
                                
                                
                                 </div>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
   </ContentTemplate>
        </asp:UpdatePanel>
        
         </form>
</body>
</html>
