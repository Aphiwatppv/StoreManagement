CREATE PROCEDURE [dbo].[spGetProductDetails]
AS
BEGIN
    SELECT
        ProductId,
        ProductName,
        PrimaryUnit,
        SecondaryUnit
    FROM [dbo].[MainStoreTb]

END;