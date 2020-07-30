using System;
using System.IO;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputAge = int.Parse(Console.ReadLine());

            string typePerson = "";

            if (inputAge >= 0 && inputAge <= 2)
            {
                typePerson = "baby";
            }
            else if (inputAge >= 3 && inputAge <= 13)
            {
                typePerson = "child";
            }
            else if (inputAge >= 14 && inputAge <= 19)
            {
                typePerson = "teenager";
            }
            else if (inputAge >= 20 && inputAge <= 65)
            {
                typePerson = "adult";
            }
            else if (inputAge >= 66)
            {
                typePerson = "elder";
            }


            Console.WriteLine(typePerson);

        }
    }
}
