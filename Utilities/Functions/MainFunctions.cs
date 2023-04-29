using CupCakeslauncher.Main;
using Pastel;
using static System.Console;
namespace CupCakes_launcher.Utilities.MainFunctions
{
    public class MainFunctions
    {


		public static string Indent(int count)
		{
			return "".PadLeft(count);
		}








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



		/// <summary>
		/// LineBreak
		/// </summary>
		public static void LineBreak()
		{
			WriteLine();
			WriteLine();
			WriteLine();
		}

        


        /// <summary>
        /// Exit Option
        /// </summary>
        public static void Exit()
        {

			//Exit
			Write((Indent(55) + "Press Enter To return to main menu : ".Pastel("#8A39A8")));
			ConsoleKeyInfo key = ReadKey();
			Clear();
			WriteLine("Returning to the main menu");
			Thread.Sleep(2000);
			Clear();
			MainMenu.Mainmenu();




		}

	}
}
