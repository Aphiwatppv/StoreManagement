CREATE PROCEDURE [dbo].[spSearchCarTransactions]
    @CarModel NVARCHAR(50) = NULL,
    @TransactionDate DATE = NULL
AS
BEGIN
    SELECT * 
    FROM [dbo].[CarTransactionSummary]
    WHERE 
        (@CarModel IS NULL OR [CarModel] = @CarModel) AND
        (@TransactionDate IS NULL OR [TransactionDate] = @TransactionDate);
END