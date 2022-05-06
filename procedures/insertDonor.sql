-- This procedure is inserting new row to the donor with specific values
CREATE PROCEDURE sp_InsertDonor
	@DName varchar(50),
	@DGender varchar(5),
	@DBlood varchar(5),
	@DBirthDate date,
	@DPhone varchar(50),
	@DCity VarChar(50)
AS
BEGIN
	insert into Donors
		(DName, DGender, DBlood, DBirthDate, DPhone, DCity, DDonationDate) 
	values
		(@DName , @DGender, @DBlood, @DBirthDate, @DPhone, @DCity, getdate())
END




-- For example to execute the procedure we can run the following query
--exec sp_InsertDonor 'mohee' , 'M', 'A+', '2002-04-20', '0123456789', 'Mansoura'