using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDaChieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array2chieu = new string[,] { { "a", "b", "c" }, 
                {"x", "y", "z"}, { "k", "l","m"} };

            

            for(int row = 0; row < array2chieu.GetLength(0); row++) //GetLength(0) = so dong
            {
                for(int col = 0; col<array2chieu.GetLength(1); col++) //GetLength(1) = so cot
                {
                    string x = array2chieu[row, col];
                    Console.Write(x + "     ");
                }


                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
