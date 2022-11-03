namespace Module2_HW2.Confectioneries.Candies
{
    public class FruitGrillage : Grillage
    {
        private double _discount = 0.75; // -25%
        public FruitGrillage(string? name, double weightKg, double priceKg, CandyType type, GrillageType grtype, string? fruit)
            : base(name, weightKg, priceKg, type, grtype)
        {
            Fruit = fruit;
        }

        public string? Fruit { get; set; }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() * _discount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy \"{Name}\" [{CandyType}: " +
                $"{GrillageType} ({Fruit})] | Weight: {WeightKg} kg | " +
                $"Price: {PriceKg} UAH/kg| Discount: {100 - (int)(_discount * 100)}%");
        }
    }
}
