-- selecting Patient Row based on Id and returning its values
CREATE PROCEDURE sp_SelectPRowOfId
@ID int
AS
BEGIN
	select PName, 
		PBlood,
		PGender,
		convert(varchar,PBirthDate , 23) as PBirthDate,
		PPhone,
		PCity
	from People where P_ID = @ID And PType = 'P'
END