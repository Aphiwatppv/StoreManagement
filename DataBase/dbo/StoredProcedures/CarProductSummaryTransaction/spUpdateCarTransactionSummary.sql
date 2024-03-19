CREATE PROCEDURE [dbo].[spUpdateCarTransactionSummary]
AS
BEGIN
    -- Attempt to update existing summaries
    UPDATE s
    SET
        s.TotalProduct = agg.TotalProduct,
        s.CostMoney = agg.CostMoney,
        s.ActualMoney = agg.ActualMoney
    FROM [dbo].[CarTransactionSummary] s
    INNER JOIN (
        SELECT
            CONCAT(t.CarID, FORMAT(t.TransactionDate, 'yyyyMMdd')) AS Id,
            COUNT(DISTINCT t.ProductId) AS TotalProduct,
            SUM(t.SalePrimaryUnit * t.CostPricePrimaryUnit + t.SaleSecondaryUnit * t.CostPriceSecondaryUnit) AS CostMoney,
            SUM(t.SalePrimaryUnit * t.PricePrimaryUnit + t.SaleSecondaryUnit * t.PriceSecondaryUnit) AS ActualMoney,
            t.TransactionDate
        FROM [dbo].[CarProductTransactions] t
        GROUP BY t.CarID, t.TransactionDate
    ) AS agg ON s.Id = agg.Id

    -- Insert new summaries for which no existing summary was found
    INSERT INTO [dbo].[CarTransactionSummary] (Id, CarModel, TransactionDate, TotalProduct, CostMoney, ActualMoney, MoneyFromCar)
    SELECT
        agg.Id,
        c.Model,
        agg.TransactionDate,
        agg.TotalProduct,
        agg.CostMoney,
        agg.ActualMoney,
        0 -- Initial value for MoneyFromCar
    FROM (
        SELECT
            CONCAT(t.CarID, FORMAT(t.TransactionDate, 'yyyyMMdd')) AS Id,
            t.CarID,
            COUNT(DISTINCT t.ProductId) AS TotalProduct,
            SUM(t.SalePrimaryUnit * t.CostPricePrimaryUnit + t.SaleSecondaryUnit * t.CostPriceSecondaryUnit) AS CostMoney,
            SUM(t.SalePrimaryUnit * t.PricePrimaryUnit + t.SaleSecondaryUnit * t.PriceSecondaryUnit) AS ActualMoney,
            t.TransactionDate
        FROM [dbo].[CarProductTransactions] t
        GROUP BY t.CarID, t.TransactionDate
    ) AS agg
    INNER JOIN [dbo].[Cars] c ON agg.CarID = c.CarID
    WHERE NOT EXISTS (
        SELECT 1 FROM [dbo].[CarTransactionSummary] s WHERE s.Id = agg.Id
    )
END;
