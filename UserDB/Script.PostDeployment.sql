if not exists (select 1 from dbo.[User])
begin
	INSERT INTO [dbo].[User](FirstName,LastName) 
	VALUES('Daniel','Szopa'),
	('Kamil','Zając'),
	('Mateusz','Zając'),
	('Jakub','Zawłocki'),
	('James','Tini'),
	('Michael','Jacks'),
	('Tim','Corey')
end