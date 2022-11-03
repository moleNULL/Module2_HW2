namespace Module2_HW2.Sorter
{
    public interface ISort
    {
        public static void Sort(ref IConfectionery[] sweets)
        {
            Array.Sort(sweets); // plug. Since static modifier requires body
        }
    }
}
