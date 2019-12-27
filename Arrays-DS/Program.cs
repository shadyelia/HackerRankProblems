using System;

namespace Arrays_DS
{
    class Program
    {
        static int[] reverseArray(int[] a) {
            
            int[] result = new int[a.Length];
            int counter = 0;
            
            for(int i=a.Length-1; i>=0; i--){
                result[counter] = a[i];
                counter++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", res));
        }
    }
}
