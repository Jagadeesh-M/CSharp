using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChefProblems {
public class atm_machine
//https://www.codechef.com/submit/ATM2
{
	public static void Main_AtmMachine()
	{
        int testCases = Convert.ToInt16(Console.ReadLine());
		for(int i = 0; i < testCases; i++){
			string inp1 = Console.ReadLine();
			string inp2 = Console.ReadLine();
			int noOfPeopleInQueue,moneyInATM;
			int[] inp1Array = inp1.Split(' ').Select(Int32.Parse).ToArray();
			int[] withdrawels = inp2.Split(' ').Select(Int32.Parse).ToArray();
			noOfPeopleInQueue = inp1Array[0];
			moneyInATM = inp1Array[1];
			int[] withdrawels_Status = new int[withdrawels.Length];
			for(int w = 0; w < withdrawels.Length; w++){
				if(withdrawels[w] <= moneyInATM){
					moneyInATM -= withdrawels[w];
					withdrawels_Status[w] = 1;
				}
				else{
					withdrawels_Status[w] = 0;
				}
			}
			//Console.WriteLine(String.Join('',withdrawels_Status));
			Console.WriteLine(withdrawels_Status.Aggregate(string.Empty, (s, j) => s + j));
		}
	}
} 
}