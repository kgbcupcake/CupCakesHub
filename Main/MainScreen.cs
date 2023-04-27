using CupCakesHub.Interfaces.Gui;
using Pastel;
using static CupCakesHub.Interfaces.Functions;
using static System.Console;
namespace CupCakesHub.Main
{
	class MainScreen
	{
		private string gameVersion = "Version V.1 \n";
		//private string Info = "CupCakes's-Adventure v1 is a early Alpha project.\nAt the moment it only has a limited amount of  stuff ";





		public void mainScreen()
		{
			string title = "====Game Manager====";
			string GameTitle = @"                                            




   _____             _____      _               _    _       _     
  / ____|           / ____|    | |             | |  | |     | |    
 | |    _   _ _ __ | |     __ _| | _____  ___  | |__| |_   _| |__  
 | |   | | | | '_ \| |    / _` | |/ / _ \/ __| |  __  | | | | '_ \ 
 | |___| |_| | |_) | |___| (_| |   <  __/\__ \ | |  | | |_| | |_) |
  \_____\__,_| .__/ \_____\__,_|_|\_\___||___/ |_|  |_|\__,_|_.__/ 
             | |                                                   
             |_|                                                   







 
                                                                                   	";


			Title = title;
			ForegroundColor = ConsoleColor.Red;
			WriteLine(GameTitle.Pastel("#339595"));
			//WriteLine(Info.Pastel("#72168A"));
			//Default(46, 12);
			//SetCursorPosition(45,12);
			//WriteLine(gameVersion.Pastel("#5A057A"));





		WriteOnBottomLine(gameVersion.Pastel("#5A057A"));
			Write("						Press Enter To Enter : ");

			ConsoleKeyInfo key = ReadKey();
			Thread.Sleep(500);
			Clear();

			MainMenu.Mainmenu();

		}


	}


























}

