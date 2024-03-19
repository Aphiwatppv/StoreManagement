CREATE PROCEDURE [dbo].[GetRemainingStock]
    @ProductId INT,
    @UnitType NVARCHAR(50)
AS
BEGIN
    -- Check the type of unit requested and return the appropriate remaining stock
    IF @UnitType = 'Primary'
    BEGIN
        SELECT RemainingStockPrimaryUnit AS RemainingStock, PrimaryUnit AS Unit
        FROM dbo.MainStoreTb
        WHERE ProductId = @ProductId;
    END
    ELSE IF @UnitType = 'Secondary'
    BEGIN
        SELECT RemainingStockSecondaryUnit AS RemainingStock, SecondaryUnit AS Unit
        FROM dbo.MainStoreTb
        WHERE ProductId = @ProductId;
    END
    ELSE
    BEGIN
        -- Handle case where an unsupported unit type is provided
        PRINT 'Invalid unit type specified. Please specify either ''Primary'' or ''Secondary''.';
    END
END;
