CREATE PROCEDURE [dbo].[spGetTransactionDataById]
    @Id NVARCHAR(100)
AS
BEGIN
    SELECT
        c.TransactionId,
        m.ProductName,
        m.PrimaryUnit,
        m.SecondaryUnit,
        c.TakeQuantityPrimaryUnit,
        c.ReturnQuantityPrimaryUnit,
        c.TakeQuantitySecondaryUnit,
        c.ReturnQuantitySecondaryUnit,
        c.SalePrimaryUnit,
        c.SaleSecondaryUnit,
        m.CostPricePrimaryUnit,
        m.PricePrimaryUnit,
        m.CostPriceSecondaryUnit,
        m.PriceSecondaryUnit
    FROM [dbo].[CarProductTransactions] c
    JOIN [dbo].[MainStoreTb] m ON c.ProductId = m.ProductId
    WHERE c.Id = @Id
    ORDER BY c.TransactionId
END;