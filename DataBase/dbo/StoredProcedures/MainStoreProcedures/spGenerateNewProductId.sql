CREATE PROCEDURE [dbo].[spGenerateNewProductId]
AS
BEGIN
    SET NOCOUNT ON;

    -- Select the maximum ProductId and increment by 1
    -- If no ProductId exists, start with 1000000000
    DECLARE @NewProductId INT;
    SELECT @NewProductId = ISNULL(MAX(ProductId), 1000000000 - 1) + 1 FROM MainStoreTb;
    
    -- Return the new ProductId
    SELECT @NewProductId AS NewProductId;
END;
GO