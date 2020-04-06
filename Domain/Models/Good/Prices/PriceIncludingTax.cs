using Domain.Models.Good.SalesTaxRates;

namespace Domain.Models.Good.Prices
{
    public class PriceIncludingTax
    {
        private readonly int value;

        public int Value { get { return this.value; } }

        private PriceIncludingTax(PriceExcludingTax price, SalesTaxRate rate)
        {
            this.value = (int)(price.Value * (1M + rate.Value));
        }

        public static PriceIncludingTax From(PriceExcludingTax price, SalesTaxRate rate)
        {
            return new PriceIncludingTax(price, rate);
        }
    }
}
