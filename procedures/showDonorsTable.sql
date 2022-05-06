-- select all Donors table 
CREATE PROCEDURE sp_ShowDonorsTable
AS
BEGIN
	select DName as 'Name', 
		DBlood as 'Blood_Type',
		(Case
			WHEN DGender = 'M' THEN 'Male'
            WHEN DGender = 'F' THEN 'Female'
		End) as Gender,
		D_Age as 'Age',
		DPhone as 'Phone',
		DCity as 'City'	
	from Donors
END
