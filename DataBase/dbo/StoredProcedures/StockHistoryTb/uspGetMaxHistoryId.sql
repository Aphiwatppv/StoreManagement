CREATE PROCEDURE [dbo].[uspGetMaxHistoryId]
AS
BEGIN
    
    SELECT ISNULL(MAX(HistoryId), '0') AS MaxHistoryId
    FROM dbo.StockHistoryTb;
END
