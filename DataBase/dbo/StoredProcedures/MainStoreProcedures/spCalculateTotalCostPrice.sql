CREATE PROCEDURE [dbo].[spCalculateTotalCostPrice]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SUM([RemainingStockPrimaryUnit] * [CostPricePrimaryUnit]) AS TotalCostPrice
    FROM [dbo].[MainStoreTb];
END
GO
