using System;

namespace Domain.Models.Bad.SalesTaxRates
{
    public class SalesTaxRate
    {
        private readonly decimal value;

        public decimal Value { get { return this.value; } }

        // 本来なら契約日によって消費税率が決定するが今回は省略
        public SalesTaxRate(decimal value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            this.value = value;
        }

        public static bool IsValid(decimal value)
        {
            return (0.01M <= value) && (value <= 0.99M);
        }
    }
}
