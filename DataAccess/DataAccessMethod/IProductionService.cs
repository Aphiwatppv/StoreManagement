using DataAccess.Model;

namespace DataAccess.DataAccessMethod
{
    public interface IProductionService
    {
        Task AddNewProductAsync(MainStoreTb mainStoreTb);
        Task<decimal> CalculateTotalCostPriceAsync();
        Task<decimal> CalculateTotalPriceAsync();
        Task<decimal> CalculateTotalPriceByProductIdAsync(int productId);
        Task DecreaseStockAmountAsync(int productId, string stockType, decimal amount);
        Task<int> GenerateProductIdAsync();
        Task<IEnumerable<MainStoreTb>> GetAlldataAsync();
        Task<int> GetTotalProductCountAsync();
        Task IncreaseStockAmountAsync(int productId, string stockType, decimal amount);
        Task RemoveProductAsync(int productId);
        Task<MainStoreTb> SearchProductByIdAsync(int productId);
        Task<IEnumerable<MainStoreTb>> SearchProductByNameAsync(string productName);
        Task EditProductAsync(int productID, MainStoreTb mainStoreTb);
        Task<IEnumerable<ProductUnitType>> GetUnitTypesAsync(int productId);
        Task<decimal> GetAmountStockProduct(int ProductId, string UnitType);
        Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsAsync(string carId);
        Task<IEnumerable<ProductDetailId>> GetDetailIdsAsync();
    }
}