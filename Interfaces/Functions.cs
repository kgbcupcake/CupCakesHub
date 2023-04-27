using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Pastel;
namespace CupCakesHub.Interfaces
{
	public class Functions
	{
		/// <summary>
		/// Key Press to continue
		/// </summary>
		public static void WaitForAnyKeyPress()
		{
			Write("\nPress any key to continue....".Pastel("#210487"));
			ReadKey(true);
		}


		/// <summary>
		/// Writes Text on bottom of line
		/// </summary>
		/// <param name="Hello"></param>
		public static void WriteOnBottomLine(string Hello)
		{
			int x = CursorLeft;
			int y = CursorTop;
			CursorTop = WindowTop + WindowHeight - 1;
			Write(Hello);
			// Restore previous position
			SetCursorPosition(12, 12);
		}





		/// <summary>
		/// Prints Text
		/// </summary>
		/// <param name="text"></param>
		/// <param name="speed"></param>
		public static void Print(string text, int speed = 40)
		{
			foreach (char c in text)
			{
				WriteLine("c");
				Thread.Sleep(speed);
			}

			WriteLine();

		}







	}
}
