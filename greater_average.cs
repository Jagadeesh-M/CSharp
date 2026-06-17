using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class greater_average
//https://www.codechef.com/START53D/problems/AVGPROBLEM
{
	public static void Main_GreaterAverage()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[tc];
		for(int i = 0; i < tc; i++)
		{
			double[] iArray = new double[3];
			string input = Console.ReadLine();
			iArray = input.Split(' ').Select(double.Parse).ToArray();
			output[i] = ((iArray[0] + iArray[1])/2 > iArray[2]) ? "YES" : "NO" ;
		}
		foreach (string item in output)
		{
			Console.WriteLine(item);
		}
	}

} 
}