CREATE PROCEDURE [dbo].[spEditCarDetails]
    @CarID NVARCHAR(50),
    @NewModel NVARCHAR(50),
    @NewYear INT
AS
BEGIN
    UPDATE dbo.Cars
    SET Model = @NewModel,
        Year = @NewYear
    WHERE CarID = @CarID;
END;
