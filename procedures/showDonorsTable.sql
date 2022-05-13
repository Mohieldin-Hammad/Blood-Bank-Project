-- select all Donors table 
CREATE PROCEDURE sp_ShowDonorsTable
AS
BEGIN
	select P_ID as "ID",
		PName as 'Name', 
		PBlood as 'Blood_Type',
		PGender as Gender,
		P_Age as 'Age',
		PPhone as 'Phone',
		PCity as 'City'	
	from People 
	where PType = 'D'
END