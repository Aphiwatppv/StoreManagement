CREATE PROCEDURE [dbo].[spRemoveProduct]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON; -- Added to prevent extra result sets from interfering with SELECT statements.
    
    -- Enabling error handling
    BEGIN TRY
        -- Start the transaction
        BEGIN TRANSACTION;
        
        -- Delete the product from the MainStoreTb table where the ProductId matches
        DELETE FROM MainStoreTb
        WHERE ProductId = @ProductId;
        
        -- If no errors, commit the transaction
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- If an error occurs, roll back any changes made during the transaction
        ROLLBACK TRANSACTION;
        
        -- Re-throw the caught error for further handling
        THROW;
    END CATCH
END