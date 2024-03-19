using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Controller;

public static class GenerateRecId
{
    static IStockHistoryService _stockHistoryService = new StockHistoryService(new SqlDataAccessInternal(new XmlAccess()));

    public static async Task<string> GenerateId()
    {
       
        var result = await _stockHistoryService.GetMaximumIdAsync();
        string identityIdStr = "1"; 

        if (result != "0")
        {
            var lastIdPart = result.Substring(8); 
            if (int.TryParse(lastIdPart, out int lastId))
            {
                identityIdStr = (lastId + 1).ToString(); 
            }
        }

        var date = DateTime.Today.ToString("yyyyMMdd");
        return date + identityIdStr;
    }


    public static string GenerateIdSumary(string CarId)
    {
        var datetime = DateTime.Now.ToString("yyyyMMdd");

        return CarId + datetime; 

    }

}
