CREATE TABLE [dbo].[Reservation]
(
	[tableNo] INT NOT NULL PRIMARY KEY, 
    [noOfChairs] INT NOT NULL, 
    [res_date] DATE NOT NULL, 
    [cust_id] INT NOT NULL, 
    CONSTRAINT [FK_Reservation_customer] FOREIGN KEY ([cust_id]) REFERENCES [customer]([cust_id])
)
