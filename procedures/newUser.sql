create procedure sp_NewUser
	@name varchar(50),
	@pass varchar(50)
as 
IF NOT EXISTS (SELECT * FROM Users 
                WHERE UserName = @name
				and Password = @pass                
				)
begin
	insert into Users(UserName, Password) 
	values(@name, @pass)
end
