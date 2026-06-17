using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class tima
{
	//https://www.codechef.com/START172D/problems/TIMA
	public static void Main_TIMA()
	{
		int x = Convert.ToInt16(Console.ReadLine());
		if(x <= 2050 && x+25 >= 2050) 
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}

} 
}