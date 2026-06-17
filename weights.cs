using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class weights
//https://www.codechef.com/START53D/problems/WGHTS
{
	public static void Main_Weights()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[tc];
		for(int x = 0; x < tc; x++)
		{
			int[] iArray = new int[4];
			string input = Console.ReadLine();
			iArray = input.Split(' ').Select(int.Parse).ToArray();
			int W = iArray[0];
			int[] weights = {iArray[1],iArray[2],iArray[3]};
			List<int> iCArray = new List<int>();
			for(int i=0; i<3; i++){
				for(int j=0; j<3; j++){
					if(i == j)
					{
						iCArray.Add(weights[i]);
					}
					else
					{
						iCArray.Add(weights[i] + weights[j]);
					}
				}
			}
			iCArray.Add(weights[0]+weights[1]+weights[2]);
			output[x] = iCArray.Contains(W) ? "YES" : "NO";
		}
		foreach (string item in output)
		{
			Console.WriteLine(item);
		}
	}

} 
}