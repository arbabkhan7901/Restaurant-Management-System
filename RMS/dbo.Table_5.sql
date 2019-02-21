CREATE TABLE [dbo].[Receptionist]
(
	[recep_Id] INT NOT NULL PRIMARY KEY, 
    [recep_name] VARCHAR(50) NOT NULL, 
    [recep_email] VARCHAR(50) NOT NULL, 
    [recep_pswd] NCHAR(10) NOT NULL
)
