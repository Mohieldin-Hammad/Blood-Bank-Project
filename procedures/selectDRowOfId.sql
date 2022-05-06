-- selecting Donors row based on ID and returning its values
CREATE PROCEDURE sp_SelectDRowOfId
@ID int
AS
BEGIN
	select DName, 
		DBlood,
		PGender = Case
			WHEN DGender = 'M' THEN 'Male'
            WHEN DGender = 'F' THEN 'Female'
		End,
		DBirthDate,
		DPhone,
		DCity	
	from Donors where D_ID = @ID 
END