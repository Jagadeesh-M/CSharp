using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class wa_test_cases
//https://www.codechef.com/START52D/problems/WATESTCASES
{
	public static void Main_WATestCases()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		int[] output = new int[tc];
		for(int i = 0; i < tc; i++)
		{
			int N = Convert.ToInt16(Console.ReadLine());
			string tcSize = Console.ReadLine();
			int[] tcSizeArray = new int[N];
			tcSizeArray = tcSize.Split(' ').Select(Int32.Parse).ToArray();
			string tc_pf = Console.ReadLine();
			List<int> lst = new List<int>();
			for (int j = 0; j < tc_pf.Length; j++) {
				if(tc_pf[j] == '0')
					lst.Add(tcSizeArray[j]);
			}
			output[i] = lst.Min();
		}
		foreach (var item in output)
		{
			Console.WriteLine(item);
		}
	}
} 
}