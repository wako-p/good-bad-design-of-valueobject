using Domain.Models.Bad.SalesTaxRates;

namespace Domain.Models.Bad.Prices
{
    public class PriceIncludingTax
    {
        private readonly int value;

        public int Value { get { return this.value; } }

        public PriceIncludingTax(PriceExcludingTax price, SalesTaxRate rate)
        {
            this.value = (int)(price.Value * (1M + rate.Value));
        }
    }
}
