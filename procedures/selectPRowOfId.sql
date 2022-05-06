-- selecting Patient Row based on Id and returning its values
CREATE PROCEDURE sp_SelectPRowOfId
@ID int
AS
BEGIN
	select PName, 
		PBlood,
		PGender = Case
			WHEN PGender = 'M' THEN 'Male'
            WHEN PGender = 'F' THEN 'Female'
		End,
		PBirthDate,
		PPhone,
		PCity	
	from Patients where P_ID = @ID 
END