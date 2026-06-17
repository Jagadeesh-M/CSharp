using System;
using System.Collections;
using System.Linq;

namespace CodeChefProblems {
public class zooz
//https://www.codechef.com/submit/ZOOZ
{
	public static void Main_Zooz()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		string[] output = new string[testCases];
		for(int i = 0; i < testCases; i++){
			int input = Convert.ToInt16(Console.ReadLine());
			string str = new string('0',input-2);
			output[i] = "1" + str + "1";
		}
		foreach(string st in output){
			Console.WriteLine(st);
		}
	}
} 
}