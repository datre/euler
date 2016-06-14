using System;
using System.Collections.Generic;

namespace Project2
{
	class MainClass
	{
		private static int sum = 0;
		public static void Main (string[] args)
		{
			nextfib (1, 2);
			Console.WriteLine (sum.ToString());
		}
		private static void nextfib(int prev, int now)
		{
			if(now<4000000)
			{
				if (now % 2 == 0) {
					sum += now;
				}
					nextfib(now, now+prev);
			}
		}
	}
}
