CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FirstName varchar(50),
	@LastName varchar(50)
AS
Begin
	Update [dbo].[User] Set FirstName = @FirstName, LastName = @LastName 
		Where Id = @Id
End
