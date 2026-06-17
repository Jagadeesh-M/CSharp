using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class discount
//https://www.codechef.com/submit/DISCNT
{
	public static void Main_Discount()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		for(int i = 0; i < testCases; i++){
			int discount = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine(100 - discount);
		}
	}
} 
}