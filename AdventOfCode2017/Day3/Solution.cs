using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day3
{
    public class Solution
    {
        public static void Solve()
        {
            Console.WriteLine("Day 3: Manhattan distance");
            string input = File.ReadAllText("Day3/input.txt");

            //copied from: https://www.reddit.com/r/adventofcode/comments/7h7ufl/2017_day_3_solutions/dqva5nm/
            int value = Convert.ToInt32(input);
            int index = 0;
            int count = 1;

            if (value != 1)
            {
                //calculate spiral size
                while (count * count < value)
                {
                    count += 2;
                    index++;
                }

                //calculate manhattan distance
                int result = Math.Abs(index - ((count * count - value) % (count - 1)));
                Console.WriteLine(result + index);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        public static void Solve2()
        {
            Console.WriteLine("Day 3: Assignment 2");
            string input = File.ReadAllText("Day3/input.txt");

            //copied from: https://www.reddit.com/r/adventofcode/comments/7h7ufl/2017_day_3_solutions/dqva5nm/

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);

            int value = Convert.ToInt32(input);

            int index = 2;
            int currentCorner = 2;
            int nextCorner = 2;
            int cornerIndex = 1;

            while (true)
            {
                list.Add(list[index - 1]);

                if (nextCorner == index)
                {
                    list[index] += list[index - (cornerIndex * 2)];
                    currentCorner = nextCorner;
                    cornerIndex++;
                    int nextCornerIndex = cornerIndex + 1;
                    nextCorner = (nextCornerIndex + nextCornerIndex % 2) * (nextCornerIndex + 2 - nextCornerIndex % 2) / 4;
                }
                else
                {
                    if (index == currentCorner + 1)
                    {
                        list[index] += list[index - 2];
                    }
                    else
                    {
                        list[index] += list[index - (cornerIndex * 2)];
                    }

                    list[index] += list[index - (cornerIndex * 2 - 1)];

                    if (index != nextCorner - 1)
                    {
                        list[index] += list[index - (cornerIndex * 2 - 2)];
                    }
                }

                if (list[index] > value)
                    break;
                index++;
            }

            Console.WriteLine(list[index]);
        }
    }
}
