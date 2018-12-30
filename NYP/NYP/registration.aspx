﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="NYP.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link href="https://fonts.googleapis.com/css?family=Roboto:400,700" rel="stylesheet"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<style type="text/css">
	#body{
		color: #fff;
		background: #3598dc;
		font-family: 'Roboto', sans-serif;
	}
    .form-control{
		height: 41px;
		background: #f2f2f2;
		box-shadow: none !important;
		border: none;
	}
	.form-control:focus{
		background: #e2e2e2;
	}
    .form-control, .btn{        
        border-radius: 3px;
    }
	.signup-form{
		width: 390px;
		margin: 30px auto;
	}
	.signup-form form{
		color: #999;
		border-radius: 3px;
    	margin-bottom: 15px;
        background: #fff;
        box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        padding: 30px;
    }
	.signup-form h2 {
		color: #333;
		font-weight: bold;
        margin-top: 0;
    }
    .signup-form hr {
        margin: 0 -30px 20px;
    }    
	.signup-form .form-group{
		margin-bottom: 20px;
	}
	.signup-form input[type="checkbox"]{
		margin-top: 3px;
	}
	.signup-form .row div:first-child{
		padding-right: 10px;
	}
	.signup-form .row div:last-child{
		padding-left: 10px;
	}
    .signup-form .btn{        
        font-size: 16px;
        font-weight: bold;
		background: #3598dc;
		border: none;
		min-width: 140px;
    }
	.signup-form .btn:hover, .signup-form .btn:focus{
		background: #2389cd !important;
        outline: none;
	}
    .signup-form a{
		color: grey;
		text-decoration: underline;
	}
	.signup-form a:hover{
		text-decoration: none;
	}
	.signup-form form a{
		color: #3598dc;
		text-decoration: none;
	}	
	.signup-form form a:hover{
		text-decoration: underline;
	}
    .signup-form .hint-text {
		padding-bottom: 15px;
		text-align: center;
    }
</style>

    <title>NYP - Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="signup-form">
		<h2>
            <img src="images/nyplogo.jpg" style="width:auto;height:80px"/>
           </h2>
		<p>Please fill in this form to Register</p>
		<hr/>
        <div class="form-group">
			<div class="row">
				<div class="col-xs-6"><asp:TextBox ID="FnameTxt" class="form-control" name="first_name" placeholder="First Name" required="required" runat="server"></asp:TextBox></div>
				<div class="col-xs-6"><asp:TextBox ID="LnameTxt" class="form-control" name="last_name" placeholder="Last Name" required="required" runat="server"></asp:TextBox></div>
			</div>        	
        </div>
        <div class="form-group">
            <asp:TextBox ID="Email" type="email" class="form-control" name="email" placeholder="Email" required="required" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:TextBox class="form-control" name="mobile" placeholder="Mobile" required="required" ID="MobileNumber" runat="server"></asp:TextBox>
        </div>
		<div class="form-group">
            <asp:TextBox runat="server" class="form-control" name="password" placeholder="Password" required="required" ID="Password" TextMode="Password"
                
                data-toggle="popover" title="Password must meet the following requirements:" 
                                data-html="true"
                                data-container="body"
                                data-trigger="hover"
                                data-content="<img src='https://i.imgur.com/GXVopEj.png?1' height='' width='''>"></asp:TextBox>
        </div>
		<div class="form-group">
            <asp:TextBox runat="server" class="form-control" name="confirm_password" placeholder="Confirm password" required="required" ID="ConfirmPassword" TextMode="Password"
                
                data-toggle="popover" title="Password must meet the following requirements:" 
                                data-html="true"
                                data-container="body"
                                data-trigger="hover"
                                data-content="<img src='https://i.imgur.com/GXVopEj.png?1' height='' width='''>"></asp:TextBox>
            <asp:CompareValidator id="comparePasswords" 
              style="color:#cc0000"
              runat="server"
              ControlToCompare="Password"
              ControlToValidate="ConfirmPassword"
              ErrorMessage="Your passwords do not match up!"
              Display="Dynamic" />
        </div>        
        <div class="form-group">
			<label class="checkbox-inline"><input type="checkbox" required="required"/> I accept the <a href="#">Terms of Use</a> &amp; <a href="#">Privacy Policy</a></label>
		</div>
		<div class="form-group">
            <asp:Button ID="Register" class="btn btn-primary btn-lg" runat="server" Text="Sign Up"  />
        </div>
	<div class="hint-text">Already have an account? <a href="login.aspx"/>Login here</div>
</div>


                            <script>
                        $(document).ready(function(){
                            $('[data-toggle="popover"]').popover();   
                        });
                        </script>
    </div>
    </form>
</body>
</html>