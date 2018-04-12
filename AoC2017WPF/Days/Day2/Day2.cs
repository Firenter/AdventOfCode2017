using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017WPF.Days
{
    public class Day2 : IDay
    {
        public string ExecuteAdvanced()
        {
            Console.WriteLine("Day 2: Advanced");
            IEnumerable<string> input = File.ReadLines("Days/Day2/input.txt");

            int checkSum = 0;

            foreach (string line in input)
            {
                string[] separator = new string[] { " " };
                string[] numbers = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                List<int> nummers = new List<int>();

                foreach (string num in numbers)
                {
                    nummers.Add(Convert.ToInt32(num));
                }

                foreach (int n in nummers)
                {
                    foreach (int q in nummers)
                    {
                        if(n != q && n % q == 0)
                        {
                            checkSum += n / q;
                        }
                    }
                }
            }

            return "Checksum = " + checkSum;
        }

        public string ExecuteSimple()
        {
            Console.WriteLine("Day 2: Simple");
            IEnumerable<string> input = File.ReadLines("Days/Day2/input.txt");

            int checkSum = 0;

            foreach (string line in input)
            {
                string[] separator = new string[] { " " };
                string[] numbers = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                List<int> nummers = new List<int>();

                foreach (string num in numbers)
                {
                    nummers.Add(Convert.ToInt32(num));
                }

                int lineHighest = nummers.Max();
                int lineLowest = nummers.Min();

                int lineDiff = lineHighest - lineLowest;

                checkSum += lineDiff;
            }

            return "Checksum = " + checkSum;
        }
    }
}
