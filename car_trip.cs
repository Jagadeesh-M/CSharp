using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class car_trip
//https://www.codechef.com/START53D/problems/CARTRIP
{
	public static void Main_CarTrip()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		int[] output = new int[tc];
		for(int i = 0; i < tc; i++)
		{
			int num = Convert.ToInt16(Console.ReadLine());
			output[i] = num <= 300 ? 3000 : num * 10;
		}
		foreach (int item in output)
		{
			Console.WriteLine(item);
		}
	}

} 
}