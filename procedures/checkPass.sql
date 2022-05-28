create procedure sp_checkPassword
	@email varchar(320),
	@pass binary(64),
	@Message VARCHAR(250) OUTPUT
as
BEGIN
IF EXISTS (select * from Users where Email = @email)
	begin
	if ((select top 1 Password from Users where Email = @email) = HASHBYTES('SHA2_512', @Pass))
		begin
		set @Message = 'Succeed';
		end
	else
		begin
		set @Message = 'Failed';
		end
	end
else 
	begin
	set @Message = 'EmailNotExists'
	end
end