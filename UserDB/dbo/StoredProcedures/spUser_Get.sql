CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
As
begin
	SELECT 
		Id,FirstName,LastName 
			FROM dbo.[User]
				Where Id = @Id
end