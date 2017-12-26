using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day1
{
    public class Solution
    {
        public static void Solve()
        {
            Console.WriteLine("Day 1: Captcha 1");
            string input = File.ReadAllText("Day1/input.txt");

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i].ToString();
                string next;

                if (i == input.Length - 1)
                {
                    next = input[0].ToString();
                }
                else
                {
                    next = input[i + 1].ToString();
                }

                if (current == next)
                {
                    sum += Convert.ToInt32(current);
                }
            }

            Console.WriteLine(sum);
        }

        public static void Solve2()
        {
            Console.WriteLine("Day 1: Captcha 2");
            string input = File.ReadAllText("Day1/input.txt");

            int sum = 0;

            int step = input.Length / 2;

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i].ToString();
                string next;

                if (i + step >= input.Length)
                {
                    int remainder = i + step - input.Length;

                    next = input[remainder].ToString();
                }
                else
                {
                    next = input[i + step].ToString();
                }

                if (current == next)
                {
                    sum += Convert.ToInt32(current);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
