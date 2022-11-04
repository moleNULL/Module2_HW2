namespace Module2_HW2.Confectioneries.Candies
{
    public class Souffle : ChocolateCandy
    {
        public Souffle(string? name, double weightKg, double priceKg, CandyType type, SouffleType sftype)
            : base(name, weightKg, priceKg, type)
        {
            SouffleType = sftype;
        }

        public SouffleType SouffleType { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy \"{Name}\" [{CandyType}: " +
                $"{SouffleType}] |  Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
