using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class air_conditioner_temp
//https://www.codechef.com/START52D/problems/ACTEMP
{
	public static void Main_AirConditionerTemp()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[tc];
		for(int i = 0; i < tc; i++)
		{
			string input = Console.ReadLine();
			int[] iArray = input.Split(' ').Select(Int32.Parse).ToArray();
			output[i] = Math.Max(iArray[0],iArray[2]) <= iArray[1] ? "YES" : "NO";
		}
		foreach (var item in output)
		{
			Console.WriteLine(item);
		}
	}
} 
}