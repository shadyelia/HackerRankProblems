using System;

namespace Strange_Counter
{
    class Program
    {
        static void strangeCounter(long t) {
            int cycleNumber = 1;
            long startNumberOfCycle = 1;
            long startValueOfCycle = 3;
          
            for(long i = 3 ; i< long.MaxValue; i *= 2){
                startNumberOfCycle += i ;
                if (t - startNumberOfCycle >= 0) cycleNumber++;  
                else {
                    startValueOfCycle = i;
                    startNumberOfCycle -= i ;
                    break;   
                }   
            }
          long result = startValueOfCycle - (t-startNumberOfCycle) ; 
          Console.WriteLine(result);

        }

        static void Main(string[] args)
        {
          long t = Convert.ToInt64(Console.ReadLine());

          strangeCounter(t);
        }
    }
}
