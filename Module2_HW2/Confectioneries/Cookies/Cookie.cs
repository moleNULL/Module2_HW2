namespace Module2_HW2.Confectioneries.Cookies
{
    public class Cookie : IConfectionery
    {
        public Cookie(string? name, double weightKg, double priceKg)
        {
            Name = name;
            WeightKg = weightKg;
            PriceKg = priceKg;
        }

        public string? Name { get; set; }
        public double WeightKg { get; set; }
        public double PriceKg { get; set; }

        public virtual double CalculatePrice()
        {
            return WeightKg * PriceKg;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Cookies \"{Name}\" | " +
                $"Weight: {WeightKg} kg | Price: {PriceKg} UAH/kg");
        }
    }
}
