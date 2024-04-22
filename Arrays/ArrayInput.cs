namespace CSharp_DSA.Arrays
{
    class ArrayInput
    {
        public static void arrayInput(int n)
        {
            System.Console.WriteLine("Enter elements");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Elements are :");

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
