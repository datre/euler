using System;

namespace Project4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int zahl = 0;
			int fak1 = 0, fak2 = 0;
			Boolean BreakOut = false;
			//isPalindrom (9009);
			for (int i = 9999; i > 1000; i--) 
			{
				for (int a = 9999; a > 1000; a--) 
				{
					zahl = i * a;
					if (isPalindrom (zahl))
					{
						fak1 = i;
						fak2 = a;
						BreakOut = true;
						break;
					}

				}
				if (BreakOut) {
					break;
				}
			}

			Console.WriteLine (zahl.ToString() + " = " + fak1.ToString() + " * " + fak2.ToString());
		}

		private static Boolean isPalindrom(int zahl)
		{
			char[] temp = zahl.ToString ().ToCharArray ();
			Array.Reverse (temp);
			string comperator = new string (temp);
			if ( zahl.ToString ().Equals (comperator)) {
				return true;
			}
			return false;
		}
	}
}
