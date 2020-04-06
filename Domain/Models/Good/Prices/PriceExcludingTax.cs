using System;

namespace Domain.Models.Good.Prices
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
    }
}
