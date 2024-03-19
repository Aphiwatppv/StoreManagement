CREATE PROCEDURE [dbo].[spGetAllCarDetails]
AS
BEGIN
    SELECT 
        CarID, 
        Model, 
        Year, 
        RegistrationDate,
        DATEDIFF(day, RegistrationDate, GETDATE()) AS DaysSinceRegistration
    FROM dbo.Cars;
END;
