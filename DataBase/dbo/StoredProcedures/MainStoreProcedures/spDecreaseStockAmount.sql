CREATE PROCEDURE [dbo].[spDecreaseStockAmount]
    @ProductId INT,
    @StockType NVARCHAR(10), -- 'Primary' or 'Secondary'
    @Amount DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RelationUnit DECIMAL(10,2);
    SELECT @RelationUnit = [RelationUnit] FROM [dbo].[MainStoreTb] WHERE [ProductId] = @ProductId;

    IF @StockType = 'Primary'
    BEGIN
        IF @RelationUnit IS NOT NULL AND @RelationUnit > 0
        BEGIN
            UPDATE [dbo].[MainStoreTb]
            SET [RemainingStockPrimaryUnit] = [RemainingStockPrimaryUnit] - @Amount,
                [RemainingStockSecondaryUnit] = ([RemainingStockPrimaryUnit] - @Amount) * @RelationUnit
            WHERE [ProductId] = @ProductId;
        END
        ELSE
        BEGIN
            UPDATE [dbo].[MainStoreTb]
            SET [RemainingStockPrimaryUnit] = [RemainingStockPrimaryUnit] - @Amount
            WHERE [ProductId] = @ProductId;
        END
    END
    ELSE IF @StockType = 'Secondary'
    BEGIN
        IF @RelationUnit IS NOT NULL AND @RelationUnit > 0
        BEGIN
            DECLARE @PrimaryDecrease DECIMAL(10,2) = @Amount / @RelationUnit;
            UPDATE [dbo].[MainStoreTb]
            SET [RemainingStockSecondaryUnit] = [RemainingStockSecondaryUnit] - @Amount,
                [RemainingStockPrimaryUnit] = [RemainingStockPrimaryUnit] - @PrimaryDecrease
            WHERE [ProductId] = @ProductId;
        END
        ELSE
        BEGIN
            UPDATE [dbo].[MainStoreTb]
            SET [RemainingStockSecondaryUnit] = [RemainingStockSecondaryUnit] - @Amount
            WHERE [ProductId] = @ProductId;
        END
    END
    ELSE
    BEGIN
        RAISERROR ('Invalid stock type specified. Use ''Primary'' or ''Secondary''.', 16, 1)
    END
END
GO
