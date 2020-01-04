using System;
using System.Collections;

namespace Hash_Tables_Ransom_Note
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable magazineDic = new Hashtable();
            foreach (var word in magazine)
            {
                int key = 1;

                if (magazineDic[word] != null)
                {
                    key = Convert.ToInt32(magazineDic[word]) + 1;
                    magazineDic[word] = key;
                }
                else magazineDic.Add(word, key);
            }

            foreach (string word in note)
            {
                var isExist = Convert.ToInt32(magazineDic[word]);
                if (isExist > 0)
                {
                    magazineDic[word] = isExist - 1;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

        static void Main(string[] args)
        {
            string mn = Console.ReadLine();

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
