using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] train = new int[num];

            for (int i = 0; i < train.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                train[i] += input;
            }

            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                sum += train[i];
            }

            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);



        }
    }
}
