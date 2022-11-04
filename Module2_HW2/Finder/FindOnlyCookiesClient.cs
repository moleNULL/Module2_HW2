namespace Module2_HW2.Finder
{
    public class FindOnlyCookiesClient : IFinder
    {
        public IConfectionery[] Find(IConfectionery[] sweets)
        {
            IConfectionery[] confectionery = new IConfectionery[sweets.Length];
            int count = 0;

            for (int i = 0, j = 0; i < sweets.Length; i++)
            {
                if (sweets[i] is Cookie)
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
