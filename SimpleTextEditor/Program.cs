using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCases = Convert.ToInt32(Console.ReadLine());
            Stack<string> S = new Stack<string>();
            string currentState = "";

            for (int i = 0; i < numberOfCases; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int Q = Convert.ToInt32(line[0]);
                if (Q == 1)
                {
                    currentState += line[1];
                    S.Push(currentState);
                }
                else if (Q == 2)
                {
                    int numberOfDeletingChat = Convert.ToInt32(line[1]);
                    currentState = currentState.Remove(currentState.Length - numberOfDeletingChat, numberOfDeletingChat);
                    S.Push(currentState);
                }
                else if (Q == 3)
                {
                    int k = Convert.ToInt32(line[1]);
                    Console.WriteLine(currentState[k - 1]);
                }
                else if (Q == 4)
                {
                    S.Pop();
                    if (S.Count > 0)
                        currentState = S.Peek();
                    else
                        currentState = "";
                }
            }

        }
    }
}
