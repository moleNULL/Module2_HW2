namespace Module2_HW2.Confectioneries.Candies
{
    public class Grillage : ChocolateCandy
    {
        public Grillage(string? name, double weightKg, double priceKg, CandyType type, GrillageType grtype)
            : base(name, weightKg, priceKg, type)
        {
            GrillageType = grtype;
        }

        public GrillageType GrillageType { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy: \"{Name}\" [{CandyType}: " +
                $"{GrillageType}] |  Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
