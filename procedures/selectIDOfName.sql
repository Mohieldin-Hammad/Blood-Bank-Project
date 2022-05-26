create PROCEDURE [dbo].[sp_SelectIDOfName]
	@Name varchar(50),
	@type varchar(5)
AS
BEGIN
	if (@type = 'D')
	begin
	select P_ID
	from People where PName = @Name and PType = 'D';
	end else if (@type = 'P')
	begin
	select P_ID
	from People where PName = @Name and PType = 'P';
	end else
	begin
	raiserror('NameNotMatched', 16,1)
	end
END