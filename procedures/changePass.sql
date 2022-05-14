create procedure sp_ChangePassword
	@name varchar(50),
	@newPass varchar(50)
as 
begin
	update Users set 
	Password = @newPass
	where UserName = @name
end