namespace CSharp_DSA.Patterns
{
    public class RhombusPattern
    {
        //Pattern looks like

        //    ****
        //     ****
        //      ****
        //       ****

        public static void rhomusPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                { // this loop is for printing spaces
                    Console.Write(" ");
                }
                for (int j = 1; j <= n; j++)
                { // this loop is for printing stars
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
