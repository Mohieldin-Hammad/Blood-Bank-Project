create procedure sp_checkEmail
	@email varchar(320),
	@Message VARCHAR(250) OUTPUT
as
BEGIN
IF EXISTS (select * from Users where Email = @email)
	begin
	set @Message = 'Succeed';
	end
else 
	begin
	set @Message = 'Failed'
	end
end
