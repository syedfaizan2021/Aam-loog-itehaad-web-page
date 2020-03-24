Create procedure [dbo].[AddMemberFun]  
(  
	@memberName varchar(50) ,
	@fatherName varchar(50) ,
	@CNIC varchar(100) ,
	@streetAddress varchar(100) ,
	@province varchar(50) ,
	@division varchar(50) ,
	@district varchar(50) ,
	@city varchar(50) ,
	@tehsil varchar(50) ,
	@unionCouncil varchar(50) ,
	@mailingAddress varchar(50) ,
	@mobileNumbar varchar(50) ,
	@emailAddress varchar(50) ,
	@photo varchar(50) 
)  
as  
begin  
   Insert into Addmember values(@memberName  ,
	@fatherName  ,
	@CNIC  ,
	@streetAddress  ,
	@province  ,
	@division  ,
	@district  ,
	@city  ,
	@tehsil  ,
	@unionCouncil  ,
	@mailingAddress ,
	@mobileNumbar ,
	@emailAddress,
	@photo)  
End