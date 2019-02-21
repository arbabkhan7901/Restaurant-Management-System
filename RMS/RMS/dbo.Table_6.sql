CREATE TABLE [dbo].[Order]
(
	[ord_No] INT NOT NULL PRIMARY KEY, 
    [itemNo] INT NOT NULL, 
    [noOfItems] INT NOT NULL, 
    CONSTRAINT [FK_Order_itemNo] FOREIGN KEY ([itemNo]) REFERENCES [menu]([itemNo])
)
