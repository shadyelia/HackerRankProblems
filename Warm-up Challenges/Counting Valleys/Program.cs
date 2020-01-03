using System;

namespace Counting_Valleys
{
    class Program
    {
     static int countingValleys(int n, string s) {
         int numberOfValleys = 0 , startLevel = 0;
         bool isInValley = false;

         foreach(char step in s){
             if(step == 'U') startLevel++;
             else  startLevel--;
             
             if(startLevel < 0) isInValley = true;
             else if(startLevel == 0 && isInValley) { 
                 numberOfValleys++;
                 isInValley = false;
             }
         }

         return numberOfValleys;
        }
     
     static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);

      }

    }
}
