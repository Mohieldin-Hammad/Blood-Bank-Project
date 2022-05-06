-- returning Patient Name and Blood type
CREATE PROCEDURE sp_GetPatientOfId
	@ID int
AS
BEGIN
	select PName, PBlood
	from Patients
	where P_ID = @ID
END