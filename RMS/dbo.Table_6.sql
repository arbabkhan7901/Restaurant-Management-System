CREATE TABLE [dbo].[customer]
(
	[cust_id] INT NOT NULL PRIMARY KEY, 
    [cust_name] VARCHAR(50) NOT NULL, 
    [phNo] VARCHAR(50) NOT NULL, 
    [cust_pswd] NCHAR(10) NOT NULL
)
