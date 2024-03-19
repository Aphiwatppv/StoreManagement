CREATE PROCEDURE [dbo].[spSaveCarProductTransaction]
    @CarID NVARCHAR(50),
    @TransactionId NVARCHAR(250),
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
    -- Extract ProductId from the TransactionId
    -- This requires knowing the exact format and positions of CarID and ProductId within the TransactionId
    DECLARE @ProductId INT = TRY_CAST(RIGHT(@TransactionId, LEN(@TransactionId) - LEN(@CarID) - 8) AS INT);

    IF @ProductId IS NULL
    BEGIN
        RAISERROR ('ProductId could not be extracted from TransactionId.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[CarProductTransactions] (
        [Id],
        [TransactionId],
        [CarID],
        [ProductId],
        [TakeQuantityPrimaryUnit],
        [ReturnQuantityPrimaryUnit],
        [TakeQuantitySecondaryUnit],
        [ReturnQuantitySecondaryUnit],
        [SalePrimaryUnit],
        [SaleSecondaryUnit],
        [TransactionDate],
        [CostPricePrimaryUnit],
        [PricePrimaryUnit],
        [CostPriceSecondaryUnit],
        [PriceSecondaryUnit],
        [IsStockUpdated]
    )
    VALUES (
        CONCAT(@CarID,FORMAT(@TransactionDate, 'yyyyMMdd')), -- Generating Id based on format: CarID + yyyyMMdd
        @TransactionId,
        @CarID,
        @ProductId,
        @TakeQuantityPrimaryUnit,
        @ReturnQuantityPrimaryUnit,
        @TakeQuantitySecondaryUnit,
        @ReturnQuantitySecondaryUnit,
        @SalePrimaryUnit,
        @SaleSecondaryUnit,
        @TransactionDate,
        @CostPricePrimaryUnit,
        @PricePrimaryUnit,
        @CostPriceSecondaryUnit,
        @PriceSecondaryUnit,
        0
    )
END;
