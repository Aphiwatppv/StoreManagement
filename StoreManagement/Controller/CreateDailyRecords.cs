using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Controller
{
    public class CreateDailyRecords // return datatable
    {

        IProductionService _productionService;
        List<string> CardateProductID;
       public CreateDailyRecords()
       {
            _productionService = new ProductionService(new SqlDataAccessInternal(new XmlAccess()));

       }

        public async Task<List<string>> GenerateHistoryCarProductId(string carDateId)
        {
            var productDetails = await _productionService.GetDetailIdsAsync();

            var carDateProductIds = productDetails
                                    .Select(detail => carDateId + detail.ProductId.ToString())
                                    .ToList();

            return carDateProductIds;
        }

        public void GenerateDataTable()
        {

        }
    }
}
