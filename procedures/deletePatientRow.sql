-- this procedure is deleting the row with these columns values
CREATE PROCEDURE sp_DeletePatientRow
	@ID int,
	@Name varchar(50),
	@Gender varchar(5),
	@Blood varchar(5),
	@BirthDate date,
	@Phone varchar(50),
	@City VarChar(50)
AS
IF EXISTS (SELECT * FROM People 
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
	delete from People
		where P_ID = @ID
		and PName = @Name
		and PGender = @Gender
		and PBlood = @Blood
		and PBirthDate = @BirthDate
		and PPhone = @Phone
		and PCity = @City
		and PType = 'P'
END
else 
begin
THROW 50005, N'Patient is not in the DataBase', 1;
end