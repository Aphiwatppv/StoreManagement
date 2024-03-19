CREATE PROCEDURE [dbo].[spGenerateCarTransactionSummary]
AS
BEGIN
    -- Temporarily storing aggregated data
    ;WITH AggregatedData AS (
        SELECT
            c.CarID,
            c.Model AS CarModel,
            t.TransactionDate,
            COUNT(DISTINCT t.ProductId) AS TotalProduct,
            SUM(t.SalePrimaryUnit * t.CostPricePrimaryUnit + t.SaleSecondaryUnit * t.CostPriceSecondaryUnit) AS CostMoney,
            SUM(t.SalePrimaryUnit * t.PricePrimaryUnit + t.SaleSecondaryUnit * t.PriceSecondaryUnit) AS ActualMoney
        FROM [dbo].[CarProductTransactions] t
        JOIN [dbo].[Cars] c ON t.CarID = c.CarID
        GROUP BY c.CarID, c.Model, t.TransactionDate
    )
    INSERT INTO [dbo].[CarTransactionSummary] (Id, CarModel, TransactionDate, TotalProduct, CostMoney, ActualMoney, MoneyFromCar)
    SELECT
        CONCAT(AD.CarID, REPLACE(CONVERT(NVARCHAR, AD.TransactionDate, 112), '-', '')) AS Id,
        AD.CarModel,
        AD.TransactionDate,
        AD.TotalProduct,
        AD.CostMoney,
        AD.ActualMoney,
        0 -- Initial value for MoneyFromCar, to be updated manually
    FROM AggregatedData AD
    -- Optionally add a check to prevent duplicate entries for the same Id
    WHERE NOT EXISTS (
        SELECT 1 FROM [dbo].[CarTransactionSummary] 
        WHERE Id = CONCAT(AD.CarID, REPLACE(CONVERT(NVARCHAR, AD.TransactionDate, 112), '-', ''))
    );
END
