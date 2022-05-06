-- This procedure is updating the Doners row with this new values
-- The row is based on Id which will be specified from the table that will 
-- be shown in the windows app interface if available
CREATE PROCEDURE sp_EditDRowOfId
	@ID int,
	@Name varchar(50),
	@Gender varchar(5),
	@Blood varchar(5),
	@BirthDate date,
	@Phone varchar(50),
	@City VarChar(50)
AS
BEGIN

	update Donors set 
		DName = @Name,
		DGender = @Gender,
		DBlood = @Blood,
		DBirthDate = @BirthDate,
		DPhone = @Phone,
		DCity = @City
	Where D_ID = @ID
	
END