using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class smlpal
{
	//https://www.codechef.com/START172D/problems/SMLPAL
	public static void Main_SMLPAL()
	{
		int tc = Convert.ToInt16(Console.ReadLine());
		for(int i = 0; i < tc; i++){
			string input = Console.ReadLine();
			int[] iArray = input.Split(' ').Select(Int32.Parse).ToArray(); 

			string output1 = "",output2 = "";
			for(int k = 1; k <= iArray[0]/2; k++){
				output1 += "1";
			}
			for(int l = 1; l <= iArray[1]; l++){
				output2 += "2";
			}

			Console.WriteLine(output1+output2+output1);
		}
	}

} 
}