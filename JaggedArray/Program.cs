using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[] {"a", "b", "c"};
            jaggedArray[1] = new string[] { "k", "h", "l", "m","p" };
            jaggedArray[2] = new string[] { "z"};

            for (int row = 0; row < jaggedArray.Length; row++)//jaggedArray.Length: lay so cot
            {
                for (int col = 0; col < jaggedArray[row].Length; col++) //jaggedArray[row].Length = So cot o hang row
                {
                    Console.Write(jaggedArray[row][col] + "     ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadLine();




        }
    }
}