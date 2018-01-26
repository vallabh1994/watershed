/**
 * for login button
 */



function showpopup()
{
 $("#loginform").fadeIn();
 $("#loginform").css({"visibility":"visible","display":"block"});
 $("#loginform").load("/biskart/login.php");
}


function hidepopup()
{
 $("#loginform").fadeOut();
 $("#loginform").css({"visibility":"hidden","display":"none"});
}

function dlogin()
{
var uid=$("#uid").val();
var upass=$("#password").val();
$("signin").submit;


	 
if(uid !="")
{
	if(ValidateEmail(uid)==false)
	{
	 $("#loginspan1").html("enter valid mail id");
	 return false;
	}
	if(uid.substr(length-4,4)!='.com'&&uid.substr(length-3,3)!='.in'&&uid.substr(length-3,4)!='.tk')
	{
	 $("#loginspan1").html("enter valid .com .in or .tk ");
	 return false;
	}
	
  	if(upass!="")
		{
		
		$.ajax
		  ({
		  type:'post',
		  url:'/biskart/controller/validate_login.php',
		  data: "uid="+uid+"&upass="+upass,
		 dataType:"text",
		  success:function(response) {
		  if(response=="success")
		  {
			//alert("success");
			  window.location.href=window.location.href;
		  }else{
			  $("#loginspan1").html(response);
			  return ;
		  }
		  },
		  error:function(){
			  alert("wrong details");
		  }
		  });  //ajax ends here 
		
		
		}else{
			$("#loginspan1").html("enter password");
			return;
		}
	
}else{
  $("#loginspan1").html("enter username");
  return ;
}
return;
}

function closelogin() {
	hidepopup();
}

function showreg()
{
 $("#loginform").fadeIn();
 $("#loginform").css({"visibility":"visible","display":"block"});
 $("#loginform").load("/biskart/signup.php");
}

function dsignup() {

	var uid=$("#uid").val();
	var upass=$("#password").val();
	var uname=$("#uname").val();
	var role=$("#role").val();
   // alert(uid+" "+upass+" "+uname+" "+role);
    if(uname=="")
	 {

	$("#signupspan1").html("enter name");
	     return false;
	 }
    if(uname.length<3 ||uname.length>20)
	 {

	$("#signupspan1").html("enter name of length betn 3 and 20");
	     return false;
	 }
    if(validateletters(uname)==false)
    	{
    	$("#signupspan1").html("Only letters");
    	return false;
    	}
    
    if(uid=="")
    	{
    	 $("#signupspan1").html("enter username");
    	 return false;
    	}
    
    if(ValidateEmail(uid)==false)
	{
	 $("#signupspan1").html("enter valid email id as uid");
	 return false;
	}
    if(uid.substr(length-4,4)!='.com'&&uid.substr(length-3,3)!='.in'&&uid.substr(length-3,4)!='.tk')
	{
	 $("#signupspan1").html("enter valid .com .in or .tk ");
	 return false;
	}
    if(upass=="")
    	{
    	$("#signupspan1").html("enter password");
   	     return false;
    	}
    if(upass.length<3)
	{
	$("#signupspan1").html("enter password of min 3 length");
	     return false;
	}
 $("#dologin").submit;
     $.ajax
	  ({
	  type:'post',
	  url:'/biskart/controller/validate_signup.php',
	  data: "uid="+uid+"&upass="+upass+"&uname="+uname+"&role="+role,
	 dataType:"text",
	  success:function(response) {
	  if(response.substr("success"))
	  {
		  alert("account created successfully");
		  window.location.href=window.location.href;
		  
	  }else{
		 alert("fail");
		  $("#loginspan1").css('color','white');
		  $("#loginspan1").html(response);
		 // window.location.href=window.location.href;
		  return ;
	  }
	  },
	  error:function(){
		  alert("wrong details");
	  }
	  });  //ajax ends here 
    
    return false;
}

function editall()
{
	var upass=$("#password").val();
	var uname=$("#uname").val();
	var role=$("#role").val();
   // alert(uid+" "+upass+" "+uname+" "+role);
    if(uname=="")
	 {
	$("#signupspan1").html("enter name");
	     return false;
	 }
    if(uname.length<3 ||uname.length>20)
	 {

	$("#signupspan1").html("enter name of length betn 3 and 20");
	     return false;
	 }
    if(validateletters(uname)==false)
    	{
    	$("#signupspan1").html("Only letters");
    	return false;
    	}
    if(upass=="")
	{
	$("#signupspan1").html("enter password");
	     return false;
	}
if(upass.length<3)
{
$("#signupspan1").html("enter password of min 3 length");
     return false;
} 
$("#editAll").submit;
$.ajax
 ({
 type:'post',
 url:'/biskart/controller/validate_edit.php',
 data: "upass="+upass+"&uname="+uname+"&role="+role,
dataType:"text",
 success:function(response) {
 if(response.substr("success"))
 {
	  alert("account updated successfully");
	  window.location.href=window.location.href;	  
 }else{
	 alert("fail");
	  $("#loginspan1").html(response);
	 window.location.reload();
	  return ;
 }
 },
 error:function(){
	  alert("wrong details");
 }
 });  //ajax ends here 
	
	return;
}


function enterkey(e)
{
	
 if(e.keyCode==13)
 {  
	 $('#dologin').click();
 } 
}