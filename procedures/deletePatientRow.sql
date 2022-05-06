-- this procedure is deleting the row with these columns values
CREATE PROCEDURE sp_DeletePatientRow
	@Name varchar(50),
	@Gender varchar(5),
	@Blood varchar(5),
	@Age int,
	@Phone varchar(50),
	@City VarChar(50)
AS
BEGIN
	delete from Patients
		where PName = @Name
		and PGender = @Gender
		and PBlood = @Blood
		and P_Age = @Age
		and PPhone = @Phone
		and PCity = @City
END