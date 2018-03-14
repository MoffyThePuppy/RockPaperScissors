/*
 * Created by SharpDevelop.
 * User: 0084216
 * Date: 3/12/2018
 * Time: 11:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RockPaperScissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Console.WriteLine("Welcome to RPS");
			Console.ReadLine();
			Console.WriteLine("Make your choie:");
			gameFunc();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void gameFunc()
		{
			Random rand = new Random();
			
			string rock = "ROCK";
			string paper = "PAPER";
			string scissors = "SCISSORS";
			string choice = Console.ReadLine();
			
			int random = rand.Next(1, 4);
			choice = choice.ToUpper();
			
			switch(random)
			{
					
				case 1:
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + rock + "./n");
						Console.WriteLine("Tie");
					}
					else if(choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + rock + "./n");
						Console.WriteLine("Winner"); 
					}
					else if(choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + rock + "./n");
						Console.WriteLine("Loser");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice");
					}
					break;
					
				case 2:
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + paper + "./n");
						Console.WriteLine("Loser");
					}
					else if(choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + paper + "./n");
						Console.WriteLine("Tie"); 
					}
					else if(choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + paper + "./n");
						Console.WriteLine("Winner");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice");
					}
					break;
					
					
				default:
					if (choice == rock)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + scissors + "./n");
						Console.WriteLine("Winner");
					}
					else if(choice == paper)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + scissors + "./n");
						Console.WriteLine("Loser"); 
					}
					else if(choice == scissors)
					{
						Console.WriteLine(choice + " <-you vs. us-> " + scissors + "./n");
						Console.WriteLine("Tie");
					}
					else
					{
						Console.WriteLine(choice + " is not a choice");
					}
					break;
					
			}
			
			Console.ReadLine();
		}
	}
}