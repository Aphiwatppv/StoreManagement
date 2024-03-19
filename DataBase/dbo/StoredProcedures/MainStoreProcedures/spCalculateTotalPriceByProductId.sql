CREATE PROCEDURE [dbo].[spCalculateTotalPriceByProductId]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate the total price for a specific product
    SELECT [ProductId], [ProductName], [RemainingStockPrimaryUnit] * [PricePrimaryUnit] AS TotalPrice
    FROM [dbo].[MainStoreTb]
    WHERE [ProductId] = @ProductId;
END
GO
