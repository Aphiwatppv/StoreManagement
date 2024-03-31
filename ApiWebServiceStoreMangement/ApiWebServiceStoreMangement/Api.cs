namespace ApiWebServiceStoreMangement;

public static class Api

{
    public static void ConfigureApi(this WebApplication app)
    {
     
        app.MapGet(pattern: "/GetAllProduct", GetAllProducts);
        app.MapGet(pattern: "/SearchingProduct/{specificWord}", SearcingPorductByNameAsync);

    }


    private static async Task<IResult> GetAllProducts(IProductServices product)
    {
        try
        {
            return Results.Ok(await product.GetProductDetailAsync());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> SearcingPorductByNameAsync(IProductServices product, string specificWord)
    {
        try
        {
            return Results.Ok(await product.SearchProductsAsync(specificWord));
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


}
