using Xunit;
using Domain.Models.Bad.Prices;
using Domain.Models.Bad.SalesTaxRates;

namespace Domain.Tests.Models.Bad.Prices
{
    public class PriceIncludingTaxTest
    {
        [Fact]
        public void CreatePriceIncludingTax()
        {
            var priceExcludingTax = new PriceExcludingTax(1000);
            var salesTaxRate      = new SalesTaxRate(0.1M);

            var priceIncludingTax = priceExcludingTax.Multi(salesTaxRate);

            Assert.Equal(1100, priceIncludingTax.Value);
        }
    }
}
