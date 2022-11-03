namespace Module2_HW2.Confectioneries.Candies
{
    public class BerrySouffle : Souffle
    {
        public BerrySouffle(string? name, double weightKg, double priceKg, CandyType type, SouffleType sftype, string? berry)
            : base(name, weightKg, priceKg, type, sftype)
        {
            Berry = berry;
        }

        public string? Berry { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Candy \"{Name}\" [{CandyType}: " +
                $"{SouffleType} ({Berry})] | Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
