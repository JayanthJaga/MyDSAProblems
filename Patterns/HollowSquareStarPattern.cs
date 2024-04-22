using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DSA.Patterns
{

    //Pattern looks like below

       //****
       //*  *
       //*  *
       //****

    public class HollowSquareStarPattern
    {
        public static void squarePattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j==1 || j==n)
                    Console.Write("*");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

