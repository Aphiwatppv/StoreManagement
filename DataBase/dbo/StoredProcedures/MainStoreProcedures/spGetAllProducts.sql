CREATE PROCEDURE [dbo].[spGetAllProducts]
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
   -- ORDER BY [ProductId] DESC -- Optional: Order by ProductId or any other column as needed
END
GO
