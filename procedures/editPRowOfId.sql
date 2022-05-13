-- This procedure is updating the Patients row with this new values
-- The row is based on Id which will be specified from the table that will 
-- be shown in the windows app interface if available
CREATE PROCEDURE sp_EditPRowOfId
	@ID int,
	@Name varchar(50),
	@Gender varchar(50),
	@Blood varchar(5),
	@BirthDate date,
	@Phone varchar(50),
	@City VarChar(50)
AS
IF NOT EXISTS (SELECT * FROM People 
                WHERE P_ID = @ID
				AND PName = @Name
                AND PGender = @Gender
                AND PBlood = @Blood
				AND PBirthDate = @BirthDate
				AND PPhone = @Phone
				AND PCity = @City
				AND PType = 'P'
				)
BEGIN

	update People set 
		PName = @Name,
		PGender = @Gender,
		PBlood = @Blood,
		PBirthDate = @BirthDate,
		PPhone = @Phone,
		PCity = @City
	Where P_ID = @ID and PType = 'P'
	
END