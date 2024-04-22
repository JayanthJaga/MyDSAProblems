namespace CSharp_DSA.Arrays
{
    class RemoveDuplicates
    {
        //*https://www.geeksforgeeks.org/problems/remove-duplicate-elements-from-sorted-array/1
        //*https://takeuforward.org/data-structure/remove-duplicates-in-place-from-sorted-array/

        public static int remove_duplicate(int[] a, int n)
        {
            //Your code here

            //Your code here
            int i = 0;
            for (int j = 1; j < n; j++)
            {
                if (a[i] != a[j])
                {
                    a[i + 1] = a[j];
                    i++;
                }
            }

            return i + 1;
        }
    }
}
