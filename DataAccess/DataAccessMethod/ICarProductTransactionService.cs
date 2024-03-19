using DataAccess.Model;

namespace DataAccess.DataAccessMethod
{
    public interface ICarProductTransactionService
    {
        Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsAsync(string carId);
        Task SaveCarProductTransactionsAsync(CarProductTransaction carProductTransaction);
        Task<IEnumerable<CarProductTransactionSummary>> GetTransactionSummariesAsync();
        Task UpdatedataCarProductTransactionsEdit(CarProductTransaction carProductTransaction);
        Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsByID(string Id);
        Task EditdataSummaryAsync(string Id, decimal MoneyFromCar);
        Task GenerateSummaryTrasaction();
        Task UpdatedataSummaryAsync();
        Task UpdateMainStoreAsync();
    }
}