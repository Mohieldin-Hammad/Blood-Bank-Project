-- This procedure is taking the blood type and decrease the Bcounts of this type
CREATE PROCEDURE sp_BloodDecrement
	@BloodType varchar(5)
AS
BEGIN
	update Bloods set BCounts = BCounts - 1
		where BGroup = @BloodType
END