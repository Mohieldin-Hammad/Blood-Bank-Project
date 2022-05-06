-- This procedure is taking the blood type and increase the Bcounts of this type
CREATE PROCEDURE sp_BloodIncrement
	@BloodType varchar(5)
AS
BEGIN
	update Bloods set BCounts = BCounts + 1
		where BGroup = @BloodType
END