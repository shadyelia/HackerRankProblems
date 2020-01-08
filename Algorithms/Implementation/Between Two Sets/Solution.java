import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    public static int getTotalX(List<Integer> a, List<Integer> b)
    {
        int maxElementInB = getMaxElement(b);
        List<Integer> divisableElementsByA = getDivisableByArray(a, maxElementInB);
        int res = divisableElementsByA.size();
        for(int i=0;i<divisableElementsByA.size();i++) {
            boolean isAllDivisable = true;
            for(int j=0;j<b.size();j++) {
                if(b.get(j) % divisableElementsByA.get(i) != 0) {
                    isAllDivisable = false;
                    break;
                }
            }
            if(!isAllDivisable)
                res--;
        }
        return res;
    }

    private static int getMaxElement(List<Integer> arr) {
        int max = 0;
        for(int i=0;i<arr.size();i++) {
            if(arr.get(i) > max)
                max = arr.get(i);
        }
        return max;
    }

    private static List<Integer> getDivisableByArray(List<Integer> arr, int max) {
        List<Integer> res = new ArrayList<Integer>();
        int gcdOfAll = 1;
        for(int i=0;i<arr.size();i++) {
            int currentGcd = gcd(min(gcdOfAll,arr.get(i)), max(gcdOfAll,arr.get(i)));
            gcdOfAll *= (arr.get(i) / currentGcd);
        }

        int start = gcdOfAll;
        while(start <= max) {
            res.add(start);
            start += gcdOfAll;
        }

        return res;
    }

    private static int gcd(int a, int b) {
        if(a == 0)
            return b;
        return gcd(b % a, a);
    }

    private static int min(int a, int b) {
        return a < b ? a : b;
    }

    private static int max(int a, int b) {
        return a > b ? a : b;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        int n = Integer.parseInt(firstMultipleInput[0]);

        int m = Integer.parseInt(firstMultipleInput[1]);

        String[] arrTemp = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        List<Integer> arr = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrTemp[i]);
            arr.add(arrItem);
        }

        String[] brrTemp = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        List<Integer> brr = new ArrayList<>();

        for (int i = 0; i < m; i++) {
            int brrItem = Integer.parseInt(brrTemp[i]);
            brr.add(brrItem);
        }

        int total = Result.getTotalX(arr, brr);

        bufferedWriter.write(String.valueOf(total));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
