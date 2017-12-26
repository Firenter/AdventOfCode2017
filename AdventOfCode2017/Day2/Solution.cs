using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day2
{
    public class Solution
    {
        public static void Solve()
        {
            Console.WriteLine("Day 2: Checksums");
            
            var input = File.ReadLines("Day2/inputdev.txt");

            int checksum = 0;

            foreach (string line in input)
            {
                var inputs = line.Split('\t').Select(s => Convert.ToInt32(s));

                int largest = inputs.Max();
                int smallest = inputs.Min();

                int diff = largest - smallest;

                checksum += diff;
            }

            Console.WriteLine(checksum);
        }

        public static void Solve2()
        {
            Console.WriteLine("Day 2: Row divisions");

            var input = File.ReadLines("Day2/input.txt");

            int checksum = 0;

            foreach (string line in input)
            {
                var inputs = line.Split('\t').Select(s => Convert.ToInt32(s)).ToList();

                for (int i = 0; i < inputs.Count(); i++)
                {
                    int thisone = inputs[i];

                    for (int j = 0; j < inputs.Count(); j++)
                    {
                        int thatone = inputs[j];

                        if(thisone != thatone && (thisone % thatone == 0))
                        {
                            checksum += thisone / thatone;
                        }
                    }
                }
            }

            Console.WriteLine(checksum);
        }
    }
}
