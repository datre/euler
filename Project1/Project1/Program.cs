using System;

namespace Project1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while(true)
			{
				Console.WriteLine ("Find the sum of all the multiples of 3 or 5 below:");
				String input = Console.ReadLine();
			//input = Console.ReadLine();
				try
				{
					int sum = 0;
					int number = int.Parse(input);
					for(int i = 0; i < number; i++)
					{
						if(ismultipleof3or5(i))
						{
							sum += i;
						}
					}
					Console.WriteLine (sum.ToString());
				}
				catch(Exception e) {
					Console.WriteLine (e.Message);
				}
			}
		}
		private static Boolean ismultipleof3or5(int number)
		{
			if (number % 3 == 0 || number % 5 == 0) {
				return true;
			} else {
				return false;
			}
		}
	}
}
