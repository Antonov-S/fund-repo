using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialBombNumber = bombData[0];
            int power = bombData[1];

            int bombIndex = list.IndexOf(specialBombNumber);
                        

            while (bombIndex != -1)
            {
                int leftIndex = bombIndex - power;
                int rightIndex = bombIndex + power;

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }
                if (rightIndex > list.Count - 1)
                {
                    rightIndex = list.Count - 1;
                }

                list.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
                bombIndex = list.IndexOf(specialBombNumber);

            }

            int sum = list.Sum();
            
            Console.WriteLine(sum);
            

        }
    }
}
