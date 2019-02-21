CREATE TABLE [dbo].[Deal]
(
	[deal_name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [deal_price] INT NOT NULL, 
    [deal_date] DATE NOT NULL, 
    [itemNo] INT NOT NULL, 
    CONSTRAINT [FK_Deal_menu] FOREIGN KEY ([itemNo]) REFERENCES [menu]([itemNo])
)
