-- This procedure is updating the Patients row with this new values
-- The row is based on Id which will be specified from the table that will 
-- be shown in the windows app interface if available
CREATE PROCEDURE sp_EditPRowOfId
	@ID int,
	@Name varchar(50),
	@Gender varchar(5),
	@Blood varchar(5),
	@BirthDate date,
	@Phone varchar(50),
	@City VarChar(50)
AS
BEGIN

	update Patients set 
		PName = @Name,
		PGender = @Gender,
		PBlood = @Blood,
		PBirthDate = @BirthDate,
		PPhone = @Phone,
		PCity = @City
	Where P_ID = @ID
	
END