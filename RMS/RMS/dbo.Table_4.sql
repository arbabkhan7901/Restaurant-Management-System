CREATE TABLE [dbo].[invoice]
(
	[invo_no] INT NOT NULL PRIMARY KEY, 
    [cust_id] INT NOT NULL, 
    [ord_no] INT NOT NULL, 
    [invo_date] DATE NOT NULL, 
    [deal_name] VARCHAR(50) NOT NULL, 
    [noOfDeals] INT NOT NULL, 
    [amount] INT NOT NULL, 
    CONSTRAINT [FK_invoice_customer] FOREIGN KEY ([cust_id]) REFERENCES [customer]([cust_id]), 
    CONSTRAINT [FK_invoice_Order] FOREIGN KEY ([ord_no]) REFERENCES [order]([ord_no]), 
    CONSTRAINT [FK_invoice_deal] FOREIGN KEY ([deal_name]) REFERENCES [deal]([deal_name])
)
