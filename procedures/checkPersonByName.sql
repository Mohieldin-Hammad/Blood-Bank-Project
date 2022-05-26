CREATE PROCEDURE sp_CheckPersonByName
	@PName varchar(50),
	@PType varchar(5)
AS

IF EXISTS (SELECT * FROM People 
                WHERE PName = @PName
				AND PType = @PType
				)
BEGIN
    select 'FOUND';
END

ELSE
BEGIN
	SELECT 'NOTFOUND';
END