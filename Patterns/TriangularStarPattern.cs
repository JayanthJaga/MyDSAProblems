namespace CSharp_DSA.Patterns
{
    class TriangularStarPattern
    {
        //Pattern looks like
        //  *
        //  **
        //  ***
        //  ****
        public static void triangularStarPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
