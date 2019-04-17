/*
 * Created by SharpDevelop.
 * User: Bradley
 * Date: 17-Apr-19
 * Time: 12:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Lists
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("This program will ask you to enter a number 5 times then once more and tell you if that number was entered as part of the first five");
			
			
			List<int> numbers = new List<int>();
			
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Please enter a number");
				numbers.Add(Convert.ToInt32(Console.ReadLine()));
				
			}
			
			Console.WriteLine("please enter a number to see if you have entered it before");
			int temp = Convert.ToInt32(Console.ReadLine());
			
			//using count for ease of completing part 2
			int count = 0;
			
			foreach (int a in numbers) 
			{
				if (a == temp) 
				{
					count++;
				}
			}
			
			if(count > 0) 
			{
				Console.WriteLine(temp + " has already been entered");
			}
			else
			{
				Console.WriteLine(temp + " has not been entered before");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}