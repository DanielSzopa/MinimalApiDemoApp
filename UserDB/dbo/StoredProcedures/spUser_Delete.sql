CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
begin
	DELETE
	FROM [dbo].[User]
	Where Id = @Id
end

