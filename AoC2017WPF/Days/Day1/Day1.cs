using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017WPF.Days
{
    public class Day1 : IDay
    {
        public string ExecuteAdvanced()
        {
            Console.WriteLine("Day 1: Advanced");
            string input = File.ReadAllText("Days/Day1/input.txt");

            int sum = 0;
            int step = input.Length / 2;

            for (int i = 0; i < input.Length; i++)
            {
                int num = Convert.ToInt32(input[i].ToString());

                int nextNum;

                if (i + step >= input.Length)
                {
                    int index = step - ((input.Length) - i);
                    nextNum = Convert.ToInt32(input[index].ToString());
                }
                else
                {
                    nextNum = Convert.ToInt32(input[i + step].ToString());
                }

                if (num == nextNum)
                    sum += num;
            }

            string solution = "Captcha = " + sum;

            return solution;
        }

        public string ExecuteSimple()
        {
            Console.WriteLine("Day 1: Simple");
            string input = File.ReadAllText("Days/Day1/input.txt");

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int num = Convert.ToInt32(input[i].ToString());

                int nextNum;

                if (i + 1 >= input.Length)
                {
                    nextNum = Convert.ToInt32(input[0].ToString());
                }
                else
                {
                    nextNum = Convert.ToInt32(input[i + 1].ToString());
                }

                if (num == nextNum)
                    sum += num;
            }

            string solution = "Captcha = " + sum;

            return solution;
        }
    }
}
