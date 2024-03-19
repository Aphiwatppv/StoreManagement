CREATE PROCEDURE [dbo].[spSearchProductByName]
    @ProductName NVARCHAR(255)
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
    WHERE [ProductName] LIKE '%' + @ProductName + '%';
END
GO
