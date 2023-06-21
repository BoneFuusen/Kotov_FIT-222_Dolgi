using System;
using System.Collections.Generic;


public class ABOBA
{
    public static void Main()
    {
        string answer = "";

        Console.WriteLine("Введите кол-во действий"); int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] step = Console.ReadLine().Split(' ');

            if (step[0] == "MIX")
            {
                answer = "MX" + answer;
                for (int j = 1; j < step.Length; j++)
                {
                    int temp;
                    if (int.TryParse(step[j], out temp) == false)
                    {
                        answer += step[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                answer += "XM";
            }
            if (step[0] == "WATER")
            {
                answer = "WT" + answer;
                for (int j = 1; j < step.Length; j++)
                {
                    int temp;
                    if (int.TryParse(step[j], out temp) == false)
                    {
                        answer += step[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                answer += "TW";
            }
            if (step[0] == "DUST")
            {
                answer = "DT" + answer;
                for (int j = 1; j < step.Length; j++)
                {
                    int temp;
                    if (int.TryParse(step[j], out temp) == false)
                    {
                        answer += step[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                answer += "TD";
            }
            if (step[0] == "FIRE")
            {
                answer = "FR" + answer;
                for (int j = 1; j < step.Length; j++)
                {
                    int temp;
                    if (int.TryParse(step[j], out temp) == false)
                    {
                        answer += step[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                answer += "RF";
            }
        }
        Console.WriteLine(answer);
    }
}
