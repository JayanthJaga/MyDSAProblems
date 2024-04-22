namespace CSharp_DSA.Patterns
{
    //Pattern looks like
    //        ****
    //      ****
    //     ****
    //   ****
    class MirroredRhombus
    {
        public static void mirroredRhombus(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
