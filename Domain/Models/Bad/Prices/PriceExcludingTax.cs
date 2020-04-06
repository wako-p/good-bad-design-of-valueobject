using System;
using Domain.Models.Bad.SalesTaxRates;

namespace Domain.Models.Bad.Prices
{
    public class PriceExcludingTax
    {
        private readonly int value;

        public int Value { get { return this.value; } }

        public PriceExcludingTax(int value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentException(nameof(value));
            }

            this.value = value;
        }

        private static bool IsValid(int value)
        {
            return 0 <= value;
        }

        public PriceIncludingTax Multi(SalesTaxRate salesTaxRate)
        {
            // 本来、税抜価格はそれ単体で成り立つ概念なのにも関わらず
            // 税込価格と消費税率に依存しており、現実の概念のあり方とクラス設計が乖離しているためNG
            return new PriceIncludingTax(this, salesTaxRate);
        }
    }
}
