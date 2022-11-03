namespace Module2_HW2.Sorter
{
    public class SortByWeightClient : ISort
    {
        public static void Sort(ref IConfectionery[] sweets)
        {
            double[] arr = new double[sweets.Length];

            for (int i = 0; i < sweets.Length; i++)
            {
                arr[i] = sweets[i].WeightKg;
            }

            Array.Sort(arr);

            IConfectionery[] temp = new IConfectionery[sweets.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                foreach (IConfectionery conf in sweets)
                {
                    if (arr[i] == conf.WeightKg)
                    {
                        temp[i] = conf;
                    }
                }
            }

            sweets = temp;
        }
    }
}
