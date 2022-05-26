CREATE PROCEDURE sp_SelectAllPeopleId
	@type varchar(5)
AS
BEGIN
	if (@type = 'D')
	begin
	select P_ID
	from People where PType = 'D';
	end else if (@type = 'P')
	begin
	select P_ID
	from People where PType = 'P';
	end else
	begin
	raiserror('TypeNotMatched', 16,1)
	end
END