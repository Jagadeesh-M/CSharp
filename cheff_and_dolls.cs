using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class cheff_and_dolls
//https://www.codechef.com/submit/MISSP
{
	public static void Main_CheffAndDolls()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		int[] output = new int[testCases];
		for(int i = 0; i < testCases; i++){
			int noOfDollsLeft = Convert.ToInt16(Console.ReadLine());
			List<int> dollsList = new List<int>();
			for(int j = 0; j < noOfDollsLeft ; j++){
				int doll = Convert.ToInt16(Console.ReadLine());
				if(dollsList.Contains(doll))
					dollsList.Remove(doll);
				else
					dollsList.Add(doll);
			}
			output[i] = dollsList[0];
		}
		foreach(int st in output){
			Console.WriteLine(st);
		}
	}
} 
}