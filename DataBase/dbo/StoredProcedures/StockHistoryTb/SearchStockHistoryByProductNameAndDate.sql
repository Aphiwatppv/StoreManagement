CREATE PROCEDURE [dbo].[SearchStockHistoryByProductNameAndDate]
    @ProductName NVARCHAR(255) = NULL, -- Default NULL if not provided
    @StartDate DATETIME = NULL, -- Default NULL if not provided
    @EndDate DATETIME = NULL -- Default NULL if not provided
AS
BEGIN
    SELECT
        sh.HistoryId,
        sh.ProductId,
        p.ProductName,
        sh.ChangeType,
        sh.QuantityChanged,
        sh.Unit,
        sh.NewQuantity,
        sh.Reason,
        sh.DateChanged
    FROM
        dbo.StockHistoryTb AS sh
    INNER JOIN
        dbo.MainStoreTb AS p ON sh.ProductId = p.ProductId
    WHERE
        (@ProductName IS NULL OR p.ProductName LIKE '%' + @ProductName + '%')
        AND (@StartDate IS NULL OR @EndDate IS NULL OR sh.DateChanged BETWEEN @StartDate AND @EndDate);
END;
GO