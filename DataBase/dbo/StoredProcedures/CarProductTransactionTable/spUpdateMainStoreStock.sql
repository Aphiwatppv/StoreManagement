CREATE PROCEDURE [dbo].[spUpdateMainStoreStock]
AS
BEGIN
    -- Aggregate sales data from unprocessed transactions
    WITH SalesData AS (
        SELECT 
            ProductId, 
            SUM(SalePrimaryUnit) AS TotalSalePrimaryUnit,
            SUM(SaleSecondaryUnit) AS TotalSaleSecondaryUnit
        FROM [dbo].[CarProductTransactions]
        WHERE IsStockUpdated = 0
        GROUP BY ProductId
    )
    -- Update MainStoreTb stock levels based on aggregated sales data
    UPDATE m
    SET 
        m.RemainingStockPrimaryUnit = m.RemainingStockPrimaryUnit - sd.TotalSalePrimaryUnit,
        m.RemainingStockSecondaryUnit = m.RemainingStockSecondaryUnit - sd.TotalSaleSecondaryUnit
    FROM [dbo].[MainStoreTb] m
    INNER JOIN SalesData sd ON m.ProductId = sd.ProductId;

    -- Mark transactions as processed
    UPDATE [dbo].[CarProductTransactions]
    SET IsStockUpdated = 1
    WHERE IsStockUpdated = 0;
END;