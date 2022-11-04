namespace Module2_HW2.Confectioneries
{
    public interface IConfectionery
    {
        public string? Name { get; set; }
        public double WeightKg { get; set; }
        public double PriceKg { get; set; }
        double CalculatePrice();
        void PrintInfo();
    }
}
