create procedure sp_ChangeUserName
	@old_Name varchar(50),
	@new_Name varchar(50)
as 
begin
	update Users set 
	UserName = @new_Name
	where UserName = @old_Name
end