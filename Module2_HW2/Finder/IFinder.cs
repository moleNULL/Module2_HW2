namespace Module2_HW2.Finder
{
    public interface IFinder
    {
        // Choice 1
        public static IConfectionery[] Find(IConfectionery[] sweets, double price)
        {
            return new IConfectionery[0]; // plug. Since static modifier requires body
        }

        // Choice 2, 3
        public static IConfectionery[] Find(IConfectionery[] sweets)
        {
            return new IConfectionery[0]; // plug. Since static modifier requires body
        }

        public static IConfectionery[] Find(IConfectionery[] sweets, IConfectionery type)
        {
            return new IConfectionery[0]; // plug. Since static modifier requires body
        }
    }
}
