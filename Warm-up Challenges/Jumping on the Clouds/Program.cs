using System;

namespace Jumping_on_the_Clouds
{
    class Program
    {
         static int jumpingOnClouds(int[] c) {
             int numberOfJumps = 0, step = 2 , length = c.Length-1;

             for(int i = 0; i < length; i+= step){
                if(i+2 <= length && c[i+2] == 0) step = 2; 
                else step = 1;
                numberOfJumps++;
             }

             return numberOfJumps;
         }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}
