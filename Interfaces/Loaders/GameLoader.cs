using CupCakeslauncher.Main;
using Pastel;
using System.Diagnostics;
using static System.Console;
namespace CupCakeslauncher.Interfaces.NewFolder
{
	public class GameLoader
	{
		public static void LoadGameMenu()
		{
			string? GameTitle = "								=== Game Menu ===";

			Clear();
			WriteLine("Loading Game Plz wait....");
			Thread.Sleep(500);
			Clear();
			WriteLine(GameTitle);
			WriteLine();
			WriteLine();

			WriteLine("						==============================================".Pastel("#125874"));
			WriteLine("							  |(1)Name Of Game|                                          ");
			WriteLine("							  |(2)Name Of Game|												");

			WriteLine("							  |(3)Name Of Game|                                          ");
			WriteLine("							  |(4)Name Of Game|												");

			WriteLine("							  |(5)Name Of Game|                                          ");
			WriteLine("							  |(6)Name Of Game|												");
			WriteLine("							  |(E)Name Of Game|												");
			WriteLine("						==============================================".Pastel("#125874"));



			switch (ReadLine().ToUpper())
			{


				case "1":
					Clear();
					WriteLine("Loading Game Plz wait....");
					Thread.Sleep(1500);
					Clear();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.FileName = @"Add The Directory path here";
					Process.Start(startInfo);
					LoadGameMenu();
					break;
				case "2":
					ProcessStartInfo startInfo1 = new ProcessStartInfo();
					startInfo1.FileName = @"Add The Directory path here"; 
					Process.Start(startInfo1);
					LoadGameMenu();
					break;
				case "3":
					ProcessStartInfo startInfo2 = new ProcessStartInfo();
					startInfo2.FileName = @"Add The Directory path here"; 
					Process.Start(startInfo2);
					LoadGameMenu();
					break;
				case "4":
					ProcessStartInfo startInfo3 = new ProcessStartInfo();
					startInfo3.FileName = @"Add The Directory path here"; 
					Process.Start(startInfo3);
					LoadGameMenu();
					break;
				case "5":
					ProcessStartInfo startInfo4 = new ProcessStartInfo();
					startInfo4.FileName = @"Add The Directory path here"; 
					Process.Start(startInfo4);
					LoadGameMenu();
					break;
				case "E":
					Clear();
					Thread.Sleep(200);
					Clear();
					MainMenu.Mainmenu();
					break;
				default:
					Clear();
					WriteLine("Plz Enter The Right Letter ");
					LoadGameMenu();
					break;
			}
		}
	}
}
