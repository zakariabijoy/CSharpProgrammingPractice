CREATE VIEW [dbo].[FullPerson]
	AS
	SELECT  [p].[FirstName], [p].[LastName], [a].[Id] as AddressId,  [a].[City], [a].[StreeAddress], [a].[ZipCode]
	from dbo.Person p
	left join dbo.Address a
	on  p.PersonId = a.PersonId