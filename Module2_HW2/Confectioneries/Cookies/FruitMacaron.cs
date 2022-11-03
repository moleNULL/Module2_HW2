namespace Module2_HW2.Confectioneries.Cookies
{
    public class FruitMacaron : Macaron
    {
        private string? _fruit;
        public FruitMacaron(string? name, double weightKg, double priceKg, CookieType type, string? fruit)
            : base(name, weightKg, priceKg, type)
        {
            Fruit = fruit;
        }

        public string? Fruit
        {
            get
            {
                // strawberry -> Strawberry
                return char.ToUpper(_fruit![0]) + _fruit.Substring(1);
            }
            set
            {
                _fruit = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cookies \"{Name}\" [{CookieType}: " +
                $"{Fruit} Macaron] | Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
