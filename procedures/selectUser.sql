create procedure sp_SelectUser
	@name varchar(50),
	@pass varchar(50)
as 
begin
	select * from Users where UserName = @name
		and Password = @pass;
end