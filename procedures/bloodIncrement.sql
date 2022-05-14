-- This procedure is taking the blood type and increase the Bcounts of this type
CREATE PROCEDURE sp_BloodIncrement
	@BloodType varchar(5)
AS
BEGIN
	
BEGIN TRY  
     update Bloods set BCounts = BCounts + 1
		where BGroup = @BloodType;
END TRY  

BEGIN CATCH  
     raiserror('FAILED', 1, 1)
END CATCH  
;
END