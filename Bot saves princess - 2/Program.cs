using System;
using System.Linq;

class Solution
{

    static void nextMove(int n, int r, int c, String[] grid)
    {
        int x1 = r, x2 = 0, y1 = c, y2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (grid[i].Any(cha => cha == 'p'))
            {
                x2 = i;
                y2 = grid[i].IndexOf('p');
                break;
            }
        }

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
            else if (y1 > y2)
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

    static void Main(String[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());
        String pos;
        pos = Console.ReadLine();
        String[] position = pos.Split(' ');
        int[] int_pos = new int[2];
        int_pos[0] = Convert.ToInt32(position[0]);
        int_pos[1] = Convert.ToInt32(position[1]);
        String[] grid = new String[n];
        for (int i = 0; i < n; i++)
        {
            grid[i] = Console.ReadLine();
        }

        nextMove(n, int_pos[0], int_pos[1], grid);

    }
}