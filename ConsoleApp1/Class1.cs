using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> funcCenter = (rows, currentRow) =>
            {
                int spaces = currentRow - 1;
                int stars = 2 * (rows - currentRow) + 1;
                string row = new string(' ', spaces) + new string('*', stars);
                return row;
            };

            Console.WriteLine(DrawTriangleZ(5, funcCenter));
        }

        static string DrawTriangleZ(int rows, Func<int, int, string> rowFunc)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += rowFunc(rows, i) + "\n";
            }

            return result;
        }
    }
}

