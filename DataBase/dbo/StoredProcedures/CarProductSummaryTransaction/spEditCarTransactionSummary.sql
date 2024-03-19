CREATE PROCEDURE [dbo].[spEditCarTransactionSummary]
    @Id NVARCHAR(100),
    @MoneyFromCar DECIMAL(18, 2)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM [dbo].[CarTransactionSummary] WHERE Id = @Id)
    BEGIN
        -- Update only the MoneyFromCar field
        UPDATE [dbo].[CarTransactionSummary]
        SET MoneyFromCar = @MoneyFromCar
        WHERE Id = @Id;
    END
    ELSE
    BEGIN
        -- If no record is found with the specified Id, raise an error
        RAISERROR ('No record found with the specified Id.', 16, 1);
    END
END;
