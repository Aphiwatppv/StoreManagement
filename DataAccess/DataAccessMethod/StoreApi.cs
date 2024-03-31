using DataAccess.Model;
using DataAccess.SqlAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessMethod
{
    public class StoreApi : IStoreApi
    {
        private readonly ISqlDataAccess _SqlDataAccess;

        public StoreApi(ISqlDataAccess sqlDataAccess)
        {
            _SqlDataAccess = sqlDataAccess;
        }

        public async Task<IEnumerable<MainStoreTb>> GetAlldataAsync() =>
    await _SqlDataAccess.LoadDataAsync<MainStoreTb, dynamic>(storedProcedure: "dbo.spGetAllProducts", new { });
        public async Task AddNewProductAsync(MainStoreTb mainStoreTb)
        {
            await _SqlDataAccess.SaveDataAsync(storedProcedure: "dbo.spAddNewProduct", new
            {
                ProductId = mainStoreTb.ProductId,
                ProductName = mainStoreTb.ProductName,
                RemainingStockPrimaryUnit = mainStoreTb.RemainingStockPrimaryUnit,
                PrimaryUnit = mainStoreTb.PrimaryUnit,
                RemainingStockSecondaryUnit = mainStoreTb.RemainingStockSecondaryUnit,
                SecondaryUnit = mainStoreTb.SecondaryUnit,
                RelationUnit = mainStoreTb.RelationUnit,
                CostPricePrimaryUnit = mainStoreTb.CostPricePrimaryUnit,
                PricePrimaryUnit = mainStoreTb.PricePrimaryUnit,
                CostPriceSecondaryUnit = mainStoreTb.CostPriceSecondaryUnit,
                PriceSecondaryUnit = mainStoreTb.PriceSecondaryUnit,
                UnitPrice = mainStoreTb.UnitPrice,

            });
        }
        public async Task RemoveProductAsync(int productId)
        {
            await _SqlDataAccess.SaveDataAsync(storedProcedure: "dbo.spRemoveProduct", new { ProductID = productId });
        }
        public async Task EditProductAsync(int productID, MainStoreTb mainStoreTb)
        {
            await _SqlDataAccess.SaveDataAsync(storedProcedure: "dbo.spEditProduct", new
            {

                ProductId = productID,
                ProductName = mainStoreTb.ProductName,
                RemainingStockPrimaryUnit = mainStoreTb.RemainingStockPrimaryUnit,
                PrimaryUnit = mainStoreTb.PrimaryUnit,
                RemainingStockSecondaryUnit = mainStoreTb.RemainingStockSecondaryUnit,
                SecondaryUnit = mainStoreTb.SecondaryUnit,
                RelationUnit = mainStoreTb.RelationUnit,
                CostPricePrimaryUnit = mainStoreTb.CostPricePrimaryUnit,
                PricePrimaryUnit = mainStoreTb.PricePrimaryUnit,
                CostPriceSecondaryUnit = mainStoreTb.CostPriceSecondaryUnit,
                PriceSecondaryUnit = mainStoreTb.PriceSecondaryUnit,
                UnitPrice = mainStoreTb.UnitPrice,
            });
        }
        public async Task IncreaseStockAmountAsync(int productId, string stockType, decimal amount)
        {
            await _SqlDataAccess.SaveDataAsync(storedProcedure: "dbo.spIncreaseStockAmount", new
            {
                ProductId = productId,
                StockType = stockType,
                Amount = amount,
            });
        }
        public async Task DecreaseStockAmountAsync(int productId, string stockType, decimal amount)
        {
            await _SqlDataAccess.SaveDataAsync(storedProcedure: "dbo.spDecreaseStockAmount", new
            {
                ProductId = productId,
                StockType = stockType,
                Amount = amount
            });
        }
        public async Task<int> GetTotalProductCountAsync()
        {
            var result = await _SqlDataAccess.LoadDataAsync<int, dynamic>(
                storedProcedure: "dbo.spGetTotalProductCount",
                parameters: new { });

            return result.FirstOrDefault();
        }
        public async Task<MainStoreTb> SearchProductByIdAsync(int productId)
        {
            var parameters = new { ProductId = productId };
            var result = await _SqlDataAccess.LoadDataAsync<MainStoreTb, dynamic>(
                storedProcedure: "dbo.spSearchProductById",
                parameters);

            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<MainStoreTb>> SearchProductByNameAsync(string productName)
        {
            var parameters = new { ProductName = productName };
            return await _SqlDataAccess.LoadDataAsync<MainStoreTb, dynamic>(
                storedProcedure: "dbo.spSearchProductByName",
                parameters);
        }
        public async Task<decimal> CalculateTotalCostPriceAsync()
        {
            var result = await _SqlDataAccess.LoadDataAsync<decimal, dynamic>(
                storedProcedure: "dbo.spCalculateTotalCostPrice",
                parameters: new { });

            return result.FirstOrDefault();
        }
        public async Task<decimal> CalculateTotalPriceAsync()
        {
            var result = await _SqlDataAccess.LoadDataAsync<decimal, dynamic>(
                storedProcedure: "dbo.spCalculateTotalPrice",
                parameters: new { });

            return result.FirstOrDefault();
        }
        public async Task<decimal> CalculateTotalPriceByProductIdAsync(int productId)
        {
            var parameters = new { ProductId = productId };
            var result = await _SqlDataAccess.LoadDataAsync<decimal, dynamic>(
                storedProcedure: "dbo.spCalculateTotalPriceByProductId",
                parameters);

            return result.FirstOrDefault();
        }
        public async Task<int> GenerateProductIdAsync()
        {
            var result = await _SqlDataAccess.LoadDataAsync<int, dynamic>(storedProcedure: "dbo.spGenerateNewProductId", new { });
            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<ProductUnitType>> GetUnitTypesAsync(int productId)
        {
            var result = await _SqlDataAccess.LoadDataAsync<ProductUnitType, dynamic>(storedProcedure: "dbo.spGetProductUnitTypes", new
            {
                productId = productId
            });
            return result;
        }

        public async Task<decimal> GetAmountStockProduct(int ProductId, string UnitType)
        {
            var result = await _SqlDataAccess.LoadDataAsync<decimal, dynamic>(storedProcedure: "dbo.GetRemainingStock", new
            {
                productId = ProductId
            ,
                UnitType = UnitType
            });

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<ProductDetailId>> GetDetailIdsAsync()
            => await _SqlDataAccess.LoadDataAsync<ProductDetailId, dynamic>(storedProcedure: "dbo.spGetProductDetails", new { });

        public async Task<IEnumerable<GenerateCarProductTransactionForm>> GenerateCarProductTransactionsAsync(string carId)
        {
            var result = await _SqlDataAccess.LoadDataAsync<GenerateCarProductTransactionForm, dynamic>(storedProcedure: "dbo.spCreateEmptyCarProductTransactionForm", new { carId = carId });
            return result;
        }
    }
}

