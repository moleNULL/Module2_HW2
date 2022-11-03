namespace Module2_HW2
{
    public class Starter
    {
        public static void Run()
        {
            Console.WriteLine("\t\t\t\t\t\tChristmas Present 2022:\n");

            IConfectionery[] sweets = MakeSweets();

            ChristmasPresent present = new ChristmasPresent(sweets);
            present.ShowSweets();

            Console.WriteLine($"\n\tPresent weight: {present.CalculateWeight()} kg");

            UserSortChoice(present);
            UserFindChoice(present);
        }

        // Make initial sweets
        private static IConfectionery[] MakeSweets()
        {
            var fruitGrillage = new FruitGrillage("Donka", 0.454, 320.99, CandyType.Grillage, GrillageType.FruitGrillage, "cherry");
            var romCandy = new LiquorCandy("Tortuga Mix", 0.102, 450.33, CandyType.LiquorCandy, LiquorCandyType.RomCandy);
            var berrySouffle = new BerrySouffle("Paris Dream", 0.346, 999.99, CandyType.Souffle, SouffleType.BerrySouffle, "blackberry");

            var fruitWhoopiePie = new FruitWhoopiePie("New-Yorker", 0.933, 89.99, CookieType.WhoopiePie, "pumpkin");
            var fruitMacaron = new FruitMacaron("Avignon plerfee", 1.221, 777.04, CookieType.Macaron, "strawberry");

            IConfectionery[] sweets =
            {
                fruitGrillage,
                romCandy,
                berrySouffle,

                fruitWhoopiePie,
                fruitMacaron
            };

            return sweets;
        }

        // Ask user how to sort the present
        private static void UserSortChoice(ChristmasPresent present)
        {
            while (true)
            {
                Console.Write("\nSort Christmas present by:\n 1.Total price\n 2.Weight\nChoice: ");
                string? sortAnswer = Console.ReadLine();

                if (sortAnswer != "1" && sortAnswer != "2")
                {
                    Console.WriteLine("Error! Only 1 or 2 is a valid answer");
                    continue;
                }

                if (sortAnswer == "1")
                {
                    present.SortByTotalPrice();
                    Console.WriteLine("\n\t\t\tSorted by [Total Price] in ascending order:");
                    present.ShowSweets();

                    break;
                }
                else if (sortAnswer == "2")
                {
                    present.SortByWeight();
                    Console.WriteLine("\n\t\t\tSorted by [Weight] in ascending order:");
                    present.ShowSweets();

                    break;
                }
            }
        }

        // Ask user what to find in the present
        private static void UserFindChoice(ChristmasPresent present)
        {
            double price = 300.0;

            while (true)
            {
                Console.Write("\nFind sweets in Christmas present by:" +
                    $"\n 1. Total price over {price} UAH:" +
                    "\n 2. Only candies:\n 3. Only cookies:\nChoice: ");
                string? findAnswer = Console.ReadLine();

                switch (findAnswer)
                {
                    case "1":
                        present.PrintFoundedTotalPrice(price);
                        break;
                    case "2":
                        present.PrintOnlyCandies();
                        break;
                    case "3":
                        present.PrintOnlyCookies();
                        break;
                    default:
                        Console.WriteLine("Error! Only 1, 2, or 3 is a valid answer");
                        continue;
                }

                break;
            }
        }
    }
}
