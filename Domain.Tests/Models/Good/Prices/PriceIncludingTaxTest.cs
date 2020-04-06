using Xunit;
using Domain.Models.Good.Prices;
using Domain.Models.Good.SalesTaxRates;

namespace Domain.Tests.Models.Good.Prices
{
    public class PriceIncludingTaxTest
    {
        [Fact]
        public void CreatePriceIncludingTax()
        {
            var priceExcludingTax = new PriceExcludingTax(1000);
            var salesTaxRate      = new SalesTaxRate(0.1M);

            var priceIncludingTax = PriceIncludingTax.From(priceExcludingTax, salesTaxRate);
            // or var priceIncludingTax = new PriceIncludingTax(priceExcludingTax, salesTaxRate);

            Assert.Equal(1100, priceIncludingTax.Value);
        }
    }
}
