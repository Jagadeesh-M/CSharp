using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class season_sale
//https://www.codechef.com/AUG221D/problems/SALESEASON
{
	public static void Main_SeasonSale()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		for(int i = 0; i < tc; i++)
		{
			int num = Convert.ToInt32(Console.ReadLine());
			if(num <= 100)
				Console.WriteLine(num);
			else if(num <= 1000)
				Console.WriteLine(num-25);
			else if(num <= 5000)
				Console.WriteLine(num-100);
			else
				Console.WriteLine(num-500);
		}
	}
} 
}