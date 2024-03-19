CREATE PROCEDURE [dbo].[spGetStockHistory]
AS
BEGIN
    SELECT TOP 100
        sh.HistoryId, 
        sh.ProductId, 
        ms.ProductName,
        sh.ChangeType, 
        sh.QuantityChanged, 
        sh.Unit, 
        sh.NewQuantity,
        sh.Reason, 
        sh.DateChanged
    FROM 
        [dbo].[StockHistoryTb] sh
    INNER JOIN 
        [dbo].[MainStoreTb] ms ON sh.ProductId = ms.ProductId
    ORDER BY 
        sh.DateChanged DESC
END