using System;

namespace The_Time_in_Words
{
    
    class Solution {

    static string timeInWords(int h, int m) {
                
        string[] numbers = {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "quarter",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
            "twenty",
            "twenty one",
            "twenty two",
            "twenty three",
            "twenty four",
            "twenty five",
            "twenty six",
            "twenty seven",
            "twenty eight",
            "twenty nine",
            "half"
        };


        string result = "";

        if(m == 0){
            result += numbers[h-1] + " o' clock";
            return result;
        }
        else if(m == 1 ){
            result += "one minute past " + numbers[h-1];
            return result;
        }
         else if(m == 15 ){
            result += "quarter past " + numbers[h-1];
            return result;
        }
        else if(m == 30 ){
            result += "half past " + numbers[h-1];
            return result;
        }
        else if(m >0 && m < 31){
            result += numbers[m-1] + " minutes past " + numbers[h-1];
            return result;
        }
        else if(m == 45 ){
            h++;
            result += "quarter to " + numbers[h-1];
            return result;

        }
        else if(m == 59){
            h++;
            result += "one minute to " + numbers[h-1];
            return result;
        }
        else if(m>30){
            m = m - 30;
            m = 30 - m;
            h++;
            result += numbers[m-1] + " minutes to " + numbers[h-1];
            return result;
        }
        
        return result;
    }

    static void Main(string[] args) {

        int h = Convert.ToInt32(Console.ReadLine());

        int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(h, m);

        Console.WriteLine(result);
    }
}

}
