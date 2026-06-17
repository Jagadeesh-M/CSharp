using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class maximum_submissions
//https://www.codechef.com/submit/AUG221D
{
	public static void Main_MaximumSubmissions()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		for(int i = 0; i < tc; i++)
		{
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(num * 2);
		}
	}
} 
}