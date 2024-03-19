CREATE PROCEDURE [dbo].[spCreateEmptyCarProductTransactionForm]
    @CarID NVARCHAR(50)
AS
BEGIN
    SELECT
        CONCAT(@CarID, FORMAT(GETDATE(), 'yyyyMMdd'), p.ProductId) AS TransactionId,
        p.ProductName,
        p.PrimaryUnit,
        p.SecondaryUnit,
        0 AS TakeQuantityPrimaryUnit,
        0 AS ReturnQuantityPrimaryUnit,
        0 AS TakeQuantitySecondaryUnit,
        0 AS ReturnQuantitySecondaryUnit,
        0 AS SalePrimaryUnit,
        0 AS SaleSecondaryUnit,
        p.CostPricePrimaryUnit,
        p.PricePrimaryUnit ,
        p.CostPriceSecondaryUnit,
        p.PriceSecondaryUnit
 
    FROM [dbo].[MainStoreTb] p
END;
