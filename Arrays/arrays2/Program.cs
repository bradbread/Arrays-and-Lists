/*
 * Created by SharpDevelop.
 * User: 102673815
 * Date: 12/04/2019
 * Time: 8:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace arrays2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculating total of all numbers!");
			
			int [] nums = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
			
			int total = 0;
			foreach(int i in nums) 
			{
				total += i;
			}
			
			Console.WriteLine("the total of all numbers is " + total);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}