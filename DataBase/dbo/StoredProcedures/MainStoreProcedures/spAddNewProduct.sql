CREATE PROCEDURE [dbo].[spAddNewProduct]
    @ProductId INT, 
    @ProductName NVARCHAR(255),
    @RemainingStockPrimaryUnit DECIMAL(10,2),
    @PrimaryUnit NVARCHAR(50),
    @RemainingStockSecondaryUnit DECIMAL(10,2),
    @SecondaryUnit NVARCHAR(50),
    @RelationUnit DECIMAL(10,2) = NULL,
    @CostPricePrimaryUnit DECIMAL(13,2) = NULL,
    @PricePrimaryUnit DECIMAL(13,2) = NULL,
    @CostPriceSecondaryUnit DECIMAL(13,2) = NULL,
    @PriceSecondaryUnit DECIMAL(13,2) = NULL,
    @UnitPrice NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if a product with the same ProductId or ProductName already exists
    IF EXISTS (SELECT 1 FROM [dbo].[MainStoreTb] WHERE ProductId = @ProductId OR ProductName = @ProductName)
    BEGIN
        -- You can change the next line to handle the error as you see fit:
        -- For example, you could raise an error, or set a status code to return.
        RAISERROR('A product with the same ProductId or ProductName already exists.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[MainStoreTb] (
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
    )
    VALUES (
        @ProductId,
        @ProductName,
        @RemainingStockPrimaryUnit,
        @PrimaryUnit,
        @RemainingStockSecondaryUnit,
        @SecondaryUnit,
        @RelationUnit,
        @CostPricePrimaryUnit,
        @PricePrimaryUnit,
        @CostPriceSecondaryUnit,
        @PriceSecondaryUnit,
        @UnitPrice
    );
END;
GO
