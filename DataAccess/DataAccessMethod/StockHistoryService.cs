using DataAccess.Model;
using DataAccess.SqlAccess;
using System;

namespace DataAccess.DataAccessMethod;


public class StockHistoryService : IStockHistoryService
{
    ISqlDataAccessInternal _SqlDataAccessInternal;

    public StockHistoryService(ISqlDataAccessInternal sqlDataAccessInternal)
    {
        _SqlDataAccessInternal = sqlDataAccessInternal;
    }

    public async Task InsertLogAsync(string historyId, int productId, string changingType, decimal quantitychange, string unit, decimal newquantity, string Reason)
    {
        await _SqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spInsertStockHistory", new
        {
            HistoryId = historyId,
            ProductId = productId,
            ChangeType = changingType,
            QuantityChanged = quantitychange,
            Unit = unit,
            NewQuantity = newquantity,
            Reason = Reason,
        });
    }

    public async Task<string> GetMaximumIdAsync()
    {
        var result = await _SqlDataAccessInternal.LoadDataAsync<string, dynamic>(storedProcedure: "dbo.uspGetMaxHistoryId", new { });
        return result.FirstOrDefault();

    }

    public async Task<IEnumerable<StockHistoryRecord>> GetAllStockHistoryRecordAsync()
        => await _SqlDataAccessInternal.LoadDataAsync<StockHistoryRecord, dynamic>(storedProcedure: "dbo.spGetStockHistory", new { });

    public async Task<IEnumerable<StockHistoryRecord>> SearchStockHistoryRecordsAsync(string productName, DateTime? startDate, DateTime? endDate)
    {
        // Prepare parameters, handling nulls appropriately if your method supports them
        var parameters = new
        {
            ProductName = productName ?? (object)DBNull.Value,
            StartDate = startDate.HasValue ? (object)startDate.Value : DBNull.Value,
            EndDate = endDate.HasValue ? (object)endDate.Value : DBNull.Value
        };

        var result = await _SqlDataAccessInternal.LoadDataAsync<StockHistoryRecord, dynamic>(
            storedProcedure: "dbo.SearchStockHistoryByProductNameAndDate",
            parameters: parameters
        );

        return result;

    }
}
