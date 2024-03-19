CREATE PROCEDURE [dbo].[spGetAllCarTransactionSummary]
AS
BEGIN
    SELECT 
        [Id],
        [CarModel],
        [TransactionDate],
        [TotalProduct],
        [CostMoney],
        [ActualMoney],
        [MoneyFromCar],
        [DifferenceMoney]
    FROM [dbo].[CarTransactionSummary]
    ORDER BY [TransactionDate] DESC, [CarModel];
END;