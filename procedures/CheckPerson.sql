CREATE PROCEDURE sp_CheckPerson
	@ID int,
	@PType varchar(5)
AS

IF EXISTS (SELECT * FROM People 
                WHERE P_ID = @ID
				AND PType = @PType
				)
BEGIN
    select 'FOUND';
END

ELSE
BEGIN
	SELECT 'NOTFOUND';
END