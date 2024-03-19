CREATE PROCEDURE [dbo].[spEnrollCar]
    @CarID NVARCHAR(50),
    @Model NVARCHAR(50),
    @Year INT
AS
BEGIN
    INSERT INTO dbo.Cars (CarID, Model, Year, RegistrationDate)
    VALUES (@CarID, @Model, @Year, GETDATE());
END;