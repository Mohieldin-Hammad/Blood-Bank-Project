-- selecting Donors row based on ID and returning its values
CREATE PROCEDURE sp_SelectDRowOfId
@ID int
AS
BEGIN
	select PName, 
		PBlood,
		PGender,
		convert(varchar,PBirthDate , 23) as PBirthDate,
		PPhone,
		PCity
	from People where P_ID = @ID And PType = 'D'
END