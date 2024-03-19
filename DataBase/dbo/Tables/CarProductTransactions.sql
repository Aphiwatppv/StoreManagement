CREATE TABLE [dbo].[CarProductTransactions]
(
    [Id] NVARCHAR(100) NOT NULL, --format = carID + yyyyMMdd 
    [TransactionId] NVARCHAR(250) PRIMARY KEY,  --format = carID + yyyyMMdd + ProductID
    [CarID] NVARCHAR(50),
    [ProductId] INT, 
    [TakeQuantityPrimaryUnit] DECIMAL(10,2) NULL,
    [TakeQuantitySecondaryUnit] DECIMAL(10,2) NULL,
    [ReturnQuantityPrimaryUnit] DECIMAL(10,2) NULL,
    [ReturnQuantitySecondaryUnit] DECIMAL(10,2) NULL,
    [SalePrimaryUnit] DECIMAL(10,2) NULL, -- take quantity - return unit
    [SaleSecondaryUnit] DECIMAL(10,2) NULL,-- take quantity - return unit
    [TransactionDate] DATE NOT NULL,
    [CostPricePrimaryUnit] DECIMAL(13,2) NULL,
    [PricePrimaryUnit] DECIMAL(13,2) NULL,
    [CostPriceSecondaryUnit] DECIMAL(13,2) NULL, 
    [PriceSecondaryUnit] DECIMAL(13,2) NULL,
    [IsStockUpdated] BIT NOT NULL DEFAULT 0

);