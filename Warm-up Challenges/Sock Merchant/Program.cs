using System;
using System.Collections.Generic;
using System.Linq;

namespace Sock_Merchant
{
    class Program
    {
         static int sockMerchant(int n, int[] ar) {
           List<int> sellingSocks = new List<int>();
           int numberOfMatchedSocks = 0;
          
            foreach(int stock in ar){
              if(sellingSocks.Contains(stock))
                {
                    sellingSocks.Remove(sellingSocks.FirstOrDefault(item=>item == stock));
                    numberOfMatchedSocks++ ;
                }
              else
               {
                    sellingSocks.Add(stock);
               }
            }

            return sellingSocks.Count;
         }

        static void Main(string[] args)
        {
          int n = Convert.ToInt32(Console.ReadLine());

          int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
          int result = sockMerchant(n, ar);

          Console.WriteLine(result);
        }
    }
}
