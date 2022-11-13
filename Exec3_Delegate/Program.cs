using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int>{2, 4, 89, 61, 45, 34, 22,
											75, 18, 97, 53, 12, 17, 28};
			Func<int, bool> isEven = n => n % 2 == 0;
			List<int> items2 = GetEvenItems(items, isEven);
			items2.ForEach(Console.WriteLine);
		}
		static List<int> GetEvenItems(List<int> ints, Func<int, bool> func)
		{
			var result = new List<int>();
			foreach (int number in ints)
			{
				if (func(number))
				{
					result.Add(number);
				}
			}
			return result;
		}
	}
}
