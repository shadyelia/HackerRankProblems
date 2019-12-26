using System;
using System.Collections.Generic;
using System.Linq;

namespace Bon_Appétit
{
    class Program
    {
        static void bonAppetit(int numberOfItems, List<int> bill, int k, int b) {
            int sum = 0;

            for (int i=0; i<numberOfItems; i++) {
                if(i != k) sum += bill[i]; 
            }
        
            sum = sum / 2;
            if(b-sum == 0) Console.WriteLine("Bon Appetit");
            else Console.WriteLine(b-sum);
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(n, bill, k, b);
        }
    }
}
