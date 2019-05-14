Create Table MemberTable
(
MemberId int identity(1,1) primary key,
UserName varchar(100),
Name varchar(100),
Password varchar(100),
Role varchar(100),
Address varchar(100),
Email varchar(100),
Gender varchar (100),
Contact numeric(15),
DOB date,
DOJ date,
Image image
)

Create Procedure SP_ManageMembers
(
@MemberId int,
@UserName varchar(100),
@Name varchar(100),
@Password varchar(100),
@Role varchar(100),
@Address varchar(100),
@Email varchar(100),
@Gender varchar (100),
@Contact numeric(15),
@DOB date,
@DOJ date,
@Image image,
@Mode int
)
as
begin
if(@Mode=1)
insert into MemberTable(UserName,Name,Password,Role,Address,Email,Gender,Contact,DOB,DOJ,Image) values (@UserName,@Name,@Password,@Role,@Address,@Email,@Gender,@Contact,@DOB,@DOJ,@Image)
if (@Mode=2)
Update MemberTable set UserName=@UserName,Name=@Name, Password=@Password,Role=@Role,Address=@Address,Email=@Email,
Gender=@Gender,Contact=@Contact,DOB=@DOB,DOJ=@DOJ,Image=@Image
where MemberId=@MemberId
if(@Mode=3)
Delete from MemberTable where MemberId=@MemberId
end