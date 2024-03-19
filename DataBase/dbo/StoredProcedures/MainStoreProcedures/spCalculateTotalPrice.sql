CREATE PROCEDURE [dbo].[spCalculateTotalPrice]
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate the total price for all products
    SELECT SUM([RemainingStockPrimaryUnit] * [PricePrimaryUnit]) AS TotalPrice
    FROM [dbo].[MainStoreTb];
END
GO
