-- select all Patients table
CREATE PROCEDURE sp_ShowPatientsTable
AS
BEGIN
	select PName as 'Name', 
		PBlood as 'Blood_Type',
		(Case
			WHEN PGender = 'M' THEN 'Male'
            WHEN PGender = 'F' THEN 'Female'
		End) as Gender,
		P_Age as 'Age',
		PPhone as 'Phone',
		PCity as 'City'	
	from Patients
END