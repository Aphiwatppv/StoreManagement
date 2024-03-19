CREATE TABLE [dbo].[StockHistoryTb]
(

    [HistoryId] NVARCHAR(50) NOT NULL PRIMARY KEY,  
    [ProductId] INT NOT NULL,
    [ChangeType] NVARCHAR(50) NOT NULL, 
    [QuantityChanged] DECIMAL(10,2) NULL,
    [Unit] NVARCHAR(50) NULL, 
    [NewQuantity] DECIMAL(10,2) NULL,
    [Reason] NVARCHAR(MAX) NULL, 
    [DateChanged] DATETIME NOT NULL DEFAULT(GETDATE()),
    FOREIGN KEY (ProductId) REFERENCES [dbo].[MainStoreTb](ProductId)
)
