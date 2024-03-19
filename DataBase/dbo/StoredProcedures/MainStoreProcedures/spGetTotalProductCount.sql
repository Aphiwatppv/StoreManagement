CREATE PROCEDURE [dbo].[spGetTotalProductCount]
AS
BEGIN
    SET NOCOUNT ON;

    -- Retrieve the total count of products
    SELECT COUNT(*) AS TotalProductCount
    FROM [dbo].[MainStoreTb];
END
GO
