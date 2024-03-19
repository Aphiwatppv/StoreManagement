CREATE PROCEDURE [dbo].[spSearchProductById]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [ProductId],
        [ProductName],
        [RemainingStockPrimaryUnit],
        [PrimaryUnit],
        [RemainingStockSecondaryUnit],
        [SecondaryUnit],
        [RelationUnit],
        [CostPricePrimaryUnit],
        [PricePrimaryUnit],
        [CostPriceSecondaryUnit],
        [PriceSecondaryUnit],
        [UnitPrice]
    FROM [dbo].[MainStoreTb]
    WHERE [ProductId] = @ProductId;
END
GO
