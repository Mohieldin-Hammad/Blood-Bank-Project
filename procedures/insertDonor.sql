-- This procedure is inserting new row to the donor with specific values
CREATE PROCEDURE sp_InsertDonor
	@DName varchar(50),
	@DGender varchar(5),
	@DBlood varchar(5),
	@DBirthDate date,
	@DPhone varchar(50),
	@DCity VarChar(50)
AS
-- INSERT INTO THE DONOR NEW ROW IF THIS DONOR IS NOT EXISTS IN DATA BASE
IF NOT EXISTS (SELECT * FROM Donors 
                WHERE DName = @DName
                AND DGender = @DGender
                AND DBlood = @DBlood
				AND DBirthDate = @DBirthDate
				AND DPhone = @DPhone
				AND DCity = @DCity
				)
BEGIN
    INSERT INTO Donors
		(DName, DGender, DBlood, DBirthDate, DPhone, DCity) 
	VALUES
		(@DName , @DGender, @DBlood, @DBirthDate, @DPhone, @DCity)
END




-- For example to execute the procedure we can run the following query
--exec sp_InsertDonor 'mohee' , 'M', 'A+', '2002-04-20', '0123456789', 'Mansoura'