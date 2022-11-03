namespace Module2_HW2.Confectioneries.Cookies
{
    public class FruitWhoopiePie : WhoopiePie
    {
        public FruitWhoopiePie(string? name, double weightKg, double priceKg, CookieType type, string? fruit)
            : base(name, weightKg, priceKg, type)
        {
            Fruit = fruit;
        }

        public string? Fruit { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cookies \"{Name}\" [{CookieType}: " +
                $"Fruit Whoopie Pie ({Fruit})] | Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
