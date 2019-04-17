/*
 * Created by SharpDevelop.
 * User: 102673815
 * Date: 12/04/2019
 * Time: 8:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			String [] usernames = new string[5];
			for (int i = 0; i < usernames.Length; i++)
			{
				Console.WriteLine("Please enter a user name");
				usernames[i] = Console.ReadLine();
			}
			
			for (int i = 0; i < usernames.Length; i++)
			{
				Console.WriteLine("Hello " + usernames[i]);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}