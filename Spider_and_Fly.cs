using System;
using System.Linq;

public class ConsoleApp4
{
    public static void Main()
    {
        double result, min_dist1, min_dist2, min_dist3, min_dist4, min_dist_res;
        double[] Cube = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] Spider = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] Fly = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        if ((Cube[0] == Spider[0] && Cube[0] == Fly[0]) || (0 == Spider[0] && 0 == Fly[0]))
        {
            result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2));
            Console.WriteLine(Math.Round(result, 3));
        }
        else if ((Cube[1] == Spider[1] && Cube[1] == Fly[1]) || (0 == Spider[1] && 0 == Fly[1]))
        {
            result = Math.Sqrt(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2));
            Console.WriteLine(Math.Round(result, 3));
        }
        else if ((Cube[2] == Spider[2] && Cube[2] == Fly[2]) || (0 == Spider[2] && 0 == Fly[2]))
        {
            result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2));
            Console.WriteLine(Math.Round(result, 3));
        }
        else if ((Cube[0] == Spider[0] && 0 == Fly[0]) || (Cube[0] == Fly[0] && 0 == Spider[0]))
        {
            min_dist1 = Spider[1] + Fly[1];
            min_dist2 = (Cube[1] - Spider[1]) + (Cube[1] - Fly[1]);
            min_dist3 = Spider[2] + Fly[2];
            min_dist4 = (Cube[2] - Spider[2]) + (Cube[2] - Fly[2]);
            if (min_dist1 <= min_dist2 && min_dist1 <= min_dist3 && min_dist1 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2) + Math.Pow(Math.Abs(Spider[1] + Fly[1] + Cube[0]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist2 <= min_dist1 && min_dist2 <= min_dist3 && min_dist2 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2) + Math.Pow(Math.Abs(Cube[1] - Spider[1] + Cube[1] - Fly[1] + Cube[0]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist3 <= min_dist1 && min_dist3 <= min_dist2 && min_dist3 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[2] + Fly[2] + Cube[0]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist4 <= min_dist1 && min_dist4 <= min_dist3 && min_dist4 <= min_dist2)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Cube[2] - Spider[2] + Cube[2] - Fly[2] + Cube[0]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if ((Cube[1] == Spider[1] && 0 == Fly[1]) || (Cube[1] == Fly[1] && 0 == Spider[1]))
        {
            min_dist1 = Spider[0] + Fly[0];
            min_dist2 = (Cube[0] - Spider[0]) + (Cube[0] - Fly[0]);
            min_dist3 = Spider[2] + Fly[2];
            min_dist4 = (Cube[2] - Spider[2]) + (Cube[2] - Fly[2]);
            if (min_dist1 <= min_dist2 && min_dist1 <= min_dist3 && min_dist1 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2) + Math.Pow(Math.Abs(Spider[0] + Fly[0] + Cube[1]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist2 <= min_dist1 && min_dist2 <= min_dist3 && min_dist2 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2) + Math.Pow(Math.Abs(Cube[0] - Spider[0] + Cube[0] - Fly[0] + Cube[1]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist3 <= min_dist1 && min_dist3 <= min_dist2 && min_dist3 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[2] + Fly[2] + Cube[1]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist4 <= min_dist1 && min_dist4 <= min_dist3 && min_dist4 <= min_dist2)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Cube[2] - Spider[2] + Cube[2] - Fly[2] + Cube[1]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if ((Cube[2] == Spider[2] && 0 == Fly[2]) || (Cube[2] == Fly[2] && 0 == Spider[2]))
        {
            min_dist1 = Spider[0] + Fly[0];
            min_dist2 = (Cube[0] - Spider[0]) + (Cube[0] - Fly[0]);
            min_dist3 = Spider[1] + Fly[1];
            min_dist4 = (Cube[1] - Spider[1]) + (Cube[1] - Fly[1]);
            if (min_dist1 <= min_dist2 && min_dist1 <= min_dist3 && min_dist1 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[0] + Fly[0] + Cube[2]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist2 <= min_dist1 && min_dist2 <= min_dist3 && min_dist2 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Cube[0] - Spider[0] + Cube[0] - Fly[0] + Cube[2]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist3 <= min_dist1 && min_dist3 <= min_dist2 && min_dist3 <= min_dist4)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[1] + Fly[1] + Cube[2]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (min_dist4 <= min_dist1 && min_dist4 <= min_dist3 && min_dist4 <= min_dist2)
            {
                result = Math.Sqrt(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Cube[1] - Spider[1] + Cube[1] - Fly[1] + Cube[2]), 2));
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if (Spider[0] == 0)
        {
            if ((Fly[1] == 0) || (Fly[1] == Cube[1]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[1] - Fly[1]) + Fly[0], 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]) + Fly[0], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if (Spider[0] == Cube[0])
        {
            if ((Fly[1] == 0) || (Fly[1] == Cube[1]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[1] - Fly[1]) + Cube[0] - Fly[0], 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]) + Cube[0] - Fly[0], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if (Spider[1] == 0)
        {
            if ((Fly[0] == 0) || (Fly[0] == Cube[0]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]) + Fly[1], 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]) + Fly[1], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if (Spider[1] == Cube[1])
        {
            if ((Fly[0] == 0) || (Fly[0] == Cube[0]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]) + Cube[1] - Fly[1], 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[2] - Fly[2]) + Cube[1] - Fly[1], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }

        }
        else if (Spider[2] == 0)
        {
            if ((Fly[0] == 0) || (Fly[0] == Cube[0]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]) + Fly[2], 2) + Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[1] - Fly[1]) + Fly[2], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
        }
        else if (Spider[2] == Cube[2])
        {
            if ((Fly[0] == 0) || (Fly[0] == Cube[0]))
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]) + Cube[2] - Fly[2], 2) + Math.Pow(Math.Abs(Spider[1] - Fly[1]), 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }
            else
            {
                result = Math.Pow(Math.Pow(Math.Abs(Spider[0] - Fly[0]), 2) + Math.Pow(Math.Abs(Spider[1] - Fly[1]) + Cube[2] - Fly[2], 2), 0.5);
                Console.WriteLine(Math.Round(result, 3));
            }

        }
    }
}
