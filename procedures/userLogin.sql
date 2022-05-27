CREATE PROCEDURE sp_Login
    @PEmail VARCHAR(320),
    @PPass VARCHAR(50),
    @responseMessage VARCHAR(250)='' OUTPUT
AS
BEGIN

    SET NOCOUNT ON

    DECLARE @userID INT

    IF EXISTS (SELECT TOP 1 ID FROM Users WHERE Email=@PEmail)
    BEGIN
        SET @userID=(SELECT ID FROM Users WHERE Email=@PEmail AND Password=HASHBYTES('SHA2_512', @PPass))

       IF(@userID IS NULL)
           SET @responseMessage='IncorrectPassword'
       ELSE 
           SET @responseMessage='Succeed'
    END
    ELSE
       SET @responseMessage='Failed'

END