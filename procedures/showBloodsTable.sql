-- select all the Blood table
CREATE PROCEDURE sp_ShowBloodsTable
AS
BEGIN
	select BGroup as 'Blood Group', 
	BCounts as 'Blood Stock'
	from Bloods
END