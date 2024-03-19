CREATE PROCEDURE [dbo].[spInsertStockHistory]
    @HistoryId NVARCHAR(50),
    @ProductId INT,
    @ChangeType NVARCHAR(50),
    @QuantityChanged DECIMAL(10,2),
    @Unit NVARCHAR(50),
    @NewQuantity DECIMAL(10,2),
    @Reason NVARCHAR(MAX) -- Adjusted to allow for a detailed explanation
AS
BEGIN
    INSERT INTO [dbo].[StockHistoryTb] 
    (
        HistoryId,
        ProductId, 
        ChangeType, 
        QuantityChanged, 
        Unit, 
        NewQuantity,
        Reason,
        DateChanged
    )
    VALUES (@HistoryId, @ProductId, @ChangeType, @QuantityChanged, @Unit,@NewQuantity, @Reason, GETDATE());
END
