namespace Module2_HW2.Confectioneries.Cookies
{
    public class WhoopiePie : Cookie
    {
        public WhoopiePie(string? name, double weightKg, double priceKg, CookieType type)
            : base(name, weightKg, priceKg)
        {
            CookieType = type;
        }

        public CookieType CookieType { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cookies \"{Name}\" [{CookieType}] | " +
                $"Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
