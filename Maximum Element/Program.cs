using System;
using System.Collections.Generic;

namespace Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCases = Convert.ToInt32(Console.ReadLine());
            Stack<int> S = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            for (int i = 0; i < numberOfCases; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int Q = Convert.ToInt32(line[0]);
                if (Q == 1)
                {
                    int newNumber = Convert.ToInt32(line[1]);

                    if (S.Count == 0)
                    {
                        S.Push(newNumber);
                        maxStack.Push(newNumber);
                    }
                    else
                    {
                        S.Push(newNumber);
                        int maxInt = maxStack.Peek();
                        if (newNumber > maxInt)
                        {
                            maxStack.Push(newNumber);
                        }
                        else
                        {
                            maxStack.Push(maxInt);
                        }
                    }
                }
                else if (Q == 2)
                {
                    S.Pop();
                    maxStack.Pop();
                }
                else if (Q == 3)
                {
                    int maxInt = maxStack.Peek();
                    Console.WriteLine(maxInt);
                }
            }

        }
    }
}
