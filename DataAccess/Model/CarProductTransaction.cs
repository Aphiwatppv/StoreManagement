namespace DataAccess.Model
{
    public class CarProductTransaction
    {
        public string CarId { get; set; }
        public string TransactionId { get; set; }
        public decimal? TakeQuantityPrimaryUnit { get; set; }
        public decimal? ReturnQuantityPrimaryUnit { get; set; }
        public decimal? TakeQuantitySecondaryUnit { get; set; }
        public decimal? ReturnQuantitySecondaryUnit { get; set; }
        public decimal? SalePrimaryUnit { get; set; }
        public decimal? SaleSecondaryUnit { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? CostPricePrimaryUnit { get; set; }
        public decimal? PricePrimaryUnit { get; set; }
        public decimal? CostPriceSecondaryUnit { get; set; }
        public decimal? PriceSecondaryUnit { get; set; }
    }
}
