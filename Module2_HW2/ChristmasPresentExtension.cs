global using Module2_HW2.Finder;

namespace Module2_HW2
{
    public static class ChristmasPresentExtension
    {
        // Print sweets only with a particular price (over {price} UAH)
        public static void PrintFoundedTotalPrice(this ChristmasPresent present, double price)
        {
            IConfectionery[] conf = FindTotalPriceOverClient.Find(present.Sweets, price);

            if (conf.Length == 0)
            {
                Console.WriteLine($"There are no sweets with price over {price} UAH");

                return;
            }

            Console.WriteLine($"\n\t\t\tList of  {conf.Length} sweets with price over {price} UAH:");

            PrintConfectioneryInfo(conf);
        }

        public static void PrintOnlyCandies(this ChristmasPresent present)
        {
            IConfectionery[] conf = new FindOnlyCandiesClient().Find(present.Sweets);

            if (conf.Length == 0)
            {
                Console.WriteLine($"There are no candies in the Christmas present");

                return;
            }

            Console.WriteLine($"\n\t\t\tList of {conf.Length} candies:");

            PrintConfectioneryInfo(conf);
        }

        public static void PrintOnlyCookies(this ChristmasPresent present)
        {
            IConfectionery[] conf = new FindOnlyCookiesClient().Find(present.Sweets);

            if (conf.Length == 0)
            {
                Console.WriteLine($"There are no cookies in the Christmas present");

                return;
            }

            Console.WriteLine($"\n\t\t\tList of {conf.Length} cookies:");

            PrintConfectioneryInfo(conf);
        }

        // Print only list of particular sweets
        private static void PrintConfectioneryInfo(IConfectionery[] conf)
        {
            int i = 1;
            foreach (IConfectionery c in conf)
            {
                Console.Write($"{i++}. ");
                c.PrintInfo();
            }
        }
    }
}
