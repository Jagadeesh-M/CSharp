using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class make_abequal
//https://www.codechef.com/AUG221D/problems/EQUALISE
{
	public static void Main_Makeabequal()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[tc];
		for(int i = 0; i < tc; i++)
		{
			string input = Console.ReadLine();
			int[] iArray = input.Split(' ').Select(Int32.Parse).ToArray();
			int maxVal = iArray.Max();
			int minVal = iArray.Min();
			int flag = 0;
			while(minVal <= maxVal){
				if(minVal == maxVal)
					{
						output[i] = "YES";
						flag = 1;
						break;
					}
				else
					minVal = minVal * 2;
			}
			if(flag == 0)
				output[i] = "NO";
		}

		foreach (var item in output)
		{
			Console.WriteLine(item);
		}
	}
} 
}