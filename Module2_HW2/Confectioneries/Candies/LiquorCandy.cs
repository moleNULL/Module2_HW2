namespace Module2_HW2.Confectioneries.Candies
{
    public class LiquorCandy : ChocolateCandy
    {
        private double _discount = 0.95; // -5%

        public LiquorCandy(string? name, double weightKg, double priceKg, CandyType type, LiquorCandyType lqtype)
            : base(name, weightKg, priceKg, type)
        {
            LiquorCandyType = lqtype;
        }

        public LiquorCandyType LiquorCandyType { get; set; }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() * _discount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy \"{Name}\" [{CandyType}: " +
                $"{LiquorCandyType}] |  Weight: {WeightKg} kg | " +
                $"Price: {PriceKg} UAH/kg | Discount: {100 - (int)(_discount * 100)}%");
        }
    }
}
