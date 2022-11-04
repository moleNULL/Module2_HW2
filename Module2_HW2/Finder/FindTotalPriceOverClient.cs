namespace Module2_HW2.Finder
{
    public class FindTotalPriceOverClient
    {
        public static IConfectionery[] Find(IConfectionery[] sweets, double price)
        {
            IConfectionery[] confectionery = new IConfectionery[sweets.Length];
            int count = 0;

            for (int i = 0, j = 0; i < sweets.Length; i++)
            {
                if (sweets[i].CalculatePrice() > price)
                {
                    confectionery[j++] = sweets[i];
                    count++;
                }
            }

            Array.Resize(ref confectionery, count);

            return confectionery;
        }
    }
}
