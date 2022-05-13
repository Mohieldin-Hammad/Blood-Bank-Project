-- this procedure is inserting new row to the Patient with specific values
CREATE PROCEDURE sp_InsertPatient
	@PName varchar(50),
	@PGender varchar(50),
	@PBlood varchar(5),
	@PBirthDate date,
	@PPhone varchar(50),
	@PCity VarChar(50)
AS
-- INSERT INTO THE PATIENT NEW ROW IF THIS PATIENT IS NOT EXISTS IN DATA BASE
IF NOT EXISTS (SELECT * FROM People 
                WHERE PName = @PName
                AND PGender = @PGender
                AND PBlood = @PBlood
				AND PBirthDate = @PBirthDate
				AND PPhone = @PPhone
				AND PCity = @PCity
				AND PType = 'P'
				)
BEGIN
    INSERT INTO People
		(PName, PGender, PBlood, PBirthDate, PPhone, PCity, PType) 
	VALUES
		(@PName , @PGender, @PBlood, @PBirthDate, @PPhone, @PCity, 'P')
END

	





-- For example to execute the procedure we can run the following query
--exec sp_InsertPatient 'mohee' , 'M', 'A+', '2002-04-20', '0123456789', 'Mansoura'