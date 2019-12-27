using System;

namespace _2D_Array_DS
{
    class Program
    {
        static int hourglassSum(int[][] arr) {
            int sum = 0 ,maxSum = Int32.MinValue;
            
            for(int i=1; i<5; i++){
                for(int j=1; j<5; j++){
                    sum = arr[i][j] +
                          arr[i-1][j] +
                          arr[i+1][j] + 
                          arr[i-1][j-1] +
                          arr[i-1][j+1] +
                          arr[i+1][j-1] + 
                          arr[i+1][j+1];
                    if(sum > maxSum) maxSum = sum;   
                }
            }

            return maxSum; 
        }

        static void Main(string[] args)
        {
           int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}
