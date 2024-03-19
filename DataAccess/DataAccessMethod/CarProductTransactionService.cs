using DataAccess.Model;
using DataAccess.SqlAccess;

namespace DataAccess.DataAccessMethod
{
    public class CarProductTransactionService : ICarProductTransactionService
    {
        ISqlDataAccessInternal _sqlDataAccessInternal;

        public CarProductTransactionService(ISqlDataAccessInternal sqlDataAccessInternal)
        {
            _sqlDataAccessInternal = sqlDataAccessInternal;
        }

        public async Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsAsync(string carId)
        {
            var result = await _sqlDataAccessInternal.LoadDataAsync<GenerateCarProductTransactionForm, dynamic>(storedProcedure: "dbo.spCreateEmptyCarProductTransactionForm", new { carId = carId });
            return result;
        }

        public async Task SaveCarProductTransactionsAsync(CarProductTransaction carProductTransaction)
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spSaveCarProductTransaction", new
            {
                CarId = carProductTransaction.CarId,
                TransactionId = carProductTransaction.TransactionId,
                TakeQuantityPrimaryUnit = carProductTransaction.TakeQuantityPrimaryUnit,
                ReturnQuantityPrimaryUnit = carProductTransaction.ReturnQuantityPrimaryUnit,
                TakeQuantitySecondaryUnit = carProductTransaction.TakeQuantitySecondaryUnit,
                ReturnQuantitySecondaryUnit = carProductTransaction.ReturnQuantitySecondaryUnit,
                SalePrimaryUnit = carProductTransaction.SalePrimaryUnit,
                SaleSecondaryUnit = carProductTransaction.SaleSecondaryUnit,
                TransactionDate = carProductTransaction.TransactionDate,
                CostPricePrimaryUnit = carProductTransaction.CostPricePrimaryUnit,
                PricePrimaryUnit = carProductTransaction.PricePrimaryUnit,
                CostPriceSecondaryUnit = carProductTransaction.CostPriceSecondaryUnit,
                PriceSecondaryUnit = carProductTransaction.PriceSecondaryUnit,
            });
        }

        public async Task<IEnumerable<CarProductTransactionSummary>> GetTransactionSummariesAsync()
        {
            var result = await _sqlDataAccessInternal.LoadDataAsync<CarProductTransactionSummary, dynamic>(storedProcedure: "dbo.spGetAllCarTransactionSummary", new { });
            return result;
        }

        public async Task GenerateSummaryTrasaction()
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spGenerateCarTransactionSummary", new { });

        }

        public async Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsByID(string Id)
            => await _sqlDataAccessInternal.LoadDataAsync<GenerateCarProductTransactionForm, dynamic>(storedProcedure: "dbo.spGetTransactionDataById", new { Id = Id });


        public async Task UpdatedataCarProductTransactionsEdit(CarProductTransaction carProductTransaction)
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spUpdateCarProductTransaction", new
            {
                CarId = carProductTransaction.CarId,
                TransactionId = carProductTransaction.TransactionId,
                TakeQuantityPrimaryUnit = carProductTransaction.TakeQuantityPrimaryUnit,
                ReturnQuantityPrimaryUnit = carProductTransaction.ReturnQuantityPrimaryUnit,
                TakeQuantitySecondaryUnit = carProductTransaction.TakeQuantitySecondaryUnit,
                ReturnQuantitySecondaryUnit = carProductTransaction.ReturnQuantitySecondaryUnit,
                SalePrimaryUnit = carProductTransaction.SalePrimaryUnit,
                SaleSecondaryUnit = carProductTransaction.SaleSecondaryUnit,
                TransactionDate = carProductTransaction.TransactionDate,
                CostPricePrimaryUnit = carProductTransaction.CostPricePrimaryUnit,
                PricePrimaryUnit = carProductTransaction.PricePrimaryUnit,
                CostPriceSecondaryUnit = carProductTransaction.CostPriceSecondaryUnit,
                PriceSecondaryUnit = carProductTransaction.PriceSecondaryUnit,
            });
        }

        public async Task EditdataSummaryAsync(string Id, decimal MoneyFromCar)
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spEditCarTransactionSummary", new
            {
                Id = Id,
                MoneyFromCar = MoneyFromCar

            });
        }

        public async Task UpdatedataSummaryAsync()
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spUpdateCarTransactionSummary", new
            {

            });
        }

        public async Task UpdateMainStoreAsync()
        {
            await _sqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spUpdateMainStoreStock", new { });
        }

    }

}
