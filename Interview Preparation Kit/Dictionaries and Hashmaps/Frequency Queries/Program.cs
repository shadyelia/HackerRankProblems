using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<string> queries)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> data = new Dictionary<int, int>();
        Dictionary<int, int> freq = new Dictionary<int, int>();
        for (int i = 0; i < queries.Count; i++)
        {
            var input = queries[i].Split(' ');
            var currentChoose = Int32.Parse(input[0]);
            var currentValue = Int32.Parse(input[1]);

            if (currentChoose == 1)
            {
                if (data.ContainsKey(currentValue))
                {
                    var oldValue = data[currentValue];
                    data[currentValue] = oldValue + 1;

                    freq[oldValue] = --freq[oldValue];
                    oldValue++;
                    if (freq.ContainsKey(oldValue)) freq[oldValue] = ++freq[oldValue];
                    else freq.Add(oldValue, 1);
                }
                else
                {
                    data.Add(currentValue, 1);
                    if (freq.ContainsKey(1)) freq[1] = ++freq[1];
                    else freq.Add(1, 1);
                }
            }
            else if (currentChoose == 2)
            {
                if (data.ContainsKey(currentValue))
                {
                    var oldValue = data[currentValue];
                    data[currentValue] = oldValue-1;

                    freq[oldValue] = --freq[oldValue];
                    oldValue--;
                    if (freq.ContainsKey(oldValue)) freq[oldValue] = ++freq[oldValue];
                    else freq.Add(oldValue, 1);
                }
            }
            else if (currentChoose == 3)
            {
                result.Add(freq.ContainsKey(currentValue) ? 1 : 0);
            }
        }

        return result;
    }

    static void Main()
    {

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().Trim());
        }

        List<int> ans = freqQuery(queries);

        Console.WriteLine(String.Join("\n", ans));
    }
}
