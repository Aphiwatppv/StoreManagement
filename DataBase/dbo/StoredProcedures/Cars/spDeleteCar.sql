CREATE PROCEDURE [dbo].[spDeleteCar]
    @CarID NVARCHAR(50)
AS
BEGIN
    DELETE FROM dbo.Cars
    WHERE CarID = @CarID;
END;
