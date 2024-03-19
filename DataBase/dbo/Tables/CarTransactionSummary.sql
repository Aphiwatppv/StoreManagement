CREATE TABLE [dbo].[CarTransactionSummary]
(
    [Id] NVARCHAR(100) NOT NULL PRIMARY KEY, -- Format = CarID + yyyyMMdd
    [CarModel] NVARCHAR(50),
    [TransactionDate] DATE NOT NULL,
    [TotalProduct] INT, -- To be calculated as the count of distinct ProductId for each CarID and TransactionDate
    [CostMoney] DECIMAL(18,2), -- Calculated as (SalePrimaryUnit * CostPricePrimaryUnit) + (SaleSecondaryUnit * CostPriceSecondaryUnit)
    [ActualMoney] DECIMAL(18,2), -- Calculated as (SalePrimaryUnit * PricePrimaryUnit) + (SaleSecondaryUnit * PriceSecondaryUnit)
    [MoneyFromCar] DECIMAL(18,2) DEFAULT 0, -- Placeholder for manual entry
    [DifferenceMoney] AS ([MoneyFromCar]-[ActualMoney]) -- Calculated column
 
);
