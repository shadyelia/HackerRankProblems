using System;

namespace Arrays_Left_Rotation
{
    class Program
    {
        static int[] rotLeft(int[] a, int d)
        {
            int arrLength = a.Length;
            int[] result = new int[arrLength];

            for(int i = 0; i < a.Length; i++)
            {
                int incr = i +(arrLength - d);
                if(incr<= arrLength - 1)
                {
                    result[incr] = a[i];
                }
                else
                {
                    result[i-d] = a[i];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
