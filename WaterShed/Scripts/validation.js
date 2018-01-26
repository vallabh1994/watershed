/**
 * for product.php
 */
 
 function validateaddr(addr)
{
	if(addr=="" || addr.length<5 || addr.length>20)
		{
		   $("#cartspan").html('Enter valid address lengthbethween 5 and 20');
		   return false;
		}
	  return true;
}

function validatemob(mob)
{
	if(mob=="")
		{
		$("#cartspan").html('Enter mob no');
		 return false;
		}
	//alert(mob);
	if(mob.length<10||mob.length>10)
		{
		$("#cartspan").html('Enter valid 10 digit mob no');
		return false;
		}
	  if(allnumeric(mob)==false){

			$("#cartspan").html('Enter valid 10 digit mob no');
			return false;
	  }
	return true;
}


 
function validateletters(str)
{
var letters = /^[a-zA-Z][a-zA-Z\s]*$/;  
if(str.match(letters))  
  {  
   return true;  
  } 
else{
	return false;
}

}

function CheckDecimal(inputtxt)   
{   
var decimal=  /^[-+]?[0-9]+\.[0-9]+$/;   
if(String(inputtxt).match(decimal))   
{   
return true;  
}  
else  
{   
return false;  
}  
} 

function ValidateEmail(mail)   
{  
	var letters=/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
 if (mail.match(letters))  
  {  
    return (true)  
  }  
    alert("You have entered an invalid email address!")  
    return (false)  
}  

function allnumeric(inputtxt)  
{  
   var numbers = /^[0-9]+$/;  
   if(inputtxt.match(numbers))  
   {  
   return true;  
   }  
   else  
   {  
   return false;  
   }
}
