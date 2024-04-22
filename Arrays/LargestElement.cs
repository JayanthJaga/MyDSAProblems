namespace CSharp_DSA.Arrays
{
    class LargestElement
    {
        public static void largestElement()
        {
            System.Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            System.Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }
            System.Console.WriteLine("Largest element is {0}", largest);
        }
    }
}
