CREATE TABLE [dbo].[MainStoreTb]
(
    [ProductId]  INT NOT NULL PRIMARY KEY,
    [ProductName] NVARCHAR(255) NOT NULL,
    [RemainingStockPrimaryUnit] DECIMAL(10,2) NOT NULL,
    [PrimaryUnit] NVARCHAR(50) NOT NULL,
    [RemainingStockSecondaryUnit] DECIMAL(10,2) NOT NULL,
    [SecondaryUnit] NVARCHAR(50) NOT NULL,
    [RelationUnit] DECIMAL(10,2) NULL,
    [CostPricePrimaryUnit] DECIMAL(13,2) NULL,
    [PricePrimaryUnit] DECIMAL(13,2) NULL,
    [CostPriceSecondaryUnit] DECIMAL(13,2) NULL, 
    [PriceSecondaryUnit] DECIMAL(13,2) NULL,
    [UnitPrice] NVARCHAR(50) NOT NULL
)
