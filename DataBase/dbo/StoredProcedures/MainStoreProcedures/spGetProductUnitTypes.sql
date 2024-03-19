CREATE PROCEDURE [dbo].[spGetProductUnitTypes]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Select the Primary Unit and its type
    SELECT 
        [PrimaryUnit] AS 'Unit',
        'Primary' AS 'UnitType'
    FROM 
        [dbo].[MainStoreTb]
    WHERE 
        [ProductId] = @ProductId

    UNION ALL

    -- Select the Secondary Unit and its type
    SELECT 
        [SecondaryUnit] AS 'Unit',
        'Secondary' AS 'UnitType'
    FROM 
        [dbo].[MainStoreTb]
    WHERE 
        [ProductId] = @ProductId;
END
GO
