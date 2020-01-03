using System;
using System.Linq;

namespace Repeated_String
{
    class Program
    {
         static long repeatedString(string s, long n) {
             long numberOfA = 0;
             if(s.Length == n){
                 numberOfA =  s.Where(chat=> chat == 'a').Count();
             }
             else if(s.Length > n){
                for(int i = 0;i<n;i++){
                    if(s[i] == 'a') numberOfA++;
                }
            }
             else {
               long numberOfRepeat = n/s.Length;
                numberOfA = numberOfRepeat * s.Where(chat=> chat == 'a').Count();

                n = n - (numberOfRepeat*s.Length);

                 for(int i = 0;i<n ;i++){
                    if(s[i] == 'a') numberOfA++;
                }
            }
             return numberOfA;
         }

        static void Main(string[] args)
        {
           string s = Console.ReadLine();

           long n = Convert.ToInt64(Console.ReadLine());

           long result = repeatedString(s, n);

           Console.WriteLine(result);
        }
    }
}
