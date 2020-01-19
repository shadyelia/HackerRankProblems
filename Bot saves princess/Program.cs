using System;
using System.Linq;

class Solution
{

    static void displayPathtoPrincess(int n, String[] grid)
    {
        int x1 = -1, x2 = -1, y1 = -1, y2 = -1;
        for (int i = 0; i < n; i++)
        {
            string s = grid[i];
            if(s.Any(r => r == 'm'))
            {
                x1 = i;
                y1 = grid[i].IndexOf('m');
            }
            if (s.Any(r => r == 'p'))
            {
                x2 = i;
                y2 = grid[i].IndexOf('p');
            }
            if (x1 != -1 && x2 != -1 && y1 != -1 && y2 != -1) break; 
        }

        while (x1 != x2 || y1 != y2)
        {
             if (x1 > x2)
            {
                x1--;
                Console.WriteLine("UP");
            }
            else if (x1 < x2)
            {
                x1++;
                Console.WriteLine("DOWN");
            }
            else if(y1 > y2)
            {
                y1--;
                Console.WriteLine("LEFT");
            }
            else if (y1 < y2)
            {
                y1++;
                Console.WriteLine("RIGHT");
            }
            
        }
    }

    static void Main(String[] args)
    {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid = new String[m];
        for (int i = 0; i < m; i++)
        {
            grid[i] = Console.ReadLine();
        }

        displayPathtoPrincess(m, grid);
    }
}