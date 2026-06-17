using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class scholarship
//https://www.codechef.com/submit/ZCOSCH
{
	public static void Main_Scholarship()
	{
        long rank = Convert.ToInt64(Console.ReadLine());
		long scholarship = rank <= 50 ? 100 : (rank <= 100 ? 50 : 0);
		Console.WriteLine(scholarship);
	}
} 
}