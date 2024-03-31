using DataAccess.Model;

namespace DataAccess.DataAccessMethod
{
    public interface IStoreApi
    {
        Task AddNewProductAsync(MainStoreTb mainStoreTb);
        Task<decimal> CalculateTotalCostPriceAsync();
        Task<decimal> CalculateTotalPriceAsync();
        Task<decimal> CalculateTotalPriceByProductIdAsync(int productId);
        Task DecreaseStockAmountAsync(int productId, string stockType, decimal amount);
        Task EditProductAsync(int productID, MainStoreTb mainStoreTb);
        Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsAsync(string carId);
        Task<int> GenerateProductIdAsync();
        Task<IEnumerable<MainStoreTb>> GetAlldataAsync();
        Task<decimal> GetAmountStockProduct(int ProductId, string UnitType);
        Task<IEnumerable<ProductDetailId>> GetDetailIdsAsync();
        Task<int> GetTotalProductCountAsync();
        Task<IEnumerable<ProductUnitType>> GetUnitTypesAsync(int productId);
        Task IncreaseStockAmountAsync(int productId, string stockType, decimal amount);
        Task RemoveProductAsync(int productId);
        Task<MainStoreTb> SearchProductByIdAsync(int productId);
        Task<IEnumerable<MainStoreTb>> SearchProductByNameAsync(string productName);
    }
}