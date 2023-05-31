using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(Triangle.DrawLeftTriangle(5));
			Console.WriteLine(Triangle.DrawRightTriangle(5));
			Console.WriteLine(Triangle.DrawCenterTriangle(5));
			Console.WriteLine(Triangle.DrawInvertedLeftTriangle(5));
			Console.WriteLine(Triangle.DrawInvertedRightTriangle(5));
			Console.WriteLine(Triangle.DrawInvertedCenterTriangle(5));
		}
	}

	public class Triangle
	{
		public static string DrawLeftTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string('*', c));
		}

		public static string DrawRightTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string('*', c).PadLeft(r));
		}

		public static string DrawCenterTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string(' ', r - c) + new string('*', 2 * c - 1));
		}

		public static string DrawInvertedLeftTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string('*', r - c + 1));
		}

		public static string DrawInvertedRightTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string('*', r - c + 1).PadLeft(r));
		}

		public static string DrawInvertedCenterTriangle(int rows)
		{
			return DrawTriangle(rows, (r, c) => new string(' ', c - 1) + new string('*', 2 * (r - c) + 1));
		}

		private static string DrawTriangle(int rows, Func<int, int, string> rowGenerator)
		{
			// precondition checks
			if (rows < 1) return string.Empty;
			if (rowGenerator == null) return string.Empty;

			var result = string.Empty;

			for (var i = 1; i <= rows; i++) result += rowGenerator(rows, i) + "\n";

			return result;
		}
	}
}