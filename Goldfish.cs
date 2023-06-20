using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading;

public class ABOBA
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int i = 0; i < num; i++)
        {
            words.Add(Console.ReadLine());
        }

        int num_start = int.Parse(Console.ReadLine());
        Dictionary<string, int> starts = new Dictionary<string, int>();

        for (int i = 0; i < num_start; i++)
        {
            string[] temp = Console.ReadLine().Split();
            starts.Add(temp[0], int.Parse(temp[1]));
        }

        int num_end = int.Parse(Console.ReadLine());
        Dictionary<string, int> endings = new Dictionary<string, int>();

        for (int i = 0; i < num_end; i++)
        {
            string[] temp = Console.ReadLine().Split();
            endings.Add(temp[0], int.Parse(temp[1]));
        }

        List<string> result = new List<string>();

        foreach (string word in words)
        {
            foreach (var item in starts)
            {
                if (item.Value != 0)
                {
                    foreach (var item1 in endings)
                    {
                        if (item1.Value != 0)
                        {
                            if (Convert.ToString(word[0]) == item.Key && Convert.ToString(word[word.Length - 1]) == item1.Key)
                            {
                                result.Add(word);
                            }
                            else {continue;}
                        }
                        else { continue; }
                    }
                }
                else { continue; }
            }
        }

        Console.WriteLine(result.Count);
    }
}
