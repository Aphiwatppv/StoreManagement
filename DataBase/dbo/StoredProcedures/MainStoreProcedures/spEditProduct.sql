CREATE PROCEDURE [dbo].[spEditProduct]
    @ProductId INT,
    @ProductName NVARCHAR(255),
    @RemainingStockPrimaryUnit DECIMAL(10,2),
    @PrimaryUnit NVARCHAR(50),
    @RemainingStockSecondaryUnit DECIMAL(10,2),
    @SecondaryUnit NVARCHAR(50),
    @RelationUnit DECIMAL(10,2),
    @CostPricePrimaryUnit DECIMAL(13,2),
    @PricePrimaryUnit DECIMAL(13,2),
    @CostPriceSecondaryUnit DECIMAL(13,2),
    @PriceSecondaryUnit DECIMAL(13,2),
    @UnitPrice NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        UPDATE MainStoreTb
        SET ProductName = @ProductName,
            RemainingStockPrimaryUnit = @RemainingStockPrimaryUnit,
            PrimaryUnit = @PrimaryUnit,
            RemainingStockSecondaryUnit = @RemainingStockSecondaryUnit,
            SecondaryUnit = @SecondaryUnit,
            RelationUnit = @RelationUnit,
            CostPricePrimaryUnit = @CostPricePrimaryUnit,
            PricePrimaryUnit = @PricePrimaryUnit,
            CostPriceSecondaryUnit = @CostPriceSecondaryUnit,
            PriceSecondaryUnit = @PriceSecondaryUnit,
            UnitPrice = @UnitPrice
        WHERE ProductId = @ProductId;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
