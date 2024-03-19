CREATE PROCEDURE [dbo].[spUpdateCarProductTransaction]
    @TransactionId NVARCHAR(250),
    @CarID NVARCHAR(50),
    @TakeQuantityPrimaryUnit DECIMAL(10,2),
    @ReturnQuantityPrimaryUnit DECIMAL(10,2),
    @TakeQuantitySecondaryUnit DECIMAL(10,2),
    @ReturnQuantitySecondaryUnit DECIMAL(10,2),
    @SalePrimaryUnit DECIMAL(10,2),
    @SaleSecondaryUnit DECIMAL(10,2),
    @TransactionDate DATE,
    @CostPricePrimaryUnit DECIMAL(13,2),
    @PricePrimaryUnit DECIMAL(13,2),
    @CostPriceSecondaryUnit DECIMAL(13,2),
    @PriceSecondaryUnit DECIMAL(13,2)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM [dbo].[CarProductTransactions] WHERE TransactionId = @TransactionId)
    BEGIN
        -- Update existing record
        UPDATE [dbo].[CarProductTransactions]
        SET
            CarID = @CarID,
            TakeQuantityPrimaryUnit = @TakeQuantityPrimaryUnit,
            ReturnQuantityPrimaryUnit = @ReturnQuantityPrimaryUnit,
            TakeQuantitySecondaryUnit = @TakeQuantitySecondaryUnit,
            ReturnQuantitySecondaryUnit = @ReturnQuantitySecondaryUnit,
            SalePrimaryUnit = @SalePrimaryUnit,
            SaleSecondaryUnit = @SaleSecondaryUnit,
            TransactionDate = @TransactionDate,
            CostPricePrimaryUnit = @CostPricePrimaryUnit,
            PricePrimaryUnit = @PricePrimaryUnit,
            CostPriceSecondaryUnit = @CostPriceSecondaryUnit,
            PriceSecondaryUnit = @PriceSecondaryUnit
        WHERE TransactionId = @TransactionId;
    END
    ELSE
    BEGIN
        -- Handle case where TransactionId does not exist, potentially insert or raise error
        RAISERROR('No record found with the specified TransactionId.', 16, 1);
    END
END;