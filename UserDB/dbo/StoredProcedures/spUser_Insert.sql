CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName varchar(50),
	@LastName varchar(50)
AS
BEGIN
	INSERT INTO [dbo].[User](FirstName,LastName) 
	VALUES(@FirstName,@LastName)
END
