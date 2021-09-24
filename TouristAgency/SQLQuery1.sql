create proc UPDATE_COUNTRY
	@OldName VARCHAR(100),
	@NewName VARCHAR(100)
as
begin
UPDATE Countries
set [Name] = @NewName
where @OldName = [Name]
end