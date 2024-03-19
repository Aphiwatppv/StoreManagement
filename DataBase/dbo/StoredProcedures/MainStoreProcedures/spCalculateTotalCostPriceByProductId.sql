CREATE PROCEDURE [dbo].[spCalculateTotalCostPriceByProductId]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [ProductId], [ProductName], [RemainingStockPrimaryUnit] * [CostPricePrimaryUnit] AS TotalCostPrice
    FROM [dbo].[MainStoreTb]
    WHERE [ProductId] = @ProductId;
END
GO
