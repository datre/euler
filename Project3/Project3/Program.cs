using System;

namespace Project3
{
	class MainClass
	{
		private static long zahl = 600851475143;
		public static void Main (string[] args)
		{
			long teiler = 2;
			while (teiler<=zahl) {
				if (zahl % teiler == 0) {
					zahl /= teiler;
				} else {
					teiler++;
				}
			}				
			Console.WriteLine (teiler.ToString());

		}
	}
}
