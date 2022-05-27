CREATE PROCEDURE sp_AddUser
    @PUserName VARCHAR(50), 
    @PEmail VARCHAR(320), 
    @PPass VARCHAR(64), 
    @PGender VARCHAR(50),
    @PBirthDate date,
	@responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO Users (UserName, Email, Password, Gender, BirthDate)
        VALUES(@PUserName, 
		@PEmail, 
		HASHBYTES('SHA2_512', @PPass), 
		@PGender, 
		@PBirthDate)

        SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END