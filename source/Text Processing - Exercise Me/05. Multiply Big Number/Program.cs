using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string realyBigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (realyBigNum[0] == '0')
            {
                realyBigNum = realyBigNum.Substring(1);
            }

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = realyBigNum.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(realyBigNum[i].ToString()) * num + remainder;
                remainder = 0;

                if (result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder finalResult = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }
            Console.WriteLine(finalResult);


        }
    }
}
