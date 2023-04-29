using Pastel;
using static System.Console;
using static CupCakes_launcher.Utilities.MainFunctions.MainFunctions;
namespace CupCakeslauncher.Main
{
    class MainScreen
	{
		private string gameVersion = "Version V.1 \n";
		public void mainScreen()
		{
			string title = "====CupCakeslauncher====";
			string GameTitle = @"                                            




   _____             _____      _               _    _       _     
  / ____|           / ____|    | |             | |  | |     | |    
 | |    _   _ _ __ | |     __ _| | _____  ___  | |__| |_   _| |__  
 | |   | | | | '_ \| |    / _` | |/ / _ \/ __| |  __  | | | | '_ \ 
 | |___| |_| | |_) | |___| (_| |   <  __/\__ \ | |  | | |_| | |_) |
  \_____\__,_| .__/ \_____\__,_|_|\_\___||___/ |_|  |_|\__,_|_.__/ 
             | |                                                   
             |_|";


			Title = title;
			ForegroundColor = ConsoleColor.Red;
			WriteLine(GameTitle.Pastel("#339595"));
			WriteOnBottomLine(gameVersion.Pastel("#5A057A"));
			Write("						Press Enter To Enter : ");
			ConsoleKeyInfo key = ReadKey();
			Thread.Sleep(500);
			Clear();
			MainMenu.Mainmenu();
		}
	}
}