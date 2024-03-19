using DataAccess.Model;

namespace DataAccess.DataAccessMethod
{
    public interface IStockHistoryService
    {
        Task<IEnumerable<StockHistoryRecord>> GetAllStockHistoryRecordAsync();
        Task<string> GetMaximumIdAsync();
        Task InsertLogAsync(string historyId, int productId, string changingType, decimal quantitychange, string unit, decimal newquantity, string Reason);
        Task<IEnumerable<StockHistoryRecord>> SearchStockHistoryRecordsAsync(string productName, DateTime? startDate, DateTime? endDate);
    }
}