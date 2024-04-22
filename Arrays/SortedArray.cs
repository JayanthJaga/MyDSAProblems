namespace CSharp_DSA.Arrays
{
    class SortedArray
    {
        public static bool sortedArray()
        {
            int[] a = { 1, 4, 3, 4, 5 };
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
