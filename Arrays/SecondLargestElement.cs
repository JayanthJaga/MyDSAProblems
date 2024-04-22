namespace CSharp_DSA.Arrays
{
    class SecondLargestElement
    {
        public static void secondLargest()
        { //*Bruteforce approach
            // int[] a = { 3, 1, 4, 9, 17 };
            // Array.Sort(a);
            //System.Console.WriteLine(a.Length);
            // int secondLargest = a[a.Length - 2]; //bcz array index starts from 0
            // System.Console.WriteLine("Second Largest {0}", secondLargest);

            //*Better approach

            // int[] a = { 3, 1, 4, 9, 17 };
            // int largest = a[0],
            //     second_largest = -1; //Assuming no -ve numbers in an array
            // for (int i = 0; i < a.Length; i++)
            // {
            //     if (a[i] > largest)
            //     {
            //         largest = a[i];
            //     }
            // }

            // for (int i = 0; i < a.Length; i++)
            // {
            //     if (a[i] > second_largest && a[i] != largest)
            //     {
            //         second_largest = a[i];
            //     }
            // }
            // System.Console.WriteLine("Second Largest {0}", second_largest);
        }

        //*Optimal Approach

        public static void print2largest(int[] arr, int arr_size)
        {
            int i,
                first,
                second;

            // There should be atleast two elements
            if (arr_size < 2)
            {
                Console.WriteLine(" Invalid Input ");
                return;
            }

            first = second = int.MinValue;
            for (i = 0; i < arr_size; i++)
            {
                // If current element is smaller than
                // first then update both first and second
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second && arr[i] != first)
                    second = arr[i];
            }

            if (second == int.MinValue)
                Console.Write("There is no second largest" + " element\n");
            else
                Console.Write("The second largest element" + " is " + second);
        }
    }
}
