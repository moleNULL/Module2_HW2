namespace Module2_HW2.Confectioneries.Candies
{
    public class ChocolateCandy : Candy
    {
        public ChocolateCandy(string? name, double weightKg, double priceKg, CandyType type)
            : base(name, weightKg, priceKg)
        {
            CandyType = type;
        }

        public CandyType CandyType { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy \"{Name}\" [{CandyType}] | " +
                $"Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
