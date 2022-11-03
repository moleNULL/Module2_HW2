global using Module2_HW2.Confectioneries;
global using Module2_HW2.Confectioneries.Candies;
global using Module2_HW2.Confectioneries.Cookies;
global using Module2_HW2.Sorter;

namespace Module2_HW2
{
    // Main class to work with goods in the present
    public class ChristmasPresent
    {
        private IConfectionery[] _sweets;
        public ChristmasPresent(IConfectionery[] sweets)
        {
            _sweets = sweets;
        }

        // needed for extension methods to get access to _sweets
        public IConfectionery[] Sweets
        {
            get
            {
                return _sweets;
            }
        }

        public double CalculateWeight()
        {
            double weight = 0.0;

            foreach (IConfectionery conf in _sweets)
            {
                weight += conf.WeightKg;
            }

            return weight;
        }

        // Print all sweets in the present
        public void ShowSweets()
        {
            int i = 1;

            foreach (IConfectionery conf in _sweets)
            {
                Console.Write($"{i++}. ");
                conf.PrintInfo();
            }
        }

        public void SortByTotalPrice()
        {
            SortByTotalPriceClient.Sort(ref _sweets);
        }

        public void SortByWeight()
        {
            SortByWeightClient.Sort(ref _sweets);
        }
    }
}
